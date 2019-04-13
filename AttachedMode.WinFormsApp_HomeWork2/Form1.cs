using AttachedMode.Services_HomeWork2;
using System;
using System.Windows.Forms;

namespace AttachedMode.WinFormsApp_HomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatedDB.Create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateTableDB.Create();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DropTableDB.Drop();
        }
    }
}
