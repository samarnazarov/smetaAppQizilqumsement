using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmetaApp
{
    public partial class NazvaniyeStroyka : Form
    {
        public NazvaniyeStroyka()
        {
            InitializeComponent();
        }

        private void saveNazvanieStroyka_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
