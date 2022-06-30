using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clear all fields when clear button is clicked
            listOfShapes.SelectedIndex = -1;
            showShapePanel.Refresh();
            fillShape.Checked = false;
            outlineShape.Checked = false;
            dateBox.Text = null;
            nameBox.Text = null;
            showName.Checked = false;
            showDate.Checked = false;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            {
                //refresh the form when the clear button is clicked
                showShapePanel.Refresh();

                //instantiate graphics object
                Graphics graphics = this.showShapePanel.CreateGraphics();
                //instantiate pen object, assign color, and width
                Pen pen = new Pen(Color.Blue, 4);
                //instantiate solid brush object and assign color
                SolidBrush brush = new SolidBrush(Color.Blue);

                //once draw is clicked, if circle is selected (at index 0), draw a circle with the following dimensions
                if (listOfShapes.SelectedIndex == 0)
                {
                    //if fill is selected use Fill Elipse and brush with the dimensions
                    if (fillShape.Checked)
                    {
                        graphics.FillEllipse(brush, 15, 15, 130, 130);
                    }
                    //if outline is selected use Draw Elipse and pen with the dimensions
                    else if (outlineShape.Checked)
                    {
                        graphics.DrawEllipse(pen, 15, 15, 130, 130);
                    }
                }

                //once draw is clicked, if triangle is selected (at index 1), draw a triangle with the following dimensions
                else if (listOfShapes.SelectedIndex == 1)
                {
                    //initialize the point objects that will be used for the triangle
                        Point point1 = new Point(20, 160);
                        Point point2 = new Point(160, 160);
                        Point point3 = new Point(80, 40);

                    //if fill is selected use Fill Polygon and brush with points in the array 
                    if (fillShape.Checked)
                    {
                        graphics.FillPolygon(brush, new Point[] { point1, point2, point3 });
                    }
                    //if outline is selected use Draw Polygon and pen with points in the array 
                    else if (outlineShape.Checked)
                    {
                        graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    }
                }

                //once draw is clicked, if triangle is selected (at index 1), draw a triangle with the following dimensions
                if (listOfShapes.SelectedIndex == 2)
                {
                    //if fill is selected use Fill Rectangle and brush with the dimensions
                    if (fillShape.Checked)
                    {
                        graphics.FillRectangle(brush, 35, 45, 160, 110);
                    }
                    //if outline is selected use Draw Rectangle and pen with the dimensions
                    else if (outlineShape.Checked)
                    {
                        graphics.DrawRectangle(pen, 35, 45, 160, 110);
                    }
                }

                //if showName is selected, convert the listOfShape's index to the name of shape
                if (showName.Checked)
                {
                    if (listOfShapes.SelectedIndex == 0)
                    {
                        dateBox.Text = "Circle";
                    }
                    else if (listOfShapes.SelectedIndex == 1)
                    {
                        dateBox.Text = "Triangle";
                    }
                    else if (listOfShapes.SelectedIndex == 2)
                    {
                        dateBox.Text = "Rectangle";
                    }
                }

                //if showDate box is checked, display the current date
                if (showDate.Checked)
                {
                    nameBox.Text = DateTime.Now.ToString();
                }
            }
        }
    }
}
