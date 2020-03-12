using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_otpisp_1
{
    class CRectangle : CFigure
    {
        TPoint left_top_corner;
        int width;
        int height;

        public CRectangle(int pen_width, Color pen_color, TPoint left_top_corner, int width, int height) : base(pen_width, pen_color)
        {
            this.left_top_corner = left_top_corner;
            this.width = width;
            this.height = height;
        }
        public CRectangle(int pen_width, Color pen_color, int x, int y, int width, int height) : base(pen_width, pen_color)
        {
            TPoint temp;
            temp.x = x;
            temp.y = y;
            this.left_top_corner = temp;
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics Canvas, Pen DrawingPen)
        {
            DrawingPen.Color = this.pen_color;
            DrawingPen.Width = this.pen_width;
            Canvas.DrawRectangle(DrawingPen, left_top_corner.x, left_top_corner.y, width, height);
        }
        public override CFigure Create(int pen_width, Color pen_color, int[] parameters)
        {
            CRectangle temp = new CRectangle(pen_width, pen_color, parameters[0], parameters[1], parameters[2], parameters[3]);
            return temp;
        }
        public static CRectangle CreateTemplate()
        {
            CRectangle temp = new CRectangle(0, Color.FromArgb(0, 0, 0), 0, 0, 0, 0);
            return temp;
        }
        public override void GetParams(int[] parametrs)
        {
            parametrs[0] = left_top_corner.x;
            parametrs[1] = left_top_corner.y;
            parametrs[2] = width;
            parametrs[3] = height;
        }
    }

}
