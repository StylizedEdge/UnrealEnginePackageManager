using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] paths = new string[]
            {
                textBox1.Text,
                textBox2.Text
            };
            MethodBook.CreateZip(paths, destinationtext.Text);
        }
    }
}
