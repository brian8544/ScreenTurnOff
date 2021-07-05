echo off
cls

if exist "C:\Program Files\dotnet" (

rd /s /q bin\
rd /s /q obj\
cls
dotnet build Project.sln
pause

)else (

echo No .NET Core found!
echo Launching download...
start https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.7-windows-x64-installer
echo Start this batch file again, when installation is complete.
pause
)