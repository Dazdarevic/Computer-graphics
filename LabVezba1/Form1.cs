using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabVezba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Gray, 2);

            //crtanje pravougaonika
            Rectangle rect1 = new Rectangle(50, 50, 300, 950);
            g.DrawRectangle(myPen, rect1);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect1,
            Color.Gray, Color.White, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lBrush, rect1);

            Rectangle rect2 = new Rectangle(70, 70, 260, 910);
            LinearGradientBrush lBrush2 = new LinearGradientBrush(rect2,
            Color.White, Color.Gray, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lBrush2, rect2);


            Rectangle rect3 = new Rectangle(175, 150, 40, 750);
            LinearGradientBrush lBrush3 = new LinearGradientBrush(rect3,
            Color.Gray, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(lBrush3, rect3);

            //crtanje kruga
            Pen pn = new Pen(Color.Gray);
            Rectangle rect4 = new Rectangle(155, 840, 80, 80);
            LinearGradientBrush lBrush4 = new LinearGradientBrush(rect4,
            Color.Red, Color.White, LinearGradientMode.Horizontal);
            g.FillEllipse(lBrush4, rect4);
            g.DrawEllipse(pn, rect4);

            //crtanje plavih podeoka na lijevoj strani
            Pen plavaLinija = new Pen(Color.Blue, 3);
            g.DrawLine(plavaLinija, 140, 840, 175, 840);
            g.DrawLine(plavaLinija, 140, 740, 175, 740);
            g.DrawLine(plavaLinija, 140, 640, 175, 640);
            g.DrawLine(plavaLinija, 140, 540, 175, 540);
            g.DrawLine(plavaLinija, 140, 440, 175, 440);
            g.DrawLine(plavaLinija, 140, 340, 175, 340);
            g.DrawLine(plavaLinija, 140, 240, 175, 240);

            //crtanje zelenih podeoka na lijevoj strani
            Pen zelenaLinija = new Pen(Color.Green, 2);
            g.DrawLine(zelenaLinija, 150, 820, 175, 820);
            g.DrawLine(zelenaLinija, 150, 800, 175, 800);
            g.DrawLine(zelenaLinija, 150, 780, 175, 780);
            g.DrawLine(zelenaLinija, 150, 760, 175, 760);

            g.DrawLine(zelenaLinija, 150, 720, 175, 720);
            g.DrawLine(zelenaLinija, 150, 700, 175, 700);
            g.DrawLine(zelenaLinija, 150, 680, 175, 680);
            g.DrawLine(zelenaLinija, 150, 660, 175, 660);

            g.DrawLine(zelenaLinija, 150, 620, 175, 620);
            g.DrawLine(zelenaLinija, 150, 600, 175, 600);
            g.DrawLine(zelenaLinija, 150, 580, 175, 580);
            g.DrawLine(zelenaLinija, 150, 560, 175, 560);

            g.DrawLine(zelenaLinija, 150, 520, 175, 520);
            g.DrawLine(zelenaLinija, 150, 500, 175, 500);
            g.DrawLine(zelenaLinija, 150, 480, 175, 480);
            g.DrawLine(zelenaLinija, 150, 460, 175, 460);

            g.DrawLine(zelenaLinija, 150, 420, 175, 420);
            g.DrawLine(zelenaLinija, 150, 400, 175, 400);
            g.DrawLine(zelenaLinija, 150, 380, 175, 380);
            g.DrawLine(zelenaLinija, 150, 360, 175, 360);

            g.DrawLine(zelenaLinija, 150, 320, 175, 320);
            g.DrawLine(zelenaLinija, 150, 300, 175, 300);
            g.DrawLine(zelenaLinija, 150, 280, 175, 280);
            g.DrawLine(zelenaLinija, 150, 260, 175, 260);

            g.DrawLine(zelenaLinija, 150, 220, 175, 220);
            g.DrawLine(zelenaLinija, 150, 200, 175, 200);
            g.DrawLine(zelenaLinija, 150, 180, 175, 180);
            g.DrawLine(zelenaLinija, 150, 160, 175, 160);

            //crtanje plavih podeoka na desnoj strani
            g.DrawLine(plavaLinija, 215, 820, 250, 820);
            g.DrawLine(plavaLinija, 215, 710, 250, 710);
            g.DrawLine(plavaLinija, 215, 590, 250, 590);
            g.DrawLine(plavaLinija, 215, 470, 250, 470);
            g.DrawLine(plavaLinija, 215, 360, 250, 360);
            g.DrawLine(plavaLinija, 215, 250, 250, 250);

            //crtanje zelenih podeoka na desnoj strani
            g.DrawLine(zelenaLinija, 215, 800, 240, 800);
            g.DrawLine(zelenaLinija, 215, 777, 240, 777);
            g.DrawLine(zelenaLinija, 215, 754, 240, 754);
            g.DrawLine(zelenaLinija, 215, 730, 240, 730);

            g.DrawLine(zelenaLinija, 215, 687, 240, 687);
            g.DrawLine(zelenaLinija, 215, 665, 240, 665);
            g.DrawLine(zelenaLinija, 215, 640, 240, 640);
            g.DrawLine(zelenaLinija, 215, 615, 240, 615);

            g.DrawLine(zelenaLinija, 215, 570, 240, 570);
            g.DrawLine(zelenaLinija, 215, 545, 240, 545);
            g.DrawLine(zelenaLinija, 215, 520, 240, 520);
            g.DrawLine(zelenaLinija, 215, 490, 240, 490);

            g.DrawLine(zelenaLinija, 215, 450, 240, 450);
            g.DrawLine(zelenaLinija, 215, 425, 240, 425);
            g.DrawLine(zelenaLinija, 215, 400, 240, 400);
            g.DrawLine(zelenaLinija, 215, 380, 240, 380);

            g.DrawLine(zelenaLinija, 215, 340, 240, 340);
            g.DrawLine(zelenaLinija, 215, 315, 240, 315);
            g.DrawLine(zelenaLinija, 215, 290, 240, 290);
            g.DrawLine(zelenaLinija, 215, 270, 240, 270);

            g.DrawLine(zelenaLinija, 215, 230, 240, 230);
            g.DrawLine(zelenaLinija, 215, 205, 240, 205);
            g.DrawLine(zelenaLinija, 215, 180, 240, 180);
            g.DrawLine(zelenaLinija, 215, 155, 240, 155);

            //ispisivanje teksta i brojeva
            Font celzijus = new Font("Verdana", 16, FontStyle.Bold);
            g.DrawString("C°", celzijus, new SolidBrush(Color.DarkRed), 80, 900);

            Font farenhajt = new Font("Verdana", 16, FontStyle.Bold);
            g.DrawString("F°", farenhajt, new SolidBrush(Color.DarkRed), 255, 900);

            //stepeni F°
            Font f0 = new Font("Verdana", 10);
            g.DrawString("0°", f0, new SolidBrush(Color.Black), 250, 805);
            Font f20 = new Font("Verdana", 10);
            g.DrawString("20°", f20, new SolidBrush(Color.Black), 250, 690);
            Font f40 = new Font("Verdana", 10);
            g.DrawString("40°", f40, new SolidBrush(Color.Black), 250, 570);
            Font f60 = new Font("Verdana", 10);
            g.DrawString("60°", f60, new SolidBrush(Color.Black), 250, 450);
            Font f80 = new Font("Verdana", 10);
            g.DrawString("80°", f80, new SolidBrush(Color.Black), 250, 350);
            Font f100 = new Font("Verdana", 10);
            g.DrawString("100°", f100, new SolidBrush(Color.Black), 250, 230);

            //stepeni C°
            Font cMin10 = new Font("Verdana", 10);
            g.DrawString("-10°", cMin10, new SolidBrush(Color.Black), 75, 820);
            Font cMin20 = new Font("Verdana", 10);
            g.DrawString("-20°", cMin20, new SolidBrush(Color.Black), 75, 720);
            Font c0 = new Font("Verdana", 10);
            g.DrawString("0°", c0, new SolidBrush(Color.Black), 95, 620);
            Font c10 = new Font("Verdana", 10);
            g.DrawString("10°", c10, new SolidBrush(Color.Black), 75, 530);
            Font c20 = new Font("Verdana", 10);
            g.DrawString("20°", c20, new SolidBrush(Color.Black), 75, 420);
            Font c30 = new Font("Verdana", 10);
            g.DrawString("30°", c30, new SolidBrush(Color.Black), 75, 320);
            Font c40 = new Font("Verdana", 10);
            g.DrawString("40°", c40, new SolidBrush(Color.Black), 75, 220);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
