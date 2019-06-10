# Requirement

- .Net Core SDK 2.2
- Node.js(use npm command)

# Environment Setup

## Install .Net Core SDK 2.2
## Install Node.js
### Install browserify
```
npm install -g browserify
```

### Install protoc.exe

Download protoc from GitHub [Protocol Buffers Releases](https://github.com/protocolbuffers/protobuf/releases) [download protoc-3.8.0-win64.zip](https://github.com/protocolbuffers/protobuf/releases/download/v3.8.0/protoc-3.8.0-win64.zip)

Extract file to C:\bin and Add into PATH Environment Variables.
```
SET PATH=%PATH%;C:\bin
```

## Generate C# and JavaScript Code

```
cd ProtobufWebSample\ProtobufWeb\protos
gen.bat
```

## Run web service

```
cd ProtobufWebSample\ProtobufWeb
dotnet run
```

open browser goto http://localhost:5001/index.html

# Reference
- [javascript 前端，使用 google-protobuf，後端用 asp.net core 2 傳送接收](https://uzch.blogspot.com/2019/06/javascript-google-protobuf-aspnet-core-2.html)
- [Protocol Buffers - C# Generated Code](https://developers.google.com/protocol-buffers/docs/reference/csharp-generated)
- [Protocol Buffers - JavaScript Generated Code](https://developers.google.com/protocol-buffers/docs/reference/javascript-generated)
