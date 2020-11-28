# test dotnet in vscode

## 下载vscode

> [vscode下载地址](https://code.visualstudio.com/download)

***
## 安装 .net core sdk

> [下载地址](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)

***
## PowerShell中运行命令
|命令|功能|
|---|---|
|dotnet new sln -n myPro|新建解决方案文件|
|dotnet new console -n myPro.App|新建控制台项目|
|dotnet new classlib -n myPro.Core|新建类库项目|
|dotnet sln add myPro.App|向解决方案增加项目|
|dotnet add myPro.App reference myPro.Core|增加项目引用|
|dotnet run -p myPro.App|运行指定项目|