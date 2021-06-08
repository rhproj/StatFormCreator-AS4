using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatFormCreator00
{
    public partial class AddSection : Form
    {
        public int sectionCount = 0;
        public AddSection()
        {
            InitializeComponent();
        }


        private void AddSection_Load(object sender, EventArgs e)
        {
            sectionCount = Application.OpenForms.OfType<AddSection>().Count(); //counts open forms

            tbSectN.Text = sectionCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
