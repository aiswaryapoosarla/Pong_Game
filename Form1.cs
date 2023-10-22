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
    public partial class Pong : Form
    {
        //Location variables
        int cpudirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;
        //Score variables
        int playerscore = 0;
        int cpuscore = 0;
        //size variables
        int bottomboundary;
        int centerpoint;
        int xmidpoint;
        int ymidpoint;
        //Detection variables
        bool playerdetectedup;
        bool playerdetecteddown;    
        //special keys
        int spacebarclicked = 0;
        public Pong()
        {
            InitializeComponent();
            bottomboundary = ClientSize.Height - player1.Height;
            xmidpoint = ClientSize.Width/2;
            ymidpoint = ClientSize.Height/2;
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Adjust where the ball is
            pongball.Top -= ballYCoordinate;
            pongball.Left -= ballXCoordinate;
            // Make the CPU move
            cpuplayer.Top += cpudirection;

            // Make CPU better at the game, the higher the playerScore
            if (playerscore > 5)
            {
                cpuplayer.Top = pongball.Top + 30;
            }

            // Check if CPU has reached the top or the bottom
            if (cpuplayer.Top < 0 || cpuplayer.Top > bottomboundary) { cpudirection = -cpudirection; }
            // Check if the ball has exited the left side of the screen
            if (pongball.Left < 0)
            {
                pongball.Left = xmidpoint;
                pongball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                if (playerscore < 5) { ballXCoordinate -= 1; }
                cpuscore++;
                cpuscorelabel.Text = cpuscore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (pongball.Left + pongball.Width > ClientSize.Width)
            {
                pongball.Left = xmidpoint;
                pongball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                if (playerscore < 5) { ballXCoordinate += 1; }
                playerscore++;
                Playerscorelabel.Text = playerscore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (pongball.Top < 0 || pongball.Top + pongball.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }

            // Check if the ball hits the player or CPU paddle
            if (pongball.Bounds.IntersectsWith(player1.Bounds) || pongball.Bounds.IntersectsWith(cpuplayer.Bounds))
            {
                // Generate a random color for player
                Random rand = new Random();
                int max = byte.MaxValue + 1;
                int r = rand.Next(max);
                int g = rand.Next(max);
                int b = rand.Next(max);
                Color c = Color.FromArgb(r, g, b);

                // Generate a random color for CPU
                int r1 = rand.Next(max);
                int g1 = rand.Next(max);
                int b1 = rand.Next(max);
                Color c2 = Color.FromArgb(r1, g1, b1);

                // Change the color of the paddle
                player1.BackColor = c;
                cpuplayer.BackColor = c2;
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move player up
            if (playerdetectedup == true && player1.Top > 0) { player1.Top -= 10; }
            // Move player down
            if (playerdetecteddown == true && player1.Top < bottomboundary) { player1.Top += 10; }
            // Check for winner
            if (playerscore >= 10) { timer.Stop(); }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerdetectedup = false; }
            if (e.KeyCode == Keys.Down) { playerdetecteddown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) { playerdetectedup = true; }
            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.Down) { playerdetecteddown = true; }
            // If player presses the C key, open the character selection screen
            if (e.KeyCode == Keys.C)
            {
                Form character = new Characterform();
                character.Owner = this;
                timer.Stop();
                character.Show();
            }

            // If player presses space bar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spacebarclicked % 2 == 0)
                {
                    timer.Stop();
                }
                else
                {
                    timer.Start();
                }
            }
            spacebarclicked++;
        }

        
    }
}
