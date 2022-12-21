using IWshRuntimeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using VRPE_Installer.Properties;

namespace VRPE_Installer
{
    internal class ShortcutMaker
    {
        public static void CreateShortcutRookie(string selectedPath, string fixPath, string ver)
        {
            var folderName = $"rookie_{ver}_portable";
            var targetFolder = Path.Combine(selectedPath, folderName);
            var finishedPath = Path.Combine(targetFolder, $"Sideloader Launcher.exe");
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Rookie.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Rookie Sideloader";
            shortcut.IconLocation = @"C:\RSL\Rookie.ico";
            shortcut.WorkingDirectory = targetFolder;
            shortcut.TargetPath = finishedPath;
            shortcut.Save();
        }

        public static void CreateShortcutShortcutMaker(string selectedPathShortcutMaker, string fixPath)
        {
            var folderName = $"shortcut maker";
            var targetFolder = Path.Combine(selectedPathShortcutMaker, folderName);
            var finishedPath = Path.Combine(targetFolder, $"VRPShortcutMaker.exe");
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\VRP Shortcut Maker.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Shortcut Maker";
            shortcut.IconLocation = @"C:\RSL\SM.ico";
            shortcut.WorkingDirectory = targetFolder;
            shortcut.TargetPath = finishedPath; 
            shortcut.Save();
        }

        public static void CreateShortcutVRPGUI(string selectedPathVRPGUI, string fixPath)
        {
            var folderName = $"VRP-GUI";
            var targetFolder = Path.Combine(selectedPathVRPGUI, folderName);
            var finishedPath = Path.Combine(targetFolder, $"RcloneBrowser.exe");
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\VRP GUI.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "VRP GUI";
            shortcut.IconLocation = @"C:\RSL\RCLONE.ico";
            shortcut.WorkingDirectory = targetFolder;
            shortcut.TargetPath = finishedPath; 
            shortcut.Save();
        }
    }
}
