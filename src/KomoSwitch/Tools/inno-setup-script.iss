[Setup]
AppId={{DE5C9F6B-A02C-4ED3-9779-DFDA49667362}}
AppName=KomoSwitch
AppVersion=0.2.0-alpha
DefaultDirName={commonpf64}\KomoSwitch
OutputDir=.\Output
OutputBaseFilename=KomoSwitchSetup-x64-0.2.0-alpha
PrivilegesRequired=admin
ArchitecturesInstallIn64BitMode=x64compatible

[Files]
Source: "InstallerFiles\KomoSwitch.dll"; DestDir: "{app}"; Flags: ignoreversion;
Source: "InstallerFiles\KomoSwitch.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\KomoSwitch.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Microsoft.Win32.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\netstandard.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.Enrichers.Thread.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.Enrichers.Thread.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.Sinks.File.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.Sinks.File.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\Serilog.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.AppContext.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Collections.Concurrent.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Collections.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Collections.NonGeneric.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Collections.Specialized.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ComponentModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ComponentModel.EventBasedAsync.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ComponentModel.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ComponentModel.TypeConverter.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Console.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Data.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.Contracts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.Debug.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.DiagnosticSource.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.FileVersionInfo.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.Process.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.StackTrace.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.TextWriterTraceListener.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.Tools.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.TraceSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Diagnostics.Tracing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Drawing.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Dynamic.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Globalization.Calendars.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Globalization.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Globalization.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.Compression.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.Compression.ZipFile.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.FileSystem.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.FileSystem.DriveInfo.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.FileSystem.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.FileSystem.Watcher.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.IsolatedStorage.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.MemoryMappedFiles.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.Pipes.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.IO.UnmanagedMemoryStream.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Linq.Expressions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Linq.Parallel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Linq.Queryable.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Http.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.NameResolution.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.NetworkInformation.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Ping.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Requests.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Security.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.Sockets.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.WebHeaderCollection.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.WebSockets.Client.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Net.WebSockets.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Reflection.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Reflection.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Reflection.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Resources.Reader.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Resources.ResourceManager.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Resources.Writer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.CompilerServices.VisualC.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Handles.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.InteropServices.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.InteropServices.RuntimeInformation.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Numerics.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Serialization.Formatters.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Serialization.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Serialization.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Runtime.Serialization.Xml.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Claims.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Cryptography.Algorithms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Cryptography.Csp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Cryptography.Encoding.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Cryptography.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Cryptography.X509Certificates.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.Principal.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Security.SecureString.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Text.Encoding.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Text.Encoding.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Text.RegularExpressions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Channels.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Channels.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Overlapped.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Tasks.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Tasks.Parallel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Thread.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.ThreadPool.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Threading.Timer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.ReaderWriter.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.XDocument.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.XmlDocument.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.XmlSerializer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.XPath.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "InstallerFiles\System.Xml.XPath.XDocument.dll"; DestDir: "{app}"; Flags: ignoreversion

[Run]
Filename: "{dotnet40}\regasm.exe"; Parameters: "/nologo /codebase ""{app}\KomoSwitch.dll"""; Flags: runhidden; BeforeInstall: ShowExplorerRestartMessage
Filename: "cmd.exe"; Parameters: "/c taskkill /f /im explorer.exe && start explorer.exe"; Flags: runhidden waituntilterminated

[Code]
function InitializeSetup: Boolean;
begin
  Result := IsDotNetInstalled(net462, 0);
  if not Result then
    SuppressibleMsgBox(FmtMessage(SetupMessage(msgWinVersionTooLowError), ['.NET Framework', '4.6.2']), mbCriticalError, MB_OK, IDOK);
end;

procedure ShowExplorerRestartMessage();
begin
  MsgBox('Windows Explorer will now restart', mbInformation, MB_OK);
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
var
  ResultCode : integer;
begin
  case CurUninstallStep of
    usUninstall:
      begin
        MsgBox('Windows Explorer will now restart', mbInformation, MB_OK);
        
        if Exec(ExpandConstant('{dotnet40}\regasm.exe'), '/u "' + ExpandConstant('{app}\KomoSwitch.dll') + '"', '', SW_HIDE, ewWaitUntilTerminated, ResultCode) then
        begin
          Exec('cmd.exe', '/c taskkill /f /im explorer.exe && start explorer.exe', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
        end;
      end;
  end;
end;