using System.IO;
using System.Linq;

namespace VRPE_Installer
{
    internal class PathLogger
    {
        public static string rookiePath = string.Empty;
        public static string vrpguiPath = string.Empty; 
        public static void AccessPaths()
        {
            if (MainWindow.RSLPathExists)
            {
                rookiePath = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                vrpguiPath = File.ReadLines(@"C:/RSL/VRPGUIPath.txt").First();
            }
        }

        public static void LogRookie(string selectedPath, string ver)
        {
            var folderName = $"rookie_{ver}_portable";
            var RSLPATH = @"C:\RSL\";
            var fullPath = Path.Combine(selectedPath, folderName);
            // If the VRPE directory doesn't already exist, create the directory and a RookiePath.txt to log the path within.
            if (!MainWindow.RSLPathExists)
            {
                Directory.CreateDirectory(@"C:/RSL");
                using (StreamWriter sw = File.CreateText($"{RSLPATH}/RookiePath.txt"))
                {
                    sw.WriteLine($"{fullPath}");
                }
            }
            // If the VRPE directory does already exist, overwrite RookiePath.txt to log the new path within.
            else
            {
                using (StreamWriter sw = File.CreateText($"{RSLPATH}/RookiePath.txt"))
                {
                    sw.WriteLine($"{fullPath}");
                }
            }
        }

        public static void LogVRPGUI(string selectedPathVRPGUI, string fixPath)
        {
            var createFolderPathVRPGUI = Path.GetFullPath($"{selectedPathVRPGUI}{fixPath}VRP-GUI");
            var RSLPATH = @"C:\RSL\";
            // If the VRPE directory doesn't already exist, create the directory and a VRPGUIPath.txt to log the path within.
            if (!MainWindow.RSLPathExists)
            {
                Directory.CreateDirectory(@"C:/RSL");
                using (StreamWriter sw = File.CreateText($"{RSLPATH}/VRPGUIPath.txt"))
                {
                    sw.WriteLine(createFolderPathVRPGUI);
                }
            }
            // If the VRPE directory does already exist, overwrite VRPGUIPath.txt to log the new path within.
            else
            {
                using (StreamWriter sw = File.CreateText($"{RSLPATH}/VRPGUIPath.txt"))
                {
                    sw.WriteLine(createFolderPathVRPGUI);
                }
            }
        }
    }
}
