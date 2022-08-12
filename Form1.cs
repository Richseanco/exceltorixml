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

namespace exceltorixml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            processExcelButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OutputFilePath = new OpenFileDialog())
            {
                if (OutputFilePath.ShowDialog() == DialogResult.OK)
                {
                    string OutputString = OutputFilePath.FileName;

                    input_source_file.Text = OutputString;
                }
            }

        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processExcelButton_Click(object sender, EventArgs e)
        {
            RiXML.processExcel(input_source_file.Text);
            this.Close();
        }

        private void input_source_file_TextChanged(object sender, EventArgs e)
        {
            processExcelButton.Enabled = File.Exists(input_source_file.Text);
        }
    }
}
