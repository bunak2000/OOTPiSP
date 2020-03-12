using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_otpisp_1
{
    class CLine:CFigure
    {
        TPoint point_a;
        TPoint point_b;

        public CLine(int pen_width, Color pen_color, TPoint point_a, TPoint point_b) : base(pen_width, pen_color)
        {
            this.point_a = point_a;
            this.point_b = point_b;
        }
        public CLine(int pen_width, Color pen_color, int x_a,int y_a,int x_b,int y_b) : base(pen_width, pen_color)
        {
            TPoint temp;
            temp.x = x_a;
            temp.y = y_a;
            this.point_a = temp;
            temp.x = x_b;
            temp.y = y_b;
            this.point_b = temp;
        }
        public override void Draw(Graphics Canvas, Pen DrawingPen)
        {
            DrawingPen.Color = this.pen_color;
            DrawingPen.Width = this.pen_width;
            Canvas.DrawLine(DrawingPen, point_a.x,point_a.y,point_b.x,point_b.y);
        }
        public override CFigure Create(int pen_width, Color pen_color, int[] parameters)
        {
            CLine temp = new CLine(pen_width, pen_color, parameters[0], parameters[1], parameters[2], parameters[3]);
            return temp;
        }
        public static CLine CreateTemplate()
        {
            CLine temp = new CLine(0, Color.FromArgb(0, 0, 0), 0, 0, 0, 0);
            return temp;
        }
        public override void GetParams(int[] parametrs)
        {
            parametrs[0] = point_a.x;
            parametrs[1] = point_a.y;
            parametrs[2] = point_b.x;
            parametrs[3] = point_b.y;
        }
    }
}
