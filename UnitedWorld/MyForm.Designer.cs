using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace UnitedWorld
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBox
            // 
            this.mapBox.Image = global::UnitedWorld.Properties.Resources.map;
            this.mapBox.Location = new System.Drawing.Point(0, 0);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(1280, 720);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            // 
            // MyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mapBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapBox;
    }
}

