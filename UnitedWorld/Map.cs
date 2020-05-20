using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedWorld
{
    class Map : PictureBox
    {
        public IReadOnlyList<Mark> Marks => marks;
        private List<Mark> marks;

        public Map(Image image)
        {
            Image = image;
            marks = new List<Mark>();
        }

        public void AddMark(Mark mark)
        {
            marks.Add(mark);
            Controls.Add(mark);
        }

        public void RemoveMark(Mark mark)
        {
            marks.Remove(mark);
            Controls.Remove(mark);
        }

        public IEnumerable<Mark> GetMarks()
        {
            foreach (var mark in marks)
                yield return mark;
        }
    }
}
