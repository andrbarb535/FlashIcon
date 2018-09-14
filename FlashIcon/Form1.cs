using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashIcon
{
    public partial class Flash : Form
    {
        public Flash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 1);
            //number following color determines thickness in pixel
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("ComicSansMS", 20, FontStyle.Bold);

            g.Clear(Color.White);

            g.DrawLine(drawPen, 100, 40, 100, 200);
            //x, y, x, y

            g.DrawRectangle(drawPen, 200, 40, 100, 100);
            //start point x, start point y, length, width
            g.FillRectangle(drawBrush, 200, 40, 50, 100);
            //fill colour

            g.DrawEllipse(drawPen, 300, 300, 100, 100);
            g.FillEllipse(drawBrush, 300, 300, 100, 100);

            g.DrawArc(drawPen, 200, 200, 100, 100, 30, 300);

            g.DrawPie(drawPen, 500, 150, 100, 100, 30, 300);
            g.FillPie(drawBrush, 500, 150, 100, 100, 30, 300);

            g.DrawString("According to all known laws of aviation...", drawFont, drawBrush, 300, 40);
            */

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Imprint MT Shadow", 42, FontStyle.Bold);
            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow);

            g.DrawEllipse(drawPen, 250, 125, 300, 300);
            g.FillEllipse(drawBrush, 250, 125, 300, 300);
            //white circle

            //   g.DrawLine(drawPen, 350, 250, 500, 30);
            //diagonal top left
            //    g.DrawLine(drawPen, 500, 30, 430, 200);
            //diagonal top right
            //   g.DrawLine(drawPen, 430, 200, 485, 200);
            //horizontal top right
            //   g.DrawLine(drawPen, 350, 250, 400, 250);
            //horizontal top left
            //   g.DrawLine(drawPen, 400, 250, 325, 370);
            //diagonal middle left
            //   g.DrawLine(drawPen, 485, 200, 410, 325);
            //diagonal middle right
            //   g.DrawLine(drawPen, 410, 325, 460, 325);
            //horizontal bottom right
            //   g.DrawLine(drawPen, 325, 370, 375, 370);
            //horizontal bottom left
            //   g.DrawLine(drawPen, 375, 370, 300, 520);
            //vertical bottom left
            //   g.DrawLine(drawPen, 460, 325, 300, 520);
            //vertical bottom right

            Point[] lightningBolt = new Point[10];
            lightningBolt[0] = new Point(350, 250);
            lightningBolt[1] = new Point(500, 30);
            lightningBolt[2] = new Point(430, 200);
            lightningBolt[3] = new Point(485, 200);
            lightningBolt[4] = new Point(410, 325);
            lightningBolt[5] = new Point(460, 325);
            lightningBolt[6] = new Point(300, 520);
            lightningBolt[7] = new Point(375, 370);
            lightningBolt[8] = new Point(325, 370);
            lightningBolt[9] = new Point(400, 250);

            //Point[] lightningBolt = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10};

            g.DrawPolygon(drawPen, lightningBolt);
            g.FillPolygon(drawBrush2, lightningBolt);

            //yellow lightning bolt

            g.TranslateTransform(175, 400);
            g.RotateTransform(-90);
            g.DrawString("BAZINGA!", drawFont, drawBrush3, new Rectangle());

            g.ResetTransform();
            //bazinga text
        }
    }
}
