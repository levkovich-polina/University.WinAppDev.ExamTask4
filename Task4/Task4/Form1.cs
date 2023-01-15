using System.Diagnostics;
using Timer = System.Threading.Timer;

namespace Task4
{
    public partial class Form1 : Form
    {
        List<Point> list = new List<Point>();
        List<Point> Position = new List<Point>();
        bool button = false;
        Pen color;
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            list.Add(new Point(e.X, e.Y));
            if (Panel.Capture)
            {
                stopWatch.Start();
                Position.Add(new Point(e.X, e.Y));
                Graphics g = Panel.CreateGraphics();
                g.DrawLine(color, list[list.Count - 2], list[list.Count - 1]);
            }
            else
            {
                stopWatch.Stop();
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel.Capture = false;
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel.Capture = true;
                Random r = new Random();
                Pen pen = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255)), 10);
                color = pen;
            }
        }
        private Timer _timer;
        private void ReproduceButton_Click(object sender, EventArgs e)
        {
            if (Panel.Capture == false)
            {
                ReproduceButton.Enabled = true;
                button = true;
            }
            else
            {
                ReproduceButton.Enabled = false;
            }

            if (button == true)
            {
                Panel.Invalidate();
                int num = 0;
                // устанавливаем метод обратного вызова
                TimerCallback tm = new TimerCallback(Draw);
                _timer = new Timer(tm, num, 0, 2000);
            }
        }
       
        private int _drawingLineCounter = 0;
        public void Draw(object obj)
        {
            Graphics g = Panel.CreateGraphics();
            g.DrawLine(new Pen(Color.Black), list[_drawingLineCounter], list[_drawingLineCounter + 1]);
            _drawingLineCounter++;
            _timer.Dispose();
        }
    }
}