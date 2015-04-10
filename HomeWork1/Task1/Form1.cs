using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", byte.MinValue.ToString(), byte.MaxValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", sbyte.MinValue.ToString(), sbyte.MaxValue.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", short.MinValue.ToString(), short.MaxValue.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", ushort.MinValue.ToString(), ushort.MaxValue.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", int.MinValue.ToString(), int.MaxValue.ToString()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", uint.MinValue.ToString(), uint.MaxValue.ToString()));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", long.MinValue.ToString(), long.MaxValue.ToString()));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("From {0} to {1}", ulong.MinValue.ToString(), ulong.MaxValue.ToString()));
        }

    }
}
