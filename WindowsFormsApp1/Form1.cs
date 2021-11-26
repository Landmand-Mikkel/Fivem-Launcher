using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Landmand_Mikkel : Form
    {
        public Landmand_Mikkel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) => Process.Start($"fivem://connect/157.90.254.170:30120"); // Sæt jeres ip ind

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/HubEmSJNTW"); // Sæt jeres discord link ind

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/HubEmSJNTW"); // Sæt jeres discord link ind


            this.Close();
        }
    }
}