using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace lab_otpisp_1
{
    class CFigureList
    {
        public List<CFigure> figures;

        public CFigureList()
        {
            figures = new List<CFigure>();
        }
        public void Draw(Graphics Canvas, Pen DrawingPen) 
        {
            for (int i = 1; i <= this.figures.Count; i++)
            {
               figures[i - 1].Draw(Canvas,DrawingPen);
            }  
        }
        public void SaveProgress() 
        {
            StreamWriter stream = new StreamWriter("data.txt", false, System.Text.Encoding.Default);
            int[] temp = new int[4]; 

            for (int i = 1; i <= this.figures.Count; i++)
            {
                stream.WriteLine(figures[i-1].type.ToString());
                stream.WriteLine(figures[i-1].pen_color.ToArgb());
                stream.WriteLine(figures[i-1].pen_width.ToString());
                figures[i-1].GetParams(temp);
                for (int j = 0; j < temp.Length; j++)
                {
                    stream.Write(temp[j].ToString()+"/");
                }
                stream.WriteLine();
                stream.WriteLine("|");

            }
            stream.Close();
        }
        public void LoadProgress(List<CFigure> template)
        {
            StreamReader stream = new StreamReader("data.txt", System.Text.Encoding.Default);
            int[] temp = new int[4];
            int type;
            int color;
            int width;
            int temp_pos = 0;
            string line,temp_int;

            temp_int ="";

            while (!stream.EndOfStream)
            {
                line = stream.ReadLine();
                type = int.Parse(line);
                line = stream.ReadLine();
                color = int.Parse(line);
                line = stream.ReadLine();
                width = int.Parse(line);
                line = stream.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != '/')
                    {
                        temp_int = temp_int + line[i];
                    }
                    else
                    {
                        temp[temp_pos] = int.Parse(temp_int);
                        temp_int = "";
                        temp_pos++;
                    }
                }
                line = stream.ReadLine();

                figures.Add(template[type].Create(width,Color.FromArgb(color),temp));
                temp_pos = 0;
            }
            
            stream.Close();
        }
    }

}
