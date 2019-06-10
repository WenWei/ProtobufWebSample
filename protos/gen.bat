@echo on
SET PWD=%~dp0

set PROTOC=C:\bin\protoc.exe
set CSHARP_OUT=%PWD%gen\csharp
set JS_OUT=%PWD%gen\js

rd /S /Q %CSHARP_OUT%
md %CSHARP_OUT%
rd /S /Q %JS_OUT%
md %JS_OUT%

%PROTOC% --proto_path=C:/bin/include/google/protobuf --proto_path=%PWD%^
         --csharp_out=%CSHARP_OUT%^
         %PWD%EchoData.proto
 

%PROTOC% --proto_path=C:/bin/include/google/protobuf --proto_path=%PWD%^
         --js_out=import_style=commonjs,binary:%JS_OUT%^
         %PWD%EchoData.proto

echo var echodataProto = require('./EchoData_pb'); > %JS_OUT%\exports.js
echo module.exports = { >> %JS_OUT%\exports.js
echo     EchoDataProto: echodataProto >> %JS_OUT%\exports.js
echo } >> %JS_OUT%\exports.js

cd %JS_OUT%
call npm install google-protobuf

browserify exports.js > bundle.js

cd %PWD%
