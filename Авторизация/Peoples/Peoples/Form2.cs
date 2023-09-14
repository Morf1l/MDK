using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peoples
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if((textBox1.Text=="admin1") &&(textBox2.Text=="123") || (textBox1.Text=="admin2") && (textBox2.Text == "321"))
            {
                Form1 newForm = new Form1();
                newForm.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
