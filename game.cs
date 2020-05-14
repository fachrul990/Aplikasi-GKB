using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class game : UserControl
    {
        Stack poin = new Stack();
        Stack poincpu = new Stack();
        public game()
        {
            InitializeComponent();
        }

        private int pilcpuu;
        private int winscoree = 0;
        private int tiesscoree = 0;
        private int winscorecpuu = 0;
        private int roundd = 0;


        public void game_Load(object sender, EventArgs e)
        {
            guntingp.Visible = false;
            guntingcpu.Visible = false;
            batup.Visible = false;
            batucpu.Visible = false;
            kertasp.Visible = false;
            kertascpu.Visible = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void gunting_Click(object sender, EventArgs e)
        {
            roundd += 1;
            this.round.Text = roundd.ToString();

            guntingp.Visible = true;
            guntingcpu.Visible = false;
            batup.Visible = false;
            batucpu.Visible = false;
            kertasp.Visible = false;
            kertascpu.Visible = false;


            Random rnd = new Random();
            pilcpuu = rnd.Next(1, 4);


            if (pilcpuu == 1)
            {
                guntingcpu.Visible = true;
                tiesscoree += 1;
                this.tiesscore.Text = tiesscoree.ToString();
                this.result.Text = "DRAW";
            }
            else if (pilcpuu == 2)
            {
                kertascpu.Visible = true;
                winscoree += 1;
                this.winscore.Text = winscoree.ToString();
                this.result.Text = "WIN";
                poin.Push(winscoree);
                Scoregetpoin();
            }
            else if (pilcpuu == 3)
            {
                batucpu.Visible = true;
                winscorecpuu += 1;
                this.winscorecpu.Text = winscorecpuu.ToString();
                this.result.Text = "LOSE";
                poincpu.Push(winscorecpuu);
            }
        }

        public void kertas_Click(object sender, EventArgs e)
        {
            roundd += 1;
            this.round.Text = roundd.ToString();

            guntingp.Visible = false;
            guntingcpu.Visible = false;
            batup.Visible = false;
            batucpu.Visible = false;
            kertasp.Visible = true;
            kertascpu.Visible = false;

            Random rnd = new Random();

            pilcpuu = rnd.Next(1, 4);

            if (pilcpuu == 1)
            {
                guntingcpu.Visible = true;
                winscorecpuu += 1;
                this.winscorecpu.Text = winscorecpuu.ToString();
                this.result.Text = "LOSE";
                poincpu.Push(winscorecpuu);
            }
            else if (pilcpuu == 2)
            {
                kertascpu.Visible = true;
                tiesscoree += 1;
                this.tiesscore.Text = tiesscoree.ToString();
                this.result.Text = "DRAW";
            }
            else if (pilcpuu == 3)
            {
                batucpu.Visible = true;
                winscoree += 1;
                this.winscore.Text = winscoree.ToString();
                this.result.Text = "WIN";
                poin.Push(winscoree);
                Scoregetpoin();
            }
        }

        public void batu_Click(object sender, EventArgs e)
        {
            roundd += 1;
            this.round.Text = roundd.ToString();

            guntingp.Visible = false;
            guntingcpu.Visible = false;
            batup.Visible = true;
            batucpu.Visible = false;
            kertasp.Visible = false;
            kertascpu.Visible = false;

            Random rnd = new Random();

            pilcpuu = rnd.Next(1, 4);

            if (pilcpuu == 1)
            {
                guntingcpu.Visible = true;
                winscoree += 1;
                this.winscore.Text = winscoree.ToString();
                this.result.Text = "WIN";
                poin.Push(winscoree);
                Scoregetpoin();
            }
            else if (pilcpuu == 2)
            {
                kertascpu.Visible = true;
                winscorecpuu += 1;
                this.winscorecpu.Text = winscorecpuu.ToString();
                this.result.Text = "LOSE";
                poincpu.Push(winscorecpuu);
            }
            else if (pilcpuu == 3)
            {
                batucpu.Visible = true;
                tiesscoree += 1;
                this.tiesscore.Text = tiesscoree.ToString();
                this.result.Text = "DRAW";
            }


        }
        public void Scoregetpoin()
        {
            int a = winscoree;

            if (a % 5 == 0 && a != 0)
            {
                this.textBox1.Text += (poin.Peek().ToString() +" VS " + poincpu.Peek().ToString() + " Dalam " + roundd + " kali permainan" + "\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.result.Text = "0";
            this.winscore.Text = "0";
            this.winscorecpu.Text = "0";
            this.tiesscore.Text = "-";
            this.round.Text = "0";
            winscoree = 0;
            winscorecpuu = 0;
            tiesscoree = 0;
            roundd = 0;
            game_Load(sender,e);
        }
    }
}
 
