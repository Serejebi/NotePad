using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {



        string fileName;
        public Form1()
        {
            InitializeComponent();
        }


        private void save_Click(object sender, EventArgs e)
        {

            if (fileName == null)
            {
                saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";
                saveFileDialog1.DefaultExt = "txt";
                DialogResult result = saveFileDialog1.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    return;
                }
                fileName = saveFileDialog1.FileName;
            }

            System.IO.File.WriteAllText(fileName,Body.Text);
            this.Text = fileName;

        }

    

        private void SaveAs_Click(object sender, EventArgs e)
        {
            fileName = null;
            save_Click(null, null);
        }
    }
}
