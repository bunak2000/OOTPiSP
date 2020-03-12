using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_otpisp_1
{
    public partial class FormMain : Form
    {
        public List<CFigure> Templates;
        List<string> figure_names;
        CFigureList list;
        Bitmap Drawing;
        Graphics Canvas;
        Pen DrawingPen;
        int[] parameters;
        int current_figure;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Color color_default;
            //color_default = Color.FromArgb(23,32,32);
            current_figure = 0;

            Templates = new List<CFigure>();
            figure_names = new List<string>();
            parameters = new int[4];

            list = new CFigureList();
            DrawingPen = new Pen(Color.FromArgb(0,0,0), 1);

            Drawing = new Bitmap(PictureBoxDrawField.Width,PictureBoxDrawField.Height);
            Canvas = Graphics.FromImage(Drawing);

            //Canvas.DrawLine(DrawingPen,10,10,121,211);

            Templates.Add(CEllipse.CreateTemplate());
            figure_names.Add("       Эллипс");
            Templates.Add(CRectangle.CreateTemplate());
            figure_names.Add("Прямоугольник");
            Templates.Add(CLine.CreateTemplate());
            figure_names.Add("      Отрезок");

            labelType.Text = figure_names[0];
            //list.figures.Add( Templates[0].Create(5, color_default, parameters) );

            //list.AddEllipse(11,color_default,point,15,20);
            //list.AddRectangle(12,color_default,point,200,200);

            //int n = list.figures.Count;

            //CEllipse ellipse = new CEllipse(12,color_default,250,250,35,20);
            //ellipse.Draw(Canvas, DrawingPen);

            //list.figures[0] = ellipse;

            //CRectangle rectangle = new CRectangle(5, color_default, point, 132, 102);
            //rectangle.Draw(Canvas, DrawingPen);

            //CLine line = new CLine(33,color_default,12,12,144,144);
            //line.Draw(Canvas,DrawingPen);

            //list.Draw(Canvas, DrawingPen);

            //MessageBox.Show(n.ToString());

            PictureBoxDrawField.Image = Drawing;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialogPen.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int temp;
            parameters[0] = int.Parse(textBoxX.Text);
            parameters[1] = int.Parse(textBoxY.Text);
            parameters[2] = int.Parse(textBoxInput3.Text);
            parameters[3] = int.Parse(textBoxInput4.Text);

            temp = int.Parse(textBoxPenWidth.Text);
            list.figures.Add(Templates[current_figure].Create(temp, colorDialogPen.Color, parameters));

            list.figures[list.figures.Count - 1].type = current_figure;

            Invalidate();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            list.Draw(Canvas, DrawingPen);
            PictureBoxDrawField.Image = Drawing;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (current_figure + 1 >= Templates.Count)
            {
                current_figure = 0;
            labelType.Text = figure_names[0];
            }
            else
            {
                current_figure++;
                labelType.Text = figure_names[current_figure];
            }
            Invalidate();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (current_figure <= 0)
            {
                current_figure = Templates.Count - 1;
                labelType.Text = figure_names[Templates.Count - 1];
            }
            else
            {
                current_figure--;
                labelType.Text = figure_names[current_figure];
            }

            Invalidate();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            list.SaveProgress();
        }

        private void MenuLoad_Click(object sender, EventArgs e)
        {
            list.LoadProgress(Templates);
            Invalidate();
        }
    }
}
