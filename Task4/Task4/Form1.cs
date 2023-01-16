using System.Diagnostics;
using Timer = System.Threading.Timer;

namespace Task4
{
    public partial class Form1 : Form
    {
        List<Point> list = new List<Point>();
        bool button = false;
        Pen color;
        Pen reproductionColor;
        public Form1()
        {
            InitializeComponent();
            SpeedTextBox.Text = "100";

        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();

            if (Panel.Capture)
            {
                list.Add(new Point(e.X, e.Y));
                if (list.Count >= 2)
                {
                    Graphics g = Panel.CreateGraphics();
                    g.DrawLine(color, list[list.Count - 2], list[list.Count - 1]);
                }
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
                reproductionColor = color;
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

                double speed = Convert.ToDouble(SpeedTextBox.Text);

                double difference = speed / 100.0;
                int reproduction = (int)(20 / difference);

                TimerCallback tm = new TimerCallback(Draw);
                _timer = new Timer(tm, num, 0, reproduction);
            }
        }

        private int _drawingLineCounter = 0;
        public void Draw(object obj)
        {
            Graphics g = Panel.CreateGraphics();
            g.DrawLine(reproductionColor, list[_drawingLineCounter], list[_drawingLineCounter + 1]);
            if (list.Count - 2 == _drawingLineCounter)
            {
                _timer.Dispose();
                _drawingLineCounter = 0;
            }
            _drawingLineCounter++;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                reproductionColor = new Pen(colorDialog.Color, 10);
                ColorButton.BackColor = colorDialog.Color;
            }
        }
    }
}
