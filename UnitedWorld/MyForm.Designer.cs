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
            this.map = new Map(global::UnitedWorld.Properties.Resources.map);
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBox
            // 
            this.map.Image = global::UnitedWorld.Properties.Resources.map;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "mapBox";
            this.map.Size = new System.Drawing.Size(1280, 720);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // MyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(map);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.PictureBox map;
        private Map map;
    }
}

