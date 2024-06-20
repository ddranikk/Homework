using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }
        public MyCollection<object> GetCollection()
        {
           
            return new MyCollection<object>(); 
        }

        int index = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            GetCollection().Add(textBox1.Text);
            index++;
            GetCollection().Get(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(GetCollection());
        }
        int index1 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            index1 = Convert.ToInt32(textBox2.Text);
            GetCollection().Remove(index, index1);
        }
    }
}
