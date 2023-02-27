using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSVITA_VPK_MAKER
{
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void Acerca_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("L.txt");
            Acercatxt.Text = sr.ReadToEnd();
        }

        private void Acerca_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
