using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace pog
{
    public partial class Football : Form
    {
        Pen turnPen = new Pen(Color.White);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        int boot1X = 15;
        int boot1Y = 100;
        int player1Score = 0;

        int boot2X = 530;
        int boot2Y = 100;
        int player2Score = 0;

        int bootWidth = 40;
        int bootHeight = 40;
        int bootSpeed = 6;

        int ballX = 295;
        int ballY = 195;
        int ballXSpeed = 8;
        int ballYSpeed = 8;
        int ballWidth = 20;
        int ballHeight = 20;
        Image ballImage;
        SoundPlayer player2;
        SoundPlayer player;
        SoundPlayer player3;
        SoundPlayer player4;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool aDown = false;
        bool dDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool firstHit = true;

        new Pen bluePen = new Pen(Color.DodgerBlue);
        new Pen redPen = new Pen(Color.Red);
        new Pen whitePen = new Pen(Color.White, 7);
        Font screenFont = new Font("Consolas", 12);
        public Football()
        {

            InitializeComponent();
            ballstart();
            ballImage = Properties.Resources.football;
            player2 = new SoundPlayer(Properties.Resources.crowd1);
            player = new SoundPlayer(Properties.Resources.goal1);
            player3 = new SoundPlayer(Properties.Resources.whistle);
            player4 = new SoundPlayer(Properties.Resources.finalblow);
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            player3.Play();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw center circle
            e.Graphics.DrawEllipse(whitePen, 216, this.Height / 2 - 75, 150, 150);
            e.Graphics.DrawLine(whitePen, 292, 0, 292, 361);
            //Draw top line
            e.Graphics.DrawLine(whitePen, 0, 1, 584, 1);
            //Draw bottom line
            e.Graphics.DrawLine(whitePen, 0, 360, 584, 360);
            //Goal 1 top and bottom lines
            e.Graphics.DrawLine(whitePen, 1, 0, 1, 135);
            e.Graphics.DrawLine(whitePen, 0, 240, 0, 365);
            //Goal 2 top and bottom lines
            e.Graphics.DrawLine(whitePen, 583, 0, 583, 135);
            e.Graphics.DrawLine(whitePen, 583, 240, 583, 390);
            //Draw Ball
            e.Graphics.DrawImage(ballImage, ballX, ballY, ballHeight, ballWidth);
            //Player 1
            e.Graphics.DrawEllipse(bluePen, boot1X, boot1Y, 40, 40);
            e.Graphics.FillEllipse(drawBrush, boot1X, boot1Y, 40, 40);
            drawBrush.Color = Color.Red;
            //Player 2
            e.Graphics.DrawEllipse(redPen, boot2X, boot2Y, 40, 40);
            e.Graphics.FillEllipse(drawBrush, boot2X, boot2Y, 40, 40);
            drawBrush.Color = Color.Blue;
            //e.Graphics.DrawRectangle(redPen, 0, 136, 1, 104);
            // e.Graphics.DrawRectangle(redPen, 584, 136, 1, 104);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Save current ball location
            int x = ballX;
            int y = ballY;

            //move ball 
            ballX += ballXSpeed;
            ballY += ballYSpeed;

            //move player 1 
            if (wDown == true && boot1Y > 0)
            {
                boot1Y -= bootSpeed;
            }
            if (aDown == true && boot1X > 0)
            {
                boot1X -= bootSpeed;
            }
            if (dDown == true && boot1X < this.Width / 2 - bootWidth)
            {
                boot1X += bootSpeed;
            }
            if (sDown == true && boot1Y < this.Height - bootHeight)
            {
                boot1Y += bootSpeed;
            }

            //move player 2 
            if (upArrowDown == true && boot2Y > 0)
            {
                boot2Y -= bootSpeed;
            }

            if (downArrowDown == true && boot2Y < this.Height - bootHeight)
            {
                boot2Y += bootSpeed;
            }
            if (leftArrowDown == true && boot2X > this.Width / 2)
            {
                boot2X -= bootSpeed;
            }
            if (rightArrowDown == true && boot2X < this.Width - bootWidth)
            {
                boot2X += bootSpeed;
            }

            //check if ball hit top or bottom wall and change direction if it does 
            if (ballY < 0 || ballY > this.Height - ballHeight)
            {
                ballYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }

            //create Rectangles of objects on screen to be used for collision detection 
            Rectangle player1Rec = new Rectangle(boot1X, boot1Y, 40, 40);
            Rectangle player2Rec = new Rectangle(boot2X, boot2Y, 40, 40);
            Rectangle ballRec = new Rectangle(ballX, ballY, ballHeight, ballWidth);
            Rectangle goal1Rec = new Rectangle(0, 136, 1, 104);
            Rectangle goal2Rec = new Rectangle(584, 136, 1, 100);

            //check if ball hits either boot. If it does change the direction 
            //and place the ball in front of the boot hit. If it hits eiher net score a point and set ball in middle
            if (player1Rec.IntersectsWith(ballRec) && ballX > boot1X)
            {
                ballXSpeed *= -1;
                //ballX = boot1X + bootWidth;
                ballX = x;
                ballY = y;
                if (ballXSpeed == 0)
                {
                    ballmove();
                }
            }
            else if (player1Rec.IntersectsWith(ballRec) && ballX < boot1X)
            {
                ballXSpeed *= -1;
                ballX = x;
                ballY = y;
                if (ballXSpeed == 0)
                {
                    ballmove();
                }
                //ballX = boot1X - bootWidth;
            }
            if (player2Rec.IntersectsWith(ballRec) && ballX > boot2X)
            {
                ballXSpeed *= -1;
                ballX = x;
                ballY = y;
                if (ballXSpeed == 0)
                {
                    ballmove();
                }
                //ballX = boot2X + bootWidth;
            }
            else if (player2Rec.IntersectsWith(ballRec) && ballX < boot2X)
            {
                ballXSpeed *= -1;
                ballX = x;
                ballY = y;
                if (ballXSpeed == 0)
                {
                    ballmove();
                }
                //ballX = boot2X - bootWidth;
            }
            if (goal1Rec.IntersectsWith(ballRec))
            {
                ballstart();
               player2Score++;
                p2ScoreLabel.Text = $"{player2Score}";
                
                player.Play();
                goalBox.Visible = true;
            }
            if (goal2Rec.IntersectsWith(ballRec))
            {
                ballstart();
                player1Score++;
                p1ScoreLabel.Text = $"{player1Score}";
                goalBox.Visible = true;
                
                player.Play();
                goalBox.Visible = true;
            }

            //rebound balls of sider walls

            if (ballX < 2)
            {
                ballXSpeed *= -1;

            }
            if (ballX > 577)
            {
                ballXSpeed *= -1;
            }
            //check score and stop game if either player is at 3 
             if (player1Score == 3 || player2Score == 3)
            {
                gameTimer.Enabled = false;               
                if (player1Score > player2Score)
                { 
                    winnerLabel.Text = $"WINNER!";
                    winnerLabel2.Text = $"PLAYER 1";                    
                    player4.Play();
                    goalBox.Visible = false;
                }
                else
                {
                    winnerLabel.Text = $"WINNER!";
                    winnerLabel2.Text = $"PLAYER 2";                 
                    player4.Play();
                    goalBox.Visible = false;
                }
            }


            Refresh();
        }

        public void ballstart()
        {
            ballXSpeed = 0;
            ballYSpeed = 0;
            ballX = this.Width / 2 - 5;
            ballY = this.Height / 2 - 5;
            boot1X = this.Width / 2 - 150;
            boot2X = this.Width / 2 + 110;
            boot1Y = this.Height / 2;
            boot2Y = this.Height / 2;
                     
        }
        public void ballmove()
        {
            ballXSpeed = 8;
            ballYSpeed = 8;
            goalBox.Visible = false;          
            player2.Play();
        }
       
    }
}
