using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_otpisp_1
{
    struct TPoint 
    {
        public int x;
        public int y;
    }

    public class CFigure
    {
        public int pen_width { get; }
        public Color pen_color { get; }
        public int type;       

        public virtual void Draw(Graphics Canvas, Pen DrawingPen)
        {
        }
        public CFigure(int pen_width, Color pen_color)
        {
            this.pen_width = pen_width;
            this.pen_color = pen_color;
        }

        public virtual CFigure Create(int pen_width, Color pen_color, int[] parameters) 
        {
            return null;
        }
        public virtual void GetParams(int[] parametrs) 
        {
        }
    }

    /*
    class CCircle : CFigure 
    {
        public TPoint center { get; set; }
        public int radius { get; set; }

        
        public CCircle() 
        {
            TPoint temp;
            temp.x = 20;
            temp.y = 20;

            center = temp;
            radius = 10;           
        }

        public Bitmap Draw(Bitmap Drawing) 
        {
            Graphics Canvas = Graphics.FromImage(Drawing);
            Pen DrawingPen = new Pen(Color.Red, 3);

            Canvas.DrawEllipse(DrawingPen,center.x-radius,center.y-radius,center.x+radius,center.y+radius);

            return Drawing;
        }

    }
    */

}
