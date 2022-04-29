using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        private readonly Timer timer;
        private readonly Image ufo;
        private readonly Image rocket;
        private readonly Image rocketShot;
        private readonly Image ufoShot;
        private readonly Image firstAsteroid;
        private readonly Image secondAsteroid;
        private readonly Image background;
        private readonly Image image;
        private readonly Size space = new Size(1280, 960);
        
        private readonly string text;

        private bool left;
        private bool right;
        private bool forward;
        
        public GameForm()
        {
            timer = new Timer();
            ufo = Image.FromFile("images/UFO.png");
            rocket = Image.FromFile("images/rocket.png");
            rocketShot = Image.FromFile("images/rocketShot.png");
            ufoShot = Image.FromFile("images/UfoShot.png");
            firstAsteroid = Image.FromFile("images/asteroid1.png");
            secondAsteroid = Image.FromFile("images/asteroid2.png");
            background = Image.FromFile("images/background.png");
            text = "Rocket";
            image = new Bitmap(space.Width, space.Height, PixelFormat.Format32bppArgb);
            
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DoubleBuffered = true;
            WindowState = FormWindowState.Maximized;
            Text = text;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        public void HandleKey(Keys key, bool move)
        {
            if (key is Keys.A or Keys.Left) left = move;
            if (key is Keys.D or Keys.Right) right = move;
            if (key is Keys.W or Keys.Up) forward = move;
        }
        
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            HandleKey(e.KeyCode, false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Bisque, ClientRectangle);
        }
    }
}