using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompGraph1
{

    public partial class FormMain : Form
    {
        const double defaultScalingFactor = 1;
        const uint defaultDorRadius = 2; // default R of dot in pixels

        static double xFrom = -10;
        static double yFrom = -10;
        static double xTo = 10;
        static double yTo = 10;
        static double scalingFactor = defaultScalingFactor;

        static bool mirrorOx = false;
        static bool mirrorOy = false;

        static int[,] arrayMirrorOy = new int[2, 2] { { -1, 0 }, { 0, 1 } };
        static int[,] arrayMirrorOx = new int[2, 2] { { 1, 0 }, { 0, -1 } };
        static int[,] arrayMirrorO = new int[2, 2] { { -1, 0 }, { 0, -1 } };

        static bool scaling = false;
        static bool placingDotsNow = false;
        static bool newDotXOk = false;
        static bool newDotYOk = false;
        static FlatObject initialObject = null;
        static FlatObject changedObject = null;
        

        static Pen penInitialObject = new Pen(Color.Black, 1f); // pen for drawing current object
        static Pen penChangedObject = new Pen(Color.Red, 1f); // pen for drawing changed object
        static Pen penAxes = new Pen(Color.LightGray, 1f); // pen for axis drawing
        static Point[] Ox = new Point[2]; // Ox axis
        static Point[] Oy = new Point[2]; // Oy axis
        static Point O; // center

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelForClickedPoint.Visible = false;
            labelClickedPoint.Visible = false;
            maskedTextBoxFactor.Visible = false;
            textBoxFactor.Visible = false;
            maskedTextBoxFactor.ValidatingType = typeof(double);
            O = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            labelO.Text = "(0, 0)";
            xTo = pictureBox.Width - O.X;
            xFrom = -O.X;
            yTo = pictureBox.Height - O.Y;
            yFrom = -O.Y;
            renewAxesBorders();
            renewO();
            changeAxes();
            buttonAddDot.Enabled = false;
        }

        private void renewO()
        {
            textBoxCenterX.Text = (O.X + xFrom).ToString();
            textBoxCenterY.Text = (O.Y + yFrom).ToString();
        }

        private void renewAxesBorders()
        {
            labelOxTo.Text = xTo.ToString();
            labelOxFrom.Text = xFrom.ToString();
            labelOyTo.Text = yTo.ToString();
            labelOyFrom.Text = yFrom.ToString();
        }

        private void changeAxes()
        {
            Ox[0] = new Point(0, O.Y);
            Ox[1] = new Point(pictureBox.Width, O.Y);
            Oy[0] = new Point(O.X, pictureBox.Height);
            Oy[1] = new Point(O.X, 0);
        }

        private void drawAxes(Graphics graphics)
        {
            graphics.DrawLine(penAxes, Ox[0], Ox[1]);
            graphics.DrawLine(penAxes, Oy[0], Oy[1]);
        }
        
        class FlatObject
        {
            private Pen pen;
            private List<Point> orderedDots = new List<Point>(); // dots in the right order
            private uint dotRadius = defaultDorRadius; // R in pixels
            private FlatObject() {}

            public FlatObject(Pen p, List<Point> dots, uint dotR = defaultDorRadius)
            {
                orderedDots = dots; // coordinates are in real Oxy and in pixels
                pen = p;
                dotRadius = dotR;
            }
            public void addDot(Point point) { orderedDots.Add(point); }
            public void setColor(Color cl) { pen.Color = cl; }
            public void setDotRadius(uint R) { dotRadius = R; }
            public List<Point> getDots() { return new List<Point>(orderedDots); }
            public uint getDotRadius() { return dotRadius; }
            public Color getColor() { return pen.Color; }
            public void setPen(Pen p) { pen = p; }
            public Pen getPen() { return pen; }

            public void draw(Pen p, Graphics graphics)
            {
                List<Point> dots = getDots();
                uint r = getDotRadius();
                setPen(p);
                int dotsSize = dots.Count();
                for (int dotIndex = 0; dotIndex < dotsSize; dotIndex++)
                {
                    graphics.DrawEllipse(pen, dots[dotIndex].X - r / 2, dots[dotIndex].Y - r / 2, r, r);
                    if (dotIndex + 1 < dotsSize)
                        graphics.DrawLine(pen, dots[dotIndex], dots[dotIndex + 1]);
                }
            }
        }

        static int[,] multiplyMatrix(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        FlatObject matrixImpact(FlatObject init, int[,] matrix) // returns changed flat object
        {
            List<Point> newPoints = init.getDots();
            for (int i = 0; i < newPoints.Count; i++)
            {
                newPoints[i] = realToO(newPoints[i], O);
                int[,] dot = new int[1, 2] { { newPoints[i].X, newPoints[i].Y} };
                dot = multiplyMatrix(dot, matrix);
                newPoints[i] = new Point(dot[0, 0], dot[0, 1]);
                newPoints[i] = oToReal(newPoints[i], O);
            }
            return new FlatObject(penChangedObject, newPoints);
        }

        private Point realToO(Point point, Point O) // returns point's coordinates in coordinate system centered at point O
        {
            return new Point(point.X - O.X, O.Y - point.Y);
        }

        private Point oToReal(Point point, Point O) // translates coordinates in coordinate system centered at point O to real
        {
            return new Point(point.X + O.X, O.Y - point.Y);
        }

        static Point moveOToNewO(Point point, Point O, Point newO) // returns point in O-coords in newO-coords
        {
            int[,] dot = new int[1, 3] { { point.X, point.Y, 1 } };
            int[,] matrixMoveToO = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { O.X - newO.X, O.Y - newO.Y, 1 } };
            int[,] newDot = multiplyMatrix(dot, matrixMoveToO);
            return new Point(newDot[0, 0], newDot[0, 1]);
        }

        private FlatObject moveObjectToNewO(FlatObject obj, Point oldO, Point newO)
        {
            List<Point> newDots = new List<Point>();
            foreach(Point dot in obj.getDots())
            {
                newDots.Add(moveOToNewO(dot, oldO, newO));
            }
            return new FlatObject(obj.getPen(), newDots);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point dot = me.Location;
            if (placingDotsNow)
            { // there put a new object's dot
                DialogResult result = MessageBox.Show("Do you want to set dot (" + (dot.X - O.X) + ", " +
                    (O.Y - dot.Y) + ")?", "Placing object's dots", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (initialObject == null)
                        initialObject = new FlatObject(penInitialObject, new List<Point>());
                    initialObject.addDot(dot);
                    pictureBox.Invalidate();
                }
            }
            else
            { // there can click on object's dot and see it's coordinates
                if (initialObject != null)
                {
                    List<Point> dots = new List<Point>(initialObject.getDots());
                    if (changedObject != null)
                    {
                        dots.AddRange(changedObject.getDots());
                    }
                    foreach (Point point in dots)
                    {
                        if ((Math.Abs(dot.X - point.X) <= 3) && (Math.Abs(dot.Y - point.Y) <= 3))
                        {
                            labelForClickedPoint.Visible = true;
                            labelClickedPoint.Visible = true;
                            labelClickedPoint.Text = "(" + (point.X - O.X) + ", " + (O.Y - point.Y) + ")";
                            break;
                        }
                    }
                    
                }
            }
        }

        FlatObject scaleObjectWith (FlatObject obj, double scaleParam = defaultScalingFactor)
        {
            // find gravity center to move it to O and scale and then return the object back
            int[,] gravityCenter = new int[1, 2] { { 0, 0 } };
            List<Point> dots = new List<Point>(obj.getDots());
            foreach (Point point in dots)
            {
                gravityCenter[0, 0] += point.X;
                gravityCenter[0, 1] += point.Y;
            }
            gravityCenter[0, 0] /= dots.Count; // loss
            gravityCenter[0, 1] /= dots.Count; // loss
            Point gravityCenterPoint = new Point(gravityCenter[0, 0], gravityCenter[0, 1]);
            Point realCenter = new Point(0, 0);

            for (int i = 0; i < dots.Count; i++)
            {
                dots[i] = moveOToNewO(dots[i], realCenter, gravityCenterPoint);
                int x = (int)Math.Round(dots[i].X * scaleParam);
                int y = (int)Math.Round(dots[i].Y * scaleParam);
                Point currentPoint = new Point(x, y); // loss
                dots[i] = moveOToNewO(currentPoint, gravityCenterPoint, realCenter);
            }
            return new FlatObject(penChangedObject, dots);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            drawAxes(graphics);
            
            if (initialObject != null)
            {
                initialObject.draw(penInitialObject, graphics);
                if (mirrorOx || mirrorOy || scaling)
                {
                    if (mirrorOx && mirrorOy)
                        changedObject = matrixImpact(initialObject, arrayMirrorO);
                    else if (mirrorOx)
                        changedObject = matrixImpact(initialObject, arrayMirrorOx);
                    else if (mirrorOy)
                        changedObject = matrixImpact(initialObject, arrayMirrorOy);
                    else
                        changedObject = new FlatObject(penChangedObject, initialObject.getDots());

                    if (scaling)
                        changedObject = scaleObjectWith(changedObject, scalingFactor); 
                }
                else
                    changedObject = null; // if there is no changes made to initial object the changed object can't be seen or doesn't exist
                if (changedObject != null)
                    changedObject.draw(penChangedObject, graphics);
            }
        }

        private void moveO()
        {
            Point oldO = O;
            O = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            xTo = pictureBox.Width - O.X;
            xFrom = -O.X;
            yTo = pictureBox.Height - O.Y;
            yFrom = -O.Y;
            renewAxesBorders();
            O.X = Convert.ToInt32(-xFrom);
            O.Y = Convert.ToInt32(-yFrom);
            Point newOO = new Point(-Convert.ToInt32((O.X - oldO.X)), -Convert.ToInt32((O.Y - oldO.Y)));
            if (initialObject != null)
            {
                List<Point> dotsInit = initialObject.getDots();
                List<Point> newDotsInit = new List<Point>();
                List<Point> dotsChanged = null;
                List<Point> newDotsChanged = null;
                if (changedObject != null)
                {
                    dotsChanged = changedObject.getDots();
                    newDotsChanged = new List<Point>();
                }

                for (int i = 0; i < dotsInit.Count; i++)
                {
                    newDotsInit.Add(moveOToNewO(dotsInit[i], new Point(0, 0), newOO));
                    if (changedObject != null)
                        newDotsChanged.Add(moveOToNewO(dotsChanged[i], new Point(0, 0), newOO));
                }
                initialObject = new FlatObject(initialObject.getPen(), newDotsInit);
                if (changedObject != null)
                    changedObject = new FlatObject(changedObject.getPen(), newDotsChanged);
            }
            changeAxes();
            pictureBox.Invalidate();
        }

        
        private void checkBoxScaling_CheckedChanged(object sender, EventArgs e)
        {
            scaling = !scaling;
            if (scaling)
            {
                maskedTextBoxFactor.Visible = true;
                textBoxFactor.Visible = true;
            }
            else
            {
                maskedTextBoxFactor.Visible = false;
                textBoxFactor.Visible = false;
            }
            pictureBox.Invalidate();
        }

        private void buttonPlaceObjectDots_Click(object sender, EventArgs e)
        {
            placingDotsNow = !placingDotsNow;
            if (placingDotsNow)
            {
                labelForClickedPoint.Visible = false;
                labelClickedPoint.Visible = false;
                buttonPlaceObjectDots.Text = "Finish placing object's dots";
                initialObject = null;
                changedObject = null;
                if (newDotXOk && newDotYOk)
                    buttonAddDot.Enabled = true;
            }   
            else
            {
                buttonPlaceObjectDots.Text = "Clear and place new object's dots";
                buttonAddDot.Enabled = false;
            }
            pictureBox.Invalidate();

        }

        private void buttonSelectInitObectColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                penInitialObject.Color = colorDialog.Color;
                pictureBox.Invalidate();
            }
        }

        private void buttonSelectNewObjectColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                penChangedObject.Color = colorDialog.Color;
                pictureBox.Invalidate();
            }
        }

        private void checkBoxMirrorOx_CheckedChanged(object sender, EventArgs e)
        {
            mirrorOx = !mirrorOx;
            pictureBox.Invalidate();
        }

        private void checkBoxMirrorOy_CheckedChanged(object sender, EventArgs e)
        {
            mirrorOy = !mirrorOy;
            pictureBox.Invalidate();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            moveO();
            labelO.Text = "(0, 0)";
            textBoxCenterX.Text = "0";
            textBoxCenterY.Text = "0";
        }

        private void maskedTextBoxFactor_TextChanged(object sender, EventArgs e)
        {
            if (scaling)
            {
                maskedTextBoxFactor.Text = maskedTextBoxFactor.Text.Replace('.', ',');
                maskedTextBoxFactor.SelectionStart = maskedTextBoxFactor.Text.Length;
                double s = defaultScalingFactor;
                if (!double.TryParse(maskedTextBoxFactor.Text, out s))
                {
                    if (maskedTextBoxFactor.Text != "")
                    {
                        maskedTextBoxFactor.Text = maskedTextBoxFactor.Text.Remove(maskedTextBoxFactor.Text.Length - 1);
                        maskedTextBoxFactor.SelectionStart = maskedTextBoxFactor.Text.Length;
                    }
                    else
                        scalingFactor = defaultScalingFactor;
                }
                else
                {
                    if (s >= 0)
                    {
                        if (s != 0)
                            scalingFactor = s;
                    }
                    else
                    {
                        scalingFactor = defaultScalingFactor;
                        maskedTextBoxFactor.Text = scalingFactor.ToString();
                    }
                }
                pictureBox.Invalidate();
            }
        }

        private bool checkTextBoxOnIntInput(TextBox textBox)
        {
            int x = 0;
            if (!int.TryParse(textBox.Text, out x))
            {
                if (textBox.Text != "" && textBox.Text != "-")
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else
                    return false;
            }
            return true;
        }

        private void textBoxNewDotX_TextChanged(object sender, EventArgs e)
        {
            newDotXOk = checkTextBoxOnIntInput(textBoxNewDotX);
            if (newDotXOk && newDotYOk)
                buttonAddDot.Enabled = true;
            else
                buttonAddDot.Enabled = false;
        }

        private void textBoxNewDotY_TextChanged(object sender, EventArgs e)
        {
            newDotYOk = checkTextBoxOnIntInput(textBoxNewDotY);
            if (newDotXOk && newDotYOk)
                buttonAddDot.Enabled = true;
            else
                buttonAddDot.Enabled = false;
        }

        private void buttonAddDot_Click(object sender, EventArgs e)
        {
            Point dot = new Point(int.Parse(textBoxNewDotX.Text) + O.X, -int.Parse(textBoxNewDotY.Text) + O.Y);
            if (initialObject == null)
                initialObject = new FlatObject(penInitialObject, new List<Point>());
            initialObject.addDot(dot);
            textBoxNewDotX.Text = "";
            textBoxNewDotY.Text = "";
            pictureBox.Invalidate();
        }

        private void textBoxCenterX_TextChanged(object sender, EventArgs e)
        {
            bool x = checkTextBoxOnIntInput(textBoxCenterX);
            bool y = checkTextBoxOnIntInput(textBoxCenterY);
            if (x && y)
                buttonMoveCenter.Enabled = true;
            else
                buttonMoveCenter.Enabled = false;
        }

        private void textBoxCenterY_TextChanged(object sender, EventArgs e)
        {
            bool x = checkTextBoxOnIntInput(textBoxCenterX);
            bool y = checkTextBoxOnIntInput(textBoxCenterY);
            if (x && y)
                buttonMoveCenter.Enabled = true;
            else
                buttonMoveCenter.Enabled = false;
        }

        private void buttonMoveCenter_Click(object sender, EventArgs e)
        {
            int x = -int.Parse(textBoxCenterX.Text);
            int y = -int.Parse(textBoxCenterY.Text);

            if (x != O.X || y != O.Y)
            {
                Point newO = new Point(x + O.X, -y + O.Y);
                if (initialObject != null) // move all from O to newO
                {
                    initialObject = moveObjectToNewO(initialObject, O, newO);
                    if (changedObject != null)
                        changedObject = moveObjectToNewO(changedObject, O, newO);
                }
                O = new Point(O.X - x, O.Y + y);
                labelO.Text = "( " + (O.X - pictureBox.Width / 2) + ", " + (pictureBox.Height / 2 - O.Y) + " )";
                changeAxes();
                pictureBox.Invalidate();
            }
        }

        
    }

}
