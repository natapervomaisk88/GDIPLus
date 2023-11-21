namespace GDIPLus
{
    public partial class Form1 : Form
    {
        bool _IsClicked = false;
        int _X1 = 0, _Y1 = 0, _X2 = 0, _Y2 = 0;
        public Form1()
        {
            InitializeComponent();
            tabPage2.Paint += TabPage2_Paint;
            tabPage3.Paint += TabPage3_Paint;
            tabPage4.Paint += TabPage4_Paint;
            tabPage5.Paint += TabPage5_Paint;
        }

        private void TabPage5_Paint(object? sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Aqua, 3);
            Graphics gr = e.Graphics;
            gr.DrawLine(pen, new Point(_X1,_Y1), new Point(_X2,_Y2));
        }

        private void TabPage4_Paint(object? sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Tomato, 3);
            Graphics gr = e.Graphics;
            gr.DrawEllipse(pen, 100, 100, 150, 150);

            Brush brush = Brushes.Violet;
            gr.FillEllipse(brush, 200, 200, 50, 50);
        }

        private void TabPage3_Paint(object? sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Brush brush = Brushes.Yellow;
            gr.FillRectangle(brush, 50, 50, 70, 70);
        }

        private void TabPage2_Paint(object? sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 10);
            Graphics gr = e.Graphics;
            gr.DrawRectangle(pen, 100, 170, 150, 150);
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Graphics gr = e.Graphics;
            Point p1 = new Point(50, 50);
            Point p2 = new Point(150, 150);
            gr.DrawLine(pen, p1, p2);

        }

        private void tabPage5_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            _X1 = e.X;
            _Y1 = e.Y;
        }

        private void tabPage5_MouseUp(object sender, MouseEventArgs e)
        {
            _IsClicked = false;
        }

        private void tabPage5_MouseMove(object sender, MouseEventArgs e)
        {
            if(_IsClicked ) 
            {
                _X2 = e.X;
                _Y2 = e.Y;
                tabPage5.Invalidate();
            }
        }
    }
}