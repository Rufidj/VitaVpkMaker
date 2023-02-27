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

namespace PSVITA_VPK_MAKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folder_txt.Text= folderBrowserDialog1.SelectedPath; 
        }

        private void btnVpk_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("Archivos vpk (*.vpk)|*.vpk");
            saveFileDialog1.ShowDialog();
            vpk_txt.Text=saveFileDialog1.FileName;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("make.bat");
            sw.WriteLine("sfo --new-file -a str app_ver "+app_txt.Text+" -a str title "+title_txt.Text+" -a str stitle "+stitle_txt.Text+" -a str title_id "+id_txt.Text+" param.sfo");
            File.Delete("param.sfo");
           
           //sw.WriteLine("pause");
            sw.Close();
            Process myproc;
            myproc = new Process();

            //No se lanza un evento cuando el programa sale
            myproc.EnableRaisingEvents = false;
            // creo la info del proceso
            ProcessStartInfo psi = new ProcessStartInfo("make.bat");
            myproc.StartInfo = psi;
            // comienza
            myproc.Start();
            Thread.Sleep(3000);
            File.Copy("param.sfo", folderBrowserDialog1.SelectedPath + "/sce_sys/param.sfo");
            ZipFile.CreateFromDirectory(folderBrowserDialog1.SelectedPath,saveFileDialog1.FileName);

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Acerca frm = new Acerca();

            frm.Show();
        }
    }
}
