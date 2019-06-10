// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EchoData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtobufWeb.ProtoGen {

  /// <summary>Holder for reflection information generated from EchoData.proto</summary>
  public static partial class EchoDataReflection {

    #region Descriptor
    /// <summary>File descriptor for EchoData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EchoDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5FY2hvRGF0YS5wcm90byIlCghFY2hvRGF0YRIMCgR0ZXh0GAEgASgJEgsK",
            "A2FnZRgCIAEoBUIXqgIUUHJvdG9idWZXZWIuUHJvdG9HZW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtobufWeb.ProtoGen.EchoData), global::ProtobufWeb.ProtoGen.EchoData.Parser, new[]{ "Text", "Age" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EchoData : pb::IMessage<EchoData> {
    private static readonly pb::MessageParser<EchoData> _parser = new pb::MessageParser<EchoData>(() => new EchoData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EchoData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufWeb.ProtoGen.EchoDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoData(EchoData other) : this() {
      text_ = other.text_;
      age_ = other.age_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoData Clone() {
      return new EchoData(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 2;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EchoData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EchoData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (Age != other.Age) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EchoData other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Text = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
