@echo off
color 0A
title Launcher Build Tool

echo Setting up environment
set CWD=%~dp0
set MSFW=C:\Windows\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%MSFW%
set CFLAGS=/p:Configuration=Release;AllowUnsafeBlocks=true /p:CLSCompliant=False
set LDFLAGS=/tv:4.0 /p:TargetFrameworkVersion=v4.5 /p:Platform="Any Cpu" /p:OutputPath="%CWD%\bin"

echo Compiling program
msbuild swbf_launcher.sln %CFLAGS% %LDFLAGS%
if errorlevel 1 goto error

goto done

:error
echo An error occured during compilation. Check the output for errors
pause
exit

:done
echo Complete!
pause
