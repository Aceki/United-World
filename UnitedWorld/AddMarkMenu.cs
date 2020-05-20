using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedWorld
{
    public partial class AddMarkMenu : Form
    {
        private Image choosenImage;

        public AddMarkMenu()
        {
            InitializeComponent();
        }

        public Mark GetMark()
        {
            var markData = new MarkData()
            {
                Name = nameBox.Text,
                Description = descBox.Text,
            };
            var mark = new Mark(markData, choosenImage);
            return mark;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            choosenImage = pictureBox1.Image;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            choosenImage = pictureBox2.Image;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            choosenImage = pictureBox3.Image;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            choosenImage = pictureBox4.Image;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void succesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
