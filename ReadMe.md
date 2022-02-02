# NativeAOT-LLVM WebAssembly C# Sample

Context:
* https://github.com/dotnet/runtimelab/issues/1835
* https://github.com/dotnet/runtimelab/issues/1841
* https://github.com/dotnet/runtimelab/issues/1842

## Build
```
dotnet publish -r browser-wasm -c Debug /p:TargetArchitecture=wasm --self-contained /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false /p:EmccExtraArgs=Test.c
```

Note `Test.c` is passed as a `EmccExtraArgs` parameter to `emcc`.

## Run

With node:
```
node .\bin\Debug\net6.0\browser-wasm\native\wasm.js
```

In a browser:  
Host a web-site under `.\bin\Debug\net6.0\browser-wasm\native\`. Open the site in the browser.

## Result

```
[Program.cs] Main
[Test.c] NativeFunc
[Program.cs] NativeFunc returns 123456
```
