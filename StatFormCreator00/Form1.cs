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

namespace StatFormCreator00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbN.Text = "";
            tbMonth.Text = ""; 
            tbYear.Text = "";
            tbName.Text = "";
            tbPeriod.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory + $@"\{tbYear.Text}_{tbMonth.Text}.{tbN.Text}";
            string filePath = dir + $@"\{tbN.Text}_{tbYear.Text.Substring(2,2)}{tbMonth.Text}.TXT";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.Write($@"Форма {tbName.Text}" + System.Environment.NewLine + $@"N_PERIOD {tbPeriod.Text}");
                    //sw.WriteLine($@"N_PERIOD {tbPeriod.Text}");
                };
                MessageBox.Show("Готово!");
            }
            else
            {
                MessageBox.Show($@"Папка {tbYear.Text}_{tbMonth.Text}.{tbN.Text} уже существует");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSection Section = new AddSection();
            //lbxSctn.Text = "01";

            

            Section.Show();
        }
    }
}


//if (lbxSctn.Items.Count > 0)
//{
//}