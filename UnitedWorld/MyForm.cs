using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedWorld
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            mapBox.MouseWheel += (sender, args) =>
            {
                var position = new Point(args.X + mapBox.Location.X, args.Y + mapBox.Location.Y);
                var zoomRatio = (args.Delta < 0 ? 0.95 : 1.05);
                mapBox.Size = new Size((int)(mapBox.Bounds.Width * zoomRatio), (int)(mapBox.Height * zoomRatio));
                mapBox.Location = new Point((int)((mapBox.Bounds.X - position.X) * zoomRatio + position.X), (int)((mapBox.Bounds.Y - position.Y) * zoomRatio + position.Y));
            };
        }
    }
}
