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

            model.Map.MouseWheel += drawer.ZoomMap;
            for (var i = 0.0d; i <= 1; i += 0.05)
            {
                var markData = new MarkData()
                {
                    Name = $"test{i}",
                    WidthPart = i,
                    HeightPart = i,
                };
                model.Map.AddMark(new Mark(markData, Resources.error));
            }
        }
    }
}
