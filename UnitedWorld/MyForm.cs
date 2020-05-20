using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitedWorld.Properties;

namespace UnitedWorld
{
    public partial class MyForm : Form
    {
        private Model model;
        private ModelDrawer drawer;

        public MyForm()
        {
            InitializeComponent();
            model = new Model(map);
            drawer = new ModelDrawer(model);
            this.DoubleBuffered = true;

            model.Map.MouseClick += (sender, args) =>
            {
                switch(args.Button)
                {
                    case MouseButtons.Right:
                        {
                            var position = this.PointToClient(Cursor.Position);
                            var markMenu = new AddMarkMenu();
                            markMenu.Location = Cursor.Position;
                            markMenu.Show();
                            Mark mark = null;
                            markMenu.FormClosing += (s, a) =>
                            {
                                mark = markMenu.GetMark();
                                var v = new Point(position.X - model.Map.Location.X, position.Y - model.Map.Location.Y);
                                mark.Data.WidthPart = (double)v.X / model.Map.Width;
                                mark.Data.HeightPart = (double)v.Y / model.Map.Height;
                                model.Map.AddMark(mark);
                            };
                        };
                        break;
                }
            };
            model.Map.MouseWheel += drawer.ZoomMap;
        }
    }
}
