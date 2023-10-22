using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Characterform : Form
    {
        public Characterform()
        {
            InitializeComponent();
        }

        private void character1_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.Image = Image.FromFile(@"""C:\Users\AISWARYA POOSARLA\OneDrive\Pictures\Saved Pictures\Character-1.jfif""");
            (this.Owner as Pong).timer.Start();
            this.Hide();

        }

        private void character2_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.Image = Image.FromFile(@"""C:\Users\AISWARYA POOSARLA\OneDrive\Pictures\Saved Pictures\Character-2.jfif""");
            (this.Owner as Pong).timer.Start();
            this.Hide();
        }

        private void character3_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.Image = Image.FromFile(@"""C:\Users\AISWARYA POOSARLA\OneDrive\Pictures\Saved Pictures\Character-3.jpg""");
            (this.Owner as Pong).timer.Start();
            this.Hide();
        }

        private void charater4_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.Image = Image.FromFile(@"""C:\Users\AISWARYA POOSARLA\OneDrive\Pictures\Saved Pictures\Character-4.webp""");
            (this.Owner as Pong).timer.Start();
            this.Hide();
        }
    }
}
