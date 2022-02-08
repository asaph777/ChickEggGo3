using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickEggGo3
{
    public partial class Form1 : Form
    {
        Server empSer = new Server();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var countChickens = int.Parse(textBox1.Text);
            var countEggs = int.Parse(textBox2.Text);
            var drinks = comboBox1.SelectedItem.ToString();

            if (Server.counReqs >= 8)
            {
                button1.Enabled = false;
                MessageBox.Show("test");
                return;
            }
            empSer.Recieve(countChickens, countEggs, drinks);
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            empSer.Send();
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (var item in empSer.Serve())
            {
                listBox1.Items.Add(item);
            }
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
