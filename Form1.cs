using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sinister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The latin word Sinister translates to the english word Left.");
        }

        private void dexter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The latin word Dexter translates to the english word Right");
        }

        private void medium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The latin word Medium translates to the english word Center");
        }
    }
}
