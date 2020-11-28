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
|dotnet new nunit -o myPro.myCoreTest|新建测试项目|
|dotnet sln add myPro.App|向解决方案增加项目|
|dotnet add myPro.App reference myPro.Core|增加项目引用|
|dotnet add package Newtonsoft.Json|在项目增加包引用|
|dotnet run -p myPro.App|运行指定项目|
|dotnet restore|还原项目，恢复项目的依赖项和工具|
|dotnet store|将指定的程序集存储到运行时包存储区。|
|dotnet pack|生成 NuGet 包|
|dotnet msbuild|构建项目|
|dotnet build|构建项目，相当于 dotnet msbuild -restore|
|dotnet publist|将应用程序及其依赖项发布到文件夹以部署到托管系统|
|dotnet clean|清除项目默认生成|
|dotnet migrate|项目迁移|