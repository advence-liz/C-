# csharp
最开始想着vscode 配合dotnet core,后来感觉蛋疼还是用 vs2017了
master 即 sln 所在位置
## tip
- C:\GIT\csharp\bin\Debug\netcoreapp1.1>dotnet hwapp.dll 
- launch.json
```json
 {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceRoot}/bin/Debug/netcoreapp1.1/hwapp.dll",
            "args": [],
            "cwd": "${workspaceRoot}",
            "stopAtEntry": false,
            "console": "internalConsole"
        },
```