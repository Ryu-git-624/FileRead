using System;
using System.Windows.Forms;

namespace FileRead
{
    public partial class ReadForm : Form
    {
        private readonly IFile _member;

        public ReadForm(string memberKind)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _member = MemberFactory.Create(memberKind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _member.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _member.Write();
        }
    }
}
