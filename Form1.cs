using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.CheckedIndices.Count.ToString();
            label2.Text = checkedListBox1.CheckedItems.Count.ToString();
            label3.Text = checkedListBox1.SelectedIndices.Count.ToString();
            label4.Text = checkedListBox1.SelectedItems.Count.ToString();
        }
    }
}
