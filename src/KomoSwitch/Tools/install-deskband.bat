@echo OFF
title Install KomoSwitch

@rem Check required argument is supplied
if %1 NEQ Debug (
    if %1 NEQ Release (
        echo Debug or Release argument is expected
        exit /b 1
    )
) 

@setlocal enableextensions
@cd /d "%~dp0"

rem Check permissions
net session >nul 2>&1
if %errorLevel% == 0 (
    echo Administrative permissions confirmed.
) else (
    echo Please run this script with administrator permissions.
    exit /b 1
)

@rem Install Deskband
if %1==Debug (
    set dllPath=../bin/Debug/KomoSwitch.dll
) else (
    set dllPath=../bin/Release/KomoSwitch.dll
)

if defined %PROGRAMFILES(x86)% (
    %SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /nologo /codebase %dllPath% >nul
) else (
    %SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /nologo /codebase %dllPath% >nul
)

if %errorLevel% == 0 (
    echo Deskband was successfully installed.
) else (
    echo An error occured in regasm.exe
    exit /b 1
)