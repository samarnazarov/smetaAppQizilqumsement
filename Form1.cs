using System;
using System.Windows.Forms;

namespace SmetaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StroykaToolStripMenu_Click(object sender, EventArgs e)
        {
            NazvaniyeStroyka formNameStroyka = new NazvaniyeStroyka();
            formNameStroyka.Show();
        }


    }
}
