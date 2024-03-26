using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
namespace ConfirmTaskOpen
{
    public partial class ConfirmTaskOpen : Form
    {

        public string appPath = Application.ExecutablePath;
        public string targetPath;

        public string taskPath;
        public string taskArgs;
        public string taskName;


        public ConfirmTaskOpen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] passedArgs = Environment.GetCommandLineArgs();
            string[] parsedStrings = new string[3];

            if (passedArgs.Count() > 1)
            {

                parsedStrings = parseStrings(passedArgs);

                taskPath = parsedStrings[0];
                taskArgs = parsedStrings[1];
                taskName = parsedStrings[2];
            }
            else
            {
                taskPath = "";
                taskArgs = "";
                taskName = "";

            }

            if (parsedStrings.Count()>1)
            { 
               pathTextbox.Text = taskArgs;
               nameTextbox.Text = taskName;
            }
            openBtn.Select();
        }

        public  string[] parseStrings(string[] passedArgs)
        {
            string[] parsedStrings = new string[3];

            parsedStrings[0] = appPath;


            parsedStrings[1] = passedArgs[1];
            parsedStrings[2] = (Path.GetFileName(parsedStrings[1])).Replace(".exe", "");

            return parsedStrings;   
        }

        private void ConfirmTaskOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(taskArgs);
            Thread.Sleep(500); // Allow the process to open it's window
            Application.Exit();
        }

        private void shortcutBtn_Click(object sender, EventArgs e)
        {
            CreateShortcut();
        }

        private void CreateShortcut()
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\" + taskName + ".lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Arguments = "\"" + taskArgs + "\"";
            shortcut.TargetPath = appPath;
            shortcut.IconLocation = taskArgs;
            shortcut.Save();
        }

        private void pathTextbox_TextChanged(object sender, EventArgs e)
        {
            taskArgs = pathTextbox.Text;
        }
    }
}
