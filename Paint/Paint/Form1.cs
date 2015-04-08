using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    public partial class Paint : Form
    {
        private ColorDialog colorDlg;
        private SolidBrush sb;
        private Pen pen;
        private Graphics g;
        Point centerPoint;

        public Paint()
        {
            InitializeComponent();
            centerPoint = new Point(panelImg.Width / 2, panelImg.Height / 2);
            circleToolStripMenuItem1.Checked = false;
        }

        public void setImgSizes(int w, int h){
            panelImg.Size = new Size(w, h);
        }


        private void panelCircleBcolor_DoubleClick(object sender, EventArgs e)
        {
            colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panelCircleBcolor.BackColor = colorDlg.Color;
            }
        }

        private void circleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            elipseToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            groupBoxElipse.Visible = false;
            groupBoxSqsuare.Visible = false;
            if (circleToolStripMenuItem1.Checked == false)
            {
                groupBoxCircle.Visible = true;
                circleToolStripMenuItem1.Checked = true;
            }
            else
            {
                groupBoxCircle.Visible = false;
                circleToolStripMenuItem1.Checked = false;
            }

        }

        private void buttonCircleDraw_MouseClick(object sender, MouseEventArgs e)
        {
            int diametr;
            if (!int.TryParse(textBoxCircleDiametr.Text, out diametr))
            {
                MessageBox.Show("Incorect inputs.");
            }
            int penWidth;
            if (!int.TryParse(textBoxPenSize.Text, out penWidth))
            {
                MessageBox.Show("Incorect inputs.");
            }
            g = panelImg.CreateGraphics();
            pen = new Pen(panelCircleBcolor.BackColor,penWidth);
            g.DrawEllipse(pen, centerPoint.X-diametr/2, centerPoint.Y-diametr/2, diametr, diametr);
        }

        private void panelImg_MouseClick(object sender, MouseEventArgs e)
        {
            if (circleToolStripMenuItem1.Checked == true)
            {
                int diametr;
                if (!int.TryParse(textBoxCircleDiametr.Text, out diametr))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                int penWidth;
                if (!int.TryParse(textBoxPenSize.Text, out penWidth))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                g = panelImg.CreateGraphics();
                pen = new Pen(panelCircleBcolor.BackColor, penWidth);
                g.DrawEllipse(pen, e.X - diametr / 2, e.Y - diametr / 2, diametr, diametr);
            }
            else if (elipseToolStripMenuItem.Checked == true)
            {
                int width;
                if (!int.TryParse(textBoxElipseWidth.Text, out width))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                int height;
                if (!int.TryParse(textBoxElipseHeight.Text, out height))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                int penWidth;

                if (!int.TryParse(textBoxElipsePenSize.Text, out penWidth))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                g = panelImg.CreateGraphics();
                sb = new SolidBrush(panelElipseFcolor.BackColor);
                pen = new Pen(panelElipseBcolor.BackColor, penWidth);
                g.FillEllipse(sb, e.X - width / 2, e.Y - height / 2, width, height);
                g.DrawEllipse(pen, e.X - width / 2, e.Y - height / 2, width, height);
            }

            else if (squareToolStripMenuItem.Checked == true)
            {
                int width;
                if (!int.TryParse(textBoxSquareWidth.Text, out width))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                int penWidth;

                if (!int.TryParse(textBoxSquarePenSize.Text, out penWidth))
                {
                    MessageBox.Show("Incorect inputs.");
                }
                g = panelImg.CreateGraphics();

                sb = new SolidBrush(panelSquareFcolor.BackColor);
                pen = new Pen(panelSquareBcolor.BackColor, penWidth);
                g.FillRectangle(sb, e.X - width / 2, e.Y - width / 2, width, width);
                g.DrawRectangle(pen, e.X - width / 2, e.Y - width / 2, width, width);
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelImg.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width;
            if (!int.TryParse(textBoxElipseWidth.Text, out width))
            {
                MessageBox.Show("Incorect inputs.");
            }
            int height;
            if (!int.TryParse(textBoxElipseHeight.Text, out height))
            {
                MessageBox.Show("Incorect inputs.");
            }
            int penWidth;

            if (!int.TryParse(textBoxElipsePenSize.Text, out penWidth))
            {
                MessageBox.Show("Incorect inputs.");
            }
            g = panelImg.CreateGraphics();
            sb = new SolidBrush(panelElipseFcolor.BackColor);
            pen = new Pen(panelElipseBcolor.BackColor, penWidth);
            g.FillEllipse(sb, centerPoint.X - width / 2, centerPoint.Y - height / 2, width, height);
            g.DrawEllipse(pen, centerPoint.X - width/2, centerPoint.Y - height / 2, width, height);
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem1.Checked = false;
            squareToolStripMenuItem.Checked = false;
            groupBoxSqsuare.Visible = false;
            groupBoxCircle.Visible = false;
            if (elipseToolStripMenuItem.Checked == false)
            {
                elipseToolStripMenuItem.Checked = true;
                groupBoxElipse.Visible = true;
            }
            else
            {
                elipseToolStripMenuItem.Checked = false;
                groupBoxElipse.Visible = false;
            }

        }

        private void panelElipseBcolor_DoubleClick(object sender, EventArgs e)
        {
            colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panelElipseBcolor.BackColor = colorDlg.Color;
            }
        }

        private void panelElipseFcolor_DoubleClick(object sender, EventArgs e)
        {
            colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panelElipseFcolor.BackColor = colorDlg.Color;
            }
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elipseToolStripMenuItem.Checked = false;
            circleToolStripMenuItem1.Checked = false;
            groupBoxElipse.Visible = false;
            groupBoxCircle.Visible = false;
            if (squareToolStripMenuItem.Checked == false)
            {
                squareToolStripMenuItem.Checked = true;
                groupBoxSqsuare.Visible = true;
            }
            else
            {
                squareToolStripMenuItem.Checked = false;
                groupBoxSqsuare.Visible = false;

            }
        }

        private void buttonSquareDraw_Click(object sender, EventArgs e)
        {
            int width;
            if (!int.TryParse(textBoxSquareWidth.Text, out width))
            {
                MessageBox.Show("Incorect inputs.");
            }
            int penWidth;

            if (!int.TryParse(textBoxSquarePenSize.Text, out penWidth))
            {
                MessageBox.Show("Incorect inputs.");
            }
            g = panelImg.CreateGraphics();
            
            sb = new SolidBrush(panelSquareFcolor.BackColor);
            pen = new Pen(panelSquareBcolor.BackColor, penWidth);
            g.FillRectangle(sb, centerPoint.X - width / 2, centerPoint.Y - width / 2, width, width);
            g.DrawRectangle(pen, centerPoint.X - width / 2, centerPoint.Y - width / 2, width, width);
        }

        private void panelSquareBcolor_DoubleClick(object sender, EventArgs e)
        {
            colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panelSquareBcolor.BackColor = colorDlg.Color;
            }
        }

        private void panelSquareFcolor_DoubleClick(object sender, EventArgs e)
        {
            colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panelSquareFcolor.BackColor = colorDlg.Color;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CourseWork by Ptaha Pawel.","WTF");
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings f2 = new Settings(this);
            f2.Show();
            f2.setSizes(panelImg.Width, panelImg.Height);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               Bitmap bmp = new Bitmap(panelImg.Width,panelImg.Height);
               bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }

        }



    }
}
