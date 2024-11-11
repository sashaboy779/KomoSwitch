using System;
using System.Drawing;
using Microsoft.Win32;
using Serilog;

namespace KomoSwitch.Services
{
    public static class ColorManager
    {
        public static class Windows
        {
            public static Color AccentColor { get; set; }

            public static Color DefaultAccentColor { get; } = Color.FromArgb(255, 0, 120, 215);

        }
        
        public static class Workspace
        {
            public static Color Active => Settings.Instance.SyncWithWindowsTheme
                ? Windows.AccentColor
                : ColorTranslator.FromHtml(Settings.Instance.WorkspaceNameColors.Active); 
            
            public static Color Default => ColorTranslator.FromHtml(Settings.Instance.WorkspaceNameColors.Default); 
        }
        
        public static class StatusLine
        {
            public static Color Active => Settings.Instance.SyncWithWindowsTheme
                ? Windows.AccentColor
                : ColorTranslator.FromHtml(Settings.Instance.StatusLineColors.Active); 
        }

        public static void Initialize()
        {
            Windows.AccentColor = GetDwmAccentColor() ?? Windows.DefaultAccentColor;
        }
        
        private static Color? GetDwmAccentColor()
        {
            try
            {
                const string registryKeyPath = @"Software\Microsoft\Windows\DWM";
                const string valueName = "AccentColor";
                
                using (var key = Registry.CurrentUser.OpenSubKey(registryKeyPath))
                {
                    var color = key?.GetValue(valueName);
                    if (color is null)
                    {
                        Log.Error("Failed to read registry for accent color");
                        return null;
                    }

                    var abgr = unchecked((uint)(int)color);
                    var a = (byte)((abgr & 0xFF000000) >> 24);
                    var b = (byte)((abgr & 0x00FF0000) >> 16);
                    var g = (byte)((abgr & 0x0000FF00) >> 8);
                    var r = (byte)(abgr & 0x000000FF);
                    
                    return Color.FromArgb(a, r, g, b);
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Unable to get accent color: {Message}", e.Message);
                return null;
            }
        }
    }
}