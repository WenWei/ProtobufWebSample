namespace ProtobufWeb.Formatters
{
    using Google.Protobuf;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System;

    public static class ServicesConfiguration
    {
        public static void AddProtobufFormatter(this IServiceCollection services)
        {
            services.Configure<MvcOptions>(options =>
            {
                options.InputFormatters.Add(new ProtobufInputFormatter(new ProtobufFormatterOptions()));
                options.OutputFormatters.Add(new ProtobufOutputFormatter(new ProtobufFormatterOptions()));
                options.FormatterMappings.SetMediaTypeMappingForFormat("protobuf", Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/x-protobuf"));
            });
        }
    }

    public class ProtobufFormatterOptions
    {
        public HashSet<string> SupportedContentTypes { get; set; } = new HashSet<string> { "application/x-protobuf", "application/protobuf", "application/x-google-protobuf" };

        public HashSet<string> SupportedExtensions { get; set; } = new HashSet<string> { "proto" };

        public bool SuppressReadBuffering { get; set; } = false;
    }

    public class ProtobufInputFormatter : InputFormatter
    {
        private readonly ProtobufFormatterOptions _options;

        public ProtobufInputFormatter(ProtobufFormatterOptions protobufFormatterOptions)
        {
            _options = protobufFormatterOptions ?? throw new ArgumentNullException(nameof(protobufFormatterOptions));
            foreach (var contentType in protobufFormatterOptions.SupportedContentTypes)
            {
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(contentType));
            }
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            try
            {
                var request = context.HttpContext.Request;
                var obj = (IMessage)Activator.CreateInstance(context.ModelType);
                obj.MergeFrom(request.Body);

                return InputFormatterResult.SuccessAsync(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
                return InputFormatterResult.FailureAsync();
            }
        }
    }

    public class ProtobufOutputFormatter : OutputFormatter
    {
        private readonly ProtobufFormatterOptions _options;
        public string ContentType { get; private set; }

        public ProtobufOutputFormatter(ProtobufFormatterOptions protobufFormatterOptions)
        {
            ContentType = "application/x-protobuf";
            _options = protobufFormatterOptions ?? throw new ArgumentNullException(nameof(protobufFormatterOptions));
            foreach (var contentType in protobufFormatterOptions.SupportedContentTypes)
            {
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(contentType));
            }
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            var response = context.HttpContext.Response;

            // Proto-encode
            var protoObj = context.Object as IMessage;
            var serialized = protoObj.ToByteArray();

            return response.Body.WriteAsync(serialized, 0, serialized.Length);
        }
    }
}