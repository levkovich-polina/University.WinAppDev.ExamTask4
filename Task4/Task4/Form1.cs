using System.Diagnostics;

namespace Task4
{
    public partial class Form1 : Form
    {
        List<Point> list = new List<Point>();
        List<Point> Position = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            Random r = new Random();
            Pen pen = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255)), 10);
            list.Add(new Point(e.X, e.Y));
            if (Panel.Capture)
            {
                stopWatch.Start();
                Position.Add(new Point(e.X, e.Y));
                Graphics g = Panel.CreateGraphics();
                g.DrawLines(pen, list.ToArray());
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
               
            }
        }

        bool button = false;

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
                Panel.Controls.Clear();
                Pen pen = new Pen(Color.Black, 10);
                Graphics g = Panel.CreateGraphics();
                g.DrawLines(pen, Position.ToArray());

            }
        }
    }
}