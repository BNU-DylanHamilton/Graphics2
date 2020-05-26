using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Graphics2
{
    public partial class Form1 : Form
    {

        const int MAX = 6; //number of rectangles drawn

        public Form1()
        {
            InitializeComponent();
        }

        private void loadForm(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        /// <summary>
        /// This method draws the rectangle at the given position and then 
        /// loops a few times with each rectangle getting smaller within 
        /// the original rectangle
        /// </summary>
        private void drawRectangle(object sender, PaintEventArgs e)
        {
            int x = 80,  y = 10;     // position of rectangle
            int w = 300, h = 200;    // width and height of reactangle
            Graphics g = e.Graphics; // get a graphics object

            Pen myPen = new Pen(Color.Blue, 10);  // define a blue pen size 10
 
            for(int i = 0; i < MAX; i++)
            {
                g.DrawRectangle(myPen, x, y, w, h);         // draw a rectangle using pen
                g.FillRectangle(Brushes.Red, x, y, w, h);   // fill the rectangle with a red brush colour

                x += 15;
                y += 15;
                w -= 30;
                h -= 30;
            }
            
            
            //g.DrawEllipse(myPen, x, y, w, h);
            //g.FillEllipse(Brushes.Yellow, x, y, w, h);
        }
    }
}