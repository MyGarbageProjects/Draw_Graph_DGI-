using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Graph_DGI_.Naima_Shamilievna
{
    public partial class Form1 : Form
    {
        Bitmap canvas;
        Graphics graph;
        Matrix back;

        float thicknesAxes = 1.9f;
        float thicknesFigure = 2f;
        int sizeTail;

        Point[] figure_coords = new Point[]
        {
            ////Kh
            new Point(0,-0),
            new Point(30,-50),
            new Point(80,-50),
            new Point(110,-0),
        };

       
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            sizeTail = WidhtCanvas / 2 /10;
            canvas = new Bitmap(WidhtCanvas, HeightCanvas);
            graph = Graphics.FromImage(canvas);

            Matrix m = new Matrix();

            m.Translate(WidhtCanvas / 2, HeightCanvas / 2);
            graph.Transform = m;

            back = graph.Transform;
            repaint();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.Transform = graph.Transform;

            base.OnPaint(e);
        }
        private void repaint()
        {
            graph.Clear(pictureBox1.BackColor);

            if (chckDrawGrid.Checked)
                DrawGrid(graph, sizeTail);

            if (chckDrawAxis.Checked || chckDrawAxiswithValue.Checked)
                DrawAxes(graph, sizeTail, chckDrawAxiswithValue.Checked);

            if (chckDrawFigure.Checked)
                Notation(figure_coords, TransformFigureX.Value, TransformFigureY.Value * -1, RotateFigure.Value);


            pictureBox1.Image = canvas;
        }

        #region Settings
        private void chckDrawAxis_CheckedChanged(object sender, EventArgs e)
        {
            chckDrawAxiswithValue.Checked = false;
            repaint();
        }
        private void chckDrawAxiswithValue_CheckedChanged(object sender, EventArgs e)
        {
            chckDrawAxis.Checked = false;
            repaint();
        }
        private void chckDrawGrid_CheckedChanged(object sender, EventArgs e)
        {
            repaint();
        }
        private void chckDrawFigure_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxFigure.Enabled = (sender as CheckBox).Checked;
            tableLayoutPanel1.Visible = (sender as CheckBox).Checked;
            label7.Visible = tableLayoutPanel1.Visible;
            if (tableLayoutPanel1.Visible)
            {
                tableLayoutPanel1.Controls.Clear();

                for (int i = 0; i < 6; i++)
                {
                    tableLayoutPanel1.Controls.Add(new TextBox() {});
                    this.Refresh();
                }
            }
            repaint();
        }
        private void TransformFigureY_Scroll(object sender, EventArgs e)
        {
            repaint();
        }
        private void TransformFigureX_Scroll(object sender, EventArgs e)
        {
            repaint();
        }
        private void btnResetCoordsFigure_Click(object sender, EventArgs e)
        {
            TransformFigureX.Value = 50;
            TransformFigureY.Value = 50;
            RotateFigure.Value = 0;
            repaint();
        }
        private void clChange_SelectedColor(object sender, EventArgs r)
        {
            cl.ShowDialog();
            (sender as ComboBox).BackColor = cl.Color;
        }
        private void ScalingBar_Scroll(object sender, EventArgs e)
        {
            lblZoom.Text = "Маштаб: "+(100 + ScalingBar.Value)+"%";//Zoom:
            zoom = ((float)ScalingBar.Value / 100);
            Scale();
        }
        private void ScalingBar_MouseLeave(object sender, EventArgs e)
        {
            Matrix m = back.Clone();
            m.Scale(1.0f + zoom, 1.0f + zoom);

            graph.Transform = m.Clone();
        }
        private void btnResetZoom_Click(object sender, EventArgs e)
        {
            graph.Transform = back.Clone();
            zoom = .0f;
            Scale();

            lblZoom.Text = "Маштаб: 100%";
            ScalingBar.Value = 0;
        }
        #endregion

        #region Method
        int WidhtCanvas = 500;
        int HeightCanvas = 500;
        float zoom = .0f;
        private void DrawAxes(Graphics graph, int offset, bool DrawValue)
        {
            Pen pen = new Pen(clAxes.BackColor, 1);
            pen.CustomEndCap = new AdjustableArrowCap(6, 6);

            //Draw Axes
            graph.DrawLine(pen, -(WidhtCanvas / 2), 0, (WidhtCanvas / 2), 0); //Horizontal
            graph.DrawLine(pen, 0, (HeightCanvas / 2), 0, -(HeightCanvas / 2)); //Vertical

            pen = new Pen(clAxes.BackColor, 1);

            Matrix back = graph.Transform.Clone();
            Queue<Point> pointsV = new Queue<Point>();
            Queue<Point> pointsH = new Queue<Point>();

            //*************************************************************************************
            //*Important! : The upper side of the Y axis is -250 instead of 250 as we are used to *
            //*************************************************************************************
            for (int horR = 10, horL = -10, verB = -10, verD = 10; horR < (WidhtCanvas / 2) - 10; horR += 10, horL -= 10, verB -= 10, verD+=10)
            {
                graph.DrawLine(pen, horR, -5, horR, 5);//Draw dividing From zero to the right
                graph.DrawLine(pen, horL, -5, horL, 5);//Draw dividing From zero to the left
                graph.DrawLine(pen, -5,verB, 5, verB);//Draw dividing From zero to the bottom
                graph.DrawLine(pen, -5, verD, 5, verD);//Draw dividing From zero to the down

                if (DrawValue)
                {
                    #region Draw String
                    //In the bottom
                    //graph.DrawString((verB * -1).ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, 10, verB - 8);
                    graph.DrawString((verB * -1).ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, -25, verB - 8);
                    //In the down
                    graph.DrawString((verD * -1).ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, 10, verD - 5);
                    //In the right
                    Matrix _m = back.Clone();
                    _m.RotateAt(90, new PointF(horR, 10), MatrixOrder.Prepend);
                    graph.Transform = _m;
                    //graph.DrawString(horR.ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, horR-2, 5);
                    graph.DrawString(horR.ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, horR - 35, 5);
                    //In the left
                    _m = back.Clone();
                    _m.RotateAt(90, new PointF(horL, 10), MatrixOrder.Prepend);
                    graph.Transform = _m;
                    graph.DrawString(horL.ToString(), new Font("Area", 7, FontStyle.Regular), Brushes.Red, horL - 2, 5);

                    graph.Transform = back.Clone();//backup original matrix
                    #endregion
                }
            }

            back = graph.Transform;
        }

        private void DrawGrid(Graphics graph, int SizeTail)
        {
            for (int horLine = -(WidhtCanvas / 2),vertLine = -(HeightCanvas / 2); horLine < (WidhtCanvas / 2)-10; horLine+= SizeTail, vertLine+= SizeTail)
            {
                graph.DrawLine(new Pen(clGrid.BackColor), -(WidhtCanvas / 2), horLine, WidhtCanvas / 2, horLine);
                graph.DrawLine(new Pen(clGrid.BackColor), vertLine, -(HeightCanvas / 2), vertLine, HeightCanvas / 2);
            }
        }

        private void Notation(Point[] points, int x, int y,int angle)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(points);

            Matrix m = new Matrix();
            m.Translate(x, y);
            int centreX, centreY;
            centreX = (int)gp.PathPoints[0].X;//50;//(int)(gp.PathPoints[3].X - gp.PathPoints[0].X)
            centreY = (int)gp.PathPoints[0].Y;//(int)(gp.PathPoints[2].Y - gp.PathPoints[0].Y);
            graph.DrawLine(new Pen(Color.Red), 0, 0, centreX, centreY);
            m.RotateAt(angle,new PointF(centreX,centreY));
            gp.Transform(m);
            graph.DrawPath(new Pen(clFigure.BackColor), gp);

            ShowMatrix(m);

            graph.DrawString("A(" + Math.Round(gp.PathPoints[0].X) + "," + Math.Round(gp.PathPoints[0].Y) * -1 + ")", new Font("Arial", 7), Brushes.Red, gp.PathPoints[0].X, gp.PathPoints[0].Y);
            graph.DrawString("B(" + Math.Round(gp.PathPoints[1].X) + "," + Math.Round(gp.PathPoints[1].Y) * -1 + ")", new Font("Arial", 7), Brushes.Red, gp.PathPoints[1].X, gp.PathPoints[1].Y);
            graph.DrawString("C(" + Math.Round(gp.PathPoints[2].X) + "," + Math.Round(gp.PathPoints[2].Y) * -1 + ")", new Font("Arial", 7), Brushes.Red, gp.PathPoints[2].X, gp.PathPoints[2].Y);
            graph.DrawString("D(" + Math.Round(gp.PathPoints[3].X) + "," + Math.Round(gp.PathPoints[3].Y) * -1 + ")", new Font("Arial", 7), Brushes.Red, gp.PathPoints[3].X, gp.PathPoints[3].Y);
        }
        private void ShowMatrix(Matrix outMatrix)
        {
            if(outMatrix.Elements.Length != tableLayoutPanel1.Controls.Count)
            {
                tableLayoutPanel1.Controls.Clear();
                for (int i = 0; i < outMatrix.Elements.Length; i++)
                {
                    tableLayoutPanel1.Controls.Add(new TextBox() { Text = Math.Round(outMatrix.Elements[i], 2).ToString() });
                    this.Refresh();
                }
            }

            for (int i = 0; i < outMatrix.Elements.Length; i++)
            {
                tableLayoutPanel1.Controls[i].Text = Math.Round(outMatrix.Elements[i], 2).ToString();
            }

        }
        private void Scale()//float zoom=.0f,
        {
            Matrix m = graph.Transform.Clone();
            m.Scale(1.0f + zoom, 1.0f + zoom);

            graph.Transform = m.Clone();

            HeightCanvas = (int)graph.VisibleClipBounds.Height;
            WidhtCanvas = (int)graph.VisibleClipBounds.Width;

            repaint();

            graph.Transform = back.Clone();
        }
        #endregion

        private void RotateFigure_Scroll(object sender, EventArgs e)
        {
            repaint();
        }
    }
}
