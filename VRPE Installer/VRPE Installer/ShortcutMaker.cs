using IWshRuntimeLibrary;
using System;
using System.IO;

namespace VRPE_Installer
{
    internal class ShortcutMaker
    {
        public static void CreateShortcutRookie(string selectedPath, string fixPath, string ver)
        {
            var folderName = $"rookie_{ver}_portable";
            var targetFolder = Path.Combine(selectedPath, folderName);
            var finishedPath = Path.Combine(targetFolder, $"AndroidSideloader_v{ver}.exe");
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Rookie.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Rookie Sideloader";
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
            shortcut.WorkingDirectory = targetFolder;
            shortcut.TargetPath = finishedPath; 
            shortcut.Save();
        }
    }
}
