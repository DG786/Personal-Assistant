using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hh_TextChanged(object sender, EventArgs e)
        {

        }

        private void Set_Click(object sender, EventArgs e)
        {
            if (hh.Text.Length == 1) {
                hh.Text = 0 + hh.Text;
            }
            this.Hide();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\songs\1.wav";
            string c = null;
            c += (string)hh.Text;
            c += ":";
            c += (string)mm.Text;
            c += " ";
            c += (string)tt.Text;
            
            //Console.WriteLine("{0} left", Convert.ToInt32(c) - Convert.ToInt32(b));
            while (true)
            {
                DateTime a = DateTime.Now;
                string b = (a.ToString("hh:mm tt"));
                if (c == b)
                {
                    player.Play();
                    break;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
