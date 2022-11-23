using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace VRPE_Installer
{
    internal class Downloader
    {
        public class HttpClientDownloadWithProgress : IDisposable
        {
            private readonly string _downloadUrl;
            private readonly string _destinationFilePath;
            public static string rookieDL = string.Empty;

            private HttpClient _httpClient;

            public HttpClientDownloadWithProgress(string downloadUrl, string destinationFilePath)
            {
                _downloadUrl = downloadUrl;
                _destinationFilePath = destinationFilePath;
            }

            public async Task StartDownload()
            {
                _httpClient = new HttpClient { Timeout = TimeSpan.FromDays(1) };

                using (var response = await _httpClient.GetAsync(_downloadUrl, HttpCompletionOption.ResponseHeadersRead))
                    await DownloadFileFromHttpResponseMessage(response);
            }

            private async Task DownloadFileFromHttpResponseMessage(HttpResponseMessage response)
            {
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength;

                using (var contentStream = await response.Content.ReadAsStreamAsync())
                    await ProcessContentStream(totalBytes, contentStream);
            }

            private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream)
            {
                var totalBytesRead = 0L;
                var readCount = 0L;
                var buffer = new byte[8192];
                var isMoreToRead = true;

                using (var fileStream = new FileStream(_destinationFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                {
                    do
                    {
                        var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            isMoreToRead = false;
                            continue;
                        }

                        await fileStream.WriteAsync(buffer, 0, bytesRead);

                        totalBytesRead += bytesRead;
                        readCount += 1;
                    }
                    while (isMoreToRead);
                }
            }

            public void Dispose()
            {
                _httpClient?.Dispose();
            }
        }

        // Downloads Rookie from a link that is defined in the github repo file (HTTP Client fetches the string)
        public static async Task GetRookie()
        {
            HttpClient githubgetter = new HttpClient();
            string rookieLink = "https://raw.githubusercontent.com/Chax1/TestLinks/main/RookieLink";
            string rookieDL = githubgetter.GetStringAsync($"{rookieLink}").Result;
            var downloadFileUrl = $"{rookieDL}";
            var destinationFilePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}RSL.zip");
        try
            {
                using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePath))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    await client.StartDownload();
                }
            }
        catch (Exception ex)
            {
                string message =
                   $"{ex.Message}";
                string caption = "Error while Downloading!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Downloads the VRP GUI from a link that is defined in the github repo file (HTTP Client fetches the string)
        public static async Task GetVRPGUI()
        {
            HttpClient githubgetter = new HttpClient();
            string VRPGUILink = "https://raw.githubusercontent.com/Chax1/TestLinks/main/VRPGUILink";
            string VRPGUIDL = githubgetter.GetStringAsync($"{VRPGUILink}").Result;
            var downloadFileUrl = $"{VRPGUIDL}";
            var destinationFilePathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRPGUI.zip");
        try
            {
            using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePathVRPGUI))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    await client.StartDownload();
                }
            }
        catch (Exception ex)
            {
                string message =
                   $"{ex.Message}";
                string caption = "Error while Downloading!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Checks which arhitecture the user is on and downloads the correct Installer exe

        public static async Task GetResilio()
        {
            if (!Environment.Is64BitOperatingSystem)
            {
                var downloadFileUrl = "https://download-cdn.resilio.com/stable/windows/Resilio-Sync.exe";
                var destinationFilePathResilio = Path.GetFullPath($"{MainWindow.selectedPathResilio}{MainWindow.fixPath}Resilio-Sync.exe");
            try
                {
                using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePathResilio))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    await client.StartDownload();
                    Process.Start($"{MainWindow.selectedPathResilio}{MainWindow.fixPath}Resilio-Sync.exe");
                    }
                }
            catch (Exception ex)
                {
                    string message =
                       $"{ex.Message}";
                    string caption = "Error while Downloading!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                {
                var downloadFileUrl64 = "https://download-cdn.resilio.com/stable/windows64/Resilio-Sync_x64.exe";
                var destinationFilePathResilio64 = Path.GetFullPath($"{MainWindow.selectedPathResilio}{MainWindow.fixPath}Resilio-Sync_64.exe");
            try
                {
                using (var client = new HttpClientDownloadWithProgress(downloadFileUrl64, destinationFilePathResilio64))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    await client.StartDownload();
                    Process.Start($"{MainWindow.selectedPathResilio}{MainWindow.fixPath}Resilio-Sync_64.exe");
                    }
                }
            catch (Exception ex)
            {
                string message =
                   $"{ex.Message}";
                string caption = "Error while Downloading!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }
    }
}