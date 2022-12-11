using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Glorious_V2._1
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }
        ExploitAPI module = new ExploitAPI();
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
            module.SendLuaScript(Script);
            
            label1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script1 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt");
            module.SendLuaScript(Script1);

            label1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script2 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Click%20Teleport.txt");
            module.SendLuaScript(Script2);

            label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script3 = wb.DownloadString("https://cdn.wearedevs.net/scripts/BTools.txt");
            module.SendLuaScript(Script3);

            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script4 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Highlight%20Player.txt");
            module.SendLuaScript(Script4);

            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script5 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Invisible%20Character.txt");
            module.SendLuaScript(Script5);

            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script6 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Invisible%20Character.txt");
            module.SendLuaScript(Script6);

            label1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script7 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Teleport%20To%20Player.txt");
            module.SendLuaScript(Script7);

            label1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script8 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Infinite%20Jump.txt");
            module.SendLuaScript(Script8);

            label1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script9 = wb.DownloadString("https://cdn.wearedevs.net/scripts/Ez%20Hub.txt");
            module.SendLuaScript(Script9);

            label1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            label1.Focus();
        }
    }
}
