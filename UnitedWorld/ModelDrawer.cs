using System.Drawing;
using System.Windows.Forms;

namespace UnitedWorld
{
    class ModelDrawer
    {
        private Model model;

        public ModelDrawer(Model model)
        {
            this.model = model;
        }

        public void ZoomMap(object sender, MouseEventArgs args)
        {
            var position = new Point(args.X + model.Map.Location.X, args.Y + model.Map.Location.Y);
            var zoomRatio = (args.Delta < 0 ? 0.95 : 1.05);
            model.Map.Size = new Size((int)(model.Map.Bounds.Width * zoomRatio), (int)(model.Map.Height * zoomRatio));
            model.Map.Location = new Point((int)((model.Map.Bounds.X - position.X) * zoomRatio + position.X), (int)((model.Map.Bounds.Y - position.Y) * zoomRatio + position.Y));
            UpdateMarks();
        }

        public void UpdateMarks()
        {
            foreach (var mark in model.Map.GetMarks())
                mark.Location = new Point((int)(model.Map.Size.Width * mark.Data.WidthPart), (int)(model.Map.Size.Height * mark.Data.HeightPart));
        }
    }
}
