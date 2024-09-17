using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installer
{
    public partial class Form1 : Form
    {
        private bool installing = false;
        private const string AppName = "TogglWindowsApp";
        private string _installDir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        private CancellationTokenSource _cancelSource;
        public Form1()
        {
            InitializeComponent();
            SetInstallDirectory(_installDir);
            installingLabel.Visible = false;
        }

        private string FullFolderPath(string dir) => Path.Combine(dir, AppName);

        private void SetInstallDirectory(string installDir)
        {
            bool exists;
            try
            {
                exists = Directory.Exists(installDir);
            }
            catch
            {
                exists = false;
            }
            if (!exists)
            {
                MessageBox.Show("Folder does not exist");
                return;
            }
            _installDir = installDir;
            installDirectoryLabel.Text = _installDir;
            fullPathLabel.Text = FullFolderPath(_installDir);
            FormClosing += (s, args) => {
                _cancelSource?.Cancel();
            };
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            SetInstallDirectory(dialog.SelectedPath);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (installing)
            {
                var result = MessageBox.Show("The software is installing are you sure?", "Please confirm", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;
            }
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("The selected FULL PATH will be cleared before installing are you sure you want to continue?", "Please confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            installing = true;
            nextButton.Enabled = false;
            _cancelSource = new CancellationTokenSource();
            installingLabel.Visible = true;
            Task.Run(InstallTask, _cancelSource.Token);
        }

        private void InstallTask()
        {
            try
            {
                var path = FullFolderPath(_installDir);
                //var backendExePath = Path.Combine(path, "cmsmonitor.exe");
                /* var key = Registry.ClassesRoot.CreateSubKey("cmsmonitor");
                key.SetValue("URL Protocol", "");
                key.SetValue("", "Monitoring software");
                var shellKey = key.CreateSubKey("shell");
                var openKe = shellKey.CreateSubKey("open");
                var commandKey = openKe.CreateSubKey("command");
                commandKey.SetValue("", $"\"{backendExePath}\" \"%1\"");*/

                var bytes = Properties.Resources.install;
                MemoryStream stream = new MemoryStream(bytes);
                ZipArchive archive = new ZipArchive(stream);

                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
                Directory.CreateDirectory(path);
                archive.ExtractToDirectory(path);
                File.Copy(Path.Combine(path, "TogglAutomationApp.exe"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TogglAutomationApp.exe"));
                Invoke(new Action(() => {
                    installingLabel.Text = "Installed!";
                }));
                installing = false;
                MessageBox.Show("Software installed");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR INSTALLING SOFTWARE: " + ex.ToString());
                //
            }
        }
    }
}
