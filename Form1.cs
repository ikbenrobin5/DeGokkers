using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkeres1
{
    public partial class Form1 : Form

       
    {
        

       

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {

           
            int baan = 930;
            Random rnd = new Random();
            int speed = rnd.Next(1, 5);
            int speed1 = rnd.Next(1, 5);
            int speed2 = rnd.Next(1, 5);
            int speed3 = rnd.Next(1, 5);

            do
            {
                speed = rnd.Next(1, 5);
                speed1 = rnd.Next(1, 5);
                speed2 = rnd.Next(1, 5);
                speed3 = rnd.Next(1, 5);

            } while (speed == speed1 || speed == speed1 || speed == speed2 || speed == speed3 || speed1 == speed2 || speed1 == speed3 || speed2 == speed3);

            //if (speed == speed1 || speed == speed1 || speed == speed2 ||speed == speed3  )
            //{
            //     speed = rnd.Next(2, 7);
            //     speed1 = rnd.Next(2, 7);
            //     speed2 = rnd.Next(2, 7);
            //     speed3 = rnd.Next(2, 7);


            //}

            //else if ( speed1 == speed2 || speed1 == speed3 )
            //{
                 
            //     speed1 = rnd.Next(2, 7);
            //     speed2 = rnd.Next(2, 7);
            //     speed3 = rnd.Next(2, 7);

            //}
            //else if (speed2 == speed3 )
            //{
                 
            //     speed2 = rnd.Next(2, 7);
            //     speed3 = rnd.Next(2, 7);

            //}
            //else
            //{

            //}


            do
            {
                Struisvogel1.Location = new Point(Struisvogel1.Location.X + speed, Struisvogel1.Location.Y);
                Struisvogel2.Location = new Point(Struisvogel2.Location.X + speed1 , Struisvogel2.Location.Y);
                Struisvogel3.Location = new Point(Struisvogel3.Location.X + speed2, Struisvogel3.Location.Y);
                Struisvogel4.Location = new Point(Struisvogel4.Location.X +speed3, Struisvogel4.Location.Y);
            } while ((Struisvogel1.Location.X <= baan) && (Struisvogel2.Location.X <= baan) && (Struisvogel3.Location.X <= baan) && (Struisvogel4.Location.X <= baan));
            
        }

        private void Go_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Struisvogel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
