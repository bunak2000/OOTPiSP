using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_otpisp_1
{
    class CEllipse : CFigure
    {
        TPoint center;
        int radius_a;
        int radius_b;

        public CEllipse(int pen_width,Color pen_color, TPoint center, int radius_a, int radius_b) : base(pen_width,pen_color)
        {
            this.center = center;
            this.radius_a = radius_a;
            this.radius_b = radius_b;
        }
        public CEllipse(int pen_width, Color pen_color, int center_x,int center_y, int radius_a, int radius_b) : base(pen_width, pen_color)
        {
            TPoint center;
            center.x = center_x;
            center.y = center_y;
            this.center = center;
            this.radius_a = radius_a;
            this.radius_b = radius_b;
        }
        public override void Draw(Graphics Canvas,Pen DrawingPen)
        {
            DrawingPen.Color = this.pen_color;
            DrawingPen.Width = this.pen_width;
            Canvas.DrawEllipse(DrawingPen,center.x-radius_b,center.y-radius_a,radius_b*2,radius_a*2);
        }
        public override CFigure Create(int pen_width, Color pen_color, int[] parameters)
        {
            CEllipse temp = new CEllipse(pen_width, pen_color, parameters[0], parameters[1], parameters[2], parameters[3]);
            return temp;
        }
        public static CEllipse CreateTemplate()
        {
            CEllipse temp = new CEllipse(0, Color.FromArgb(0, 0, 0), 0, 0, 0, 0);
            return temp;
        }
        public override void GetParams(int[] parametrs) 
        {
            parametrs[0] = center.x;
            parametrs[1] = center.y;
            parametrs[2] = radius_a;
            parametrs[3] = radius_b;
        }
    }

}
