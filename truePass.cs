using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace L.E.N.I.N
{
    public partial class truePass : Form
    {
        public truePass()
        {
            InitializeComponent();
        }

        private void truePass_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
