using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Maze : Form
    {
        private int i = 0;
        
        
        //Ball Height
        private int _ballHeight = 15;
        //Ball Width
        private int _ballWidth = 15;
        
        //Ball Position
        private int _ballX=385;
        private int _ballY=375;

        //Ball Velocity

        private int _ballVX=0;
        private int _ballVY=0;

        public Stopwatch Watch { get; set; }
        
        public Maze()
        {
            InitializeComponent();



            Watch = new Stopwatch();
            Watch.Start();
        }

        private void Entry1BTN_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Refresh();
            ClickTMR.Start();
            ClickTMR.Interval = 200;
            
            Watch.Stop();
            TimerLBL.Text = Watch.Elapsed.TotalSeconds.ToString();

            var _finalBallX = _ballX;
            var _finalBallY = _ballY;


            _ballX = 64;
            _ballY = 65;

            _ballVX = 5;
            _ballVY = 5;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        private void Entry2BTN_Click(object sender, EventArgs e)
        {

        }

        private void Entry3BTN_Click(object sender, EventArgs e)
        {

        }

        private void Entry4BTN_Click(object sender, EventArgs e)
        {

        }

        private void Maze_Load(object sender, EventArgs e)
        {


        }

        private void ClickTMR_Tick(object sender, EventArgs e)
        {
            string minutes = Watch.Elapsed.Minutes.ToString();
            string seconds = Watch.Elapsed.Seconds.ToString();
            TimerLBL.Text = minutes+":"+seconds;

            
            MoveBall1(++i);
        }

        private void MoveBall1(int step)
        {
            #region Steps for Moving the Ball to Center

            if (step <= 11)
            {
                MoveYBall();
            }
            else if (step>=12 && step <=17)
            {
                MoveXBall();
            }
            else if (step>=18 && step <= 28)
            {
                MoveYBall();
            }
            else if (step >= 29 && step <= 34)
            {
                MoveXBall();
            }
            else if (step >= 35 && step <= 45)
            {
                MoveInverseYBall();
            }
            else if (step >= 46 && step <= 51)
            {
                MoveXBall();
            }
            else if (step >= 52 && step <= 67)
            {
                MoveYBall();
            }
            else if (step >= 68 && step <= 85)
            {
                MoveInverseXBall();
            }
            else if (step >= 86 && step <= 91)
            {
                MoveYBall();
            }
            else if (step >= 92 && step <= 97)
            {
                MoveXBall();
            }
            else if (step >= 98 && step <= 103)
            {
                MoveYBall();
            }
            else if (step >= 104 && step <= 109)
            {
                MoveInverseXBall();
            }
            else if (step >= 110 && step <= 137)
            {
                MoveYBall();
            }
            else if (step >= 138 && step <= 149)
            {
                MoveXBall();
            }
            else if (step >= 150 && step <= 166)
            {
                MoveInverseYBall();
            }
            else if (step >= 167 && step <= 172)
            {
                MoveXBall();
            }
            else if (step >= 173 && step <= 184)
            {
                MoveYBall();
            }
            else if (step >= 185 && step <= 195)
            {
                MoveXBall();
            }
            else if (step >= 196 && step <= 206)
            {
                MoveYBall();
            }
            else if (step >= 207 && step <= 212)
            {
                MoveXBall();
            }
            else if (step >= 213 && step <= 235)
            {
                MoveInverseYBall();
            }
            else if (step >= 236 && step <= 246)
            {
                MoveInverseXBall();
            }
            else if (step >= 247 && step <= 251)
            {
                MoveInverseYBall();
            }
            else if (step >= 252 && step <= 268)
            {
                MoveXBall();
            }
            else if (step >= 269 && step <= 279)
            {
                MoveYBall();
            }
            else if (step >= 279 && step <= 285)
            {
                MoveXBall();
            }
            else if (step >= 286 && step <= 296)
            {
                MoveInverseYBall();
            }
            else if (step >= 297 && step <= 313)
            {
                MoveXBall();
            }
            else if (step >= 314 && step <= 323)
            {
                if (step==323)
                {
                    _ballHeight =120;
                    _ballWidth =120;
                    _ballX = _ballX-53;
                    _ballY = _ballY-23;
                }
                MoveYBall();
            }

            #endregion
        }

        private void MoveXBall()
        {
            _ballX += _ballVX;
            if (_ballX < 0)
            {
                _ballVX = -_ballVX;
            }
            else if (_ballX + _ballWidth > MazePBX.Width)
            {
                _ballVX = -_ballVX;
            }
            Refresh();
        }

        private void MoveYBall()
        {
            _ballY += _ballVY;
            if (_ballY < 0)
            {
                _ballVX = -_ballVY;
            }
            else if (_ballY + _ballHeight > MazePBX.Height)
            {
                _ballVY = -_ballVY;
            }

            Refresh();
        }


        private void MoveInverseXBall()
        {
            _ballX -= _ballVX;
            if (_ballX < 0)
            {
                _ballVX = -_ballVX;
            }
            else if (_ballX + _ballWidth > MazePBX.Width)
            {
                _ballVX = -_ballVX;
            }
            Refresh();
        }

        private void MoveInverseYBall()
        {
            _ballY -= _ballVY;
            if (_ballY < 0)
            {
                _ballVX = -_ballVY;
            }
            else if (_ballY + _ballHeight > MazePBX.Height)
            {
                _ballVY = -_ballVY;
            }

            Refresh();
        }

        private void Maze_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Blue, _ballX, _ballY,
                _ballWidth, _ballHeight);
            e.Graphics.DrawEllipse(Pens.Black, _ballX, _ballY,
                _ballWidth, _ballHeight);
        }
    }
}
