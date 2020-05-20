using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UnitedWorld
{
    public class Mark : PictureBox
    {
        public MarkData Data { get; private set; }

        public Mark(MarkData data, Image image)
        {
            Data = data;
            Image = image;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(30, 30);
        }
    }
}
