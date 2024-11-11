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
                : ColorTranslator.FromHtml(Settings.Instance.WorkspaceColors.Active); 
            
            public static Color Default => ColorTranslator.FromHtml(Settings.Instance.WorkspaceColors.Default); 
            
            public static Color Waiting => ColorTranslator.FromHtml(Settings.Instance.WorkspaceColors.Waiting); 
            
            public static Color Error => ColorTranslator.FromHtml(Settings.Instance.WorkspaceColors.Error); 
        }
        
        public static class WorkspaceBackground
        {
            public static Color Default => ColorTranslator.FromHtml(Settings.Instance.WorkspaceBackgroundColors.Default); 
            
            public static Color Active => ColorTranslator.FromHtml(Settings.Instance.WorkspaceBackgroundColors.Active); 
            
            public static Color Hover => ColorTranslator.FromHtml(Settings.Instance.WorkspaceBackgroundColors.Hover); 
            
            public static Color HoverWhenActive => ColorTranslator.FromHtml(Settings.Instance.WorkspaceBackgroundColors.HoverWhenActive); 
        }
        
        public static class StatusLine
        {
            public static Color Active => Settings.Instance.SyncWithWindowsTheme
                ? Windows.AccentColor
                : ColorTranslator.FromHtml(Settings.Instance.StatusLineColors.Active); 
            
            public static Color ActiveWhenWaiting => ColorTranslator.FromHtml(Settings.Instance.StatusLineColors.ActiveWhenWaiting); 
           
            public static Color Waiting => ColorTranslator.FromHtml(Settings.Instance.StatusLineColors.Waiting); 
           
            public static Color Error => ColorTranslator.FromHtml(Settings.Instance.StatusLineColors.Error); 
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