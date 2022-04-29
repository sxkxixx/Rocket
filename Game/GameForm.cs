using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        private readonly Image Rocket;
        private readonly Image Ufo;
        private readonly Image Shot;
        private readonly Image Asteroid;
        private readonly Image Background;
        private readonly Image chest;
        public readonly Size spaceSize = new Size(1280, 960);
        
        public readonly Timer timer;

        public GameForm()
        {
            Rocket = Image.FromFile("images/rocket.png");
            Ufo = Image.FromFile("images/UFO.png");
            Shot = Image.FromFile("image/shot.png");
            Asteroid = Image.FromFile("image/asteroid.png");
            Background = Image.FromFile("image/background.png");
            chest = Image.FromFile("images/chest.png");
        }

        private void TimerTick(object sender, EventArgs e)
        {		
            MoveRocket();
            MoveOpponent();
            Invalidate();
            Update();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DoubleBuffered = true;
            WindowState = FormWindowState.Maximized;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void MoveRocket()
        {
            
        }

        private void MoveOpponent()
        {
            
        }
    }
}