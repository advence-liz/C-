# csharp
学习&amp;研究&amp;总结&amp;整理
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