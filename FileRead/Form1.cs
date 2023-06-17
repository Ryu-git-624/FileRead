using System;
using System.Windows.Forms;

namespace FileRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var f = new ReadForm(comboBox1.Text))
            {
                f.ShowDialog();
            }
        }
    }
}
