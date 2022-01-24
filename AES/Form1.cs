using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public static string decryptStr;
        public Form1()
        {

            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var str = textBox1.Text;
            var aes = new SimpleAES();
            var encryptStr = aes.EncryptToString(str);
            string s = "Encrypted string: " + encryptStr + "\n";
            textBox2.Text = s;
            decryptStr = aes.DecryptString(encryptStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text = "Decrypted string: " +decryptStr;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
