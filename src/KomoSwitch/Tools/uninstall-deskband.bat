@echo OFF
title Uninstall KomoSwitch

@rem Check required argument is supplied
if %1 NEQ Debug (
    if %1 NEQ Release (
        echo Debug or Release argument is expected
        exit /b 1
    )
) 

@setlocal enableextensions
@cd /d "%~dp0"

@rem Check permissions
net session >nul 2>&1
if %errorLevel% == 0 (
    echo Administrative permissions confirmed.
) else (
    echo Please run this script with administrator permissions.
    exit /b 1
)

@rem Uninstall Deskband
if %1==Debug (
    set dllPath=../bin/Debug/KomoSwitch.dll
) else (
    set dllPath=../bin/Release/KomoSwitch.dll
)

if defined %PROGRAMFILES(x86)% (
    %SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /u %dllPath% >nul
) else (
    %SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /u %dllPath% >nul
)

if %errorLevel% == 0 (
    echo Deskband was successfully uninstalled.
) else (
    echo An error occured in regasm.exe
    exit /b 1
)

@rem Restart explorer
taskkill /f /im explorer.exe >nul
start explorer.exe >nul

if %errorLevel% == 0 (
    echo Explorer process has been successfully restarted.
) else (
    echo An error occured when restarting explorer.exe
    exit /b 1
)