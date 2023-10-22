namespace PongGame
{
    partial class Characterform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Characterform));
            this.character1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.character3 = new System.Windows.Forms.PictureBox();
            this.character2 = new System.Windows.Forms.PictureBox();
            this.charater4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.character1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charater4)).BeginInit();
            this.SuspendLayout();
            // 
            // character1
            // 
            this.character1.Image = ((System.Drawing.Image)(resources.GetObject("character1.Image")));
            this.character1.Location = new System.Drawing.Point(31, 174);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(109, 102);
            this.character1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character1.TabIndex = 0;
            this.character1.TabStop = false;
            this.character1.Click += new System.EventHandler(this.character1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a character";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // character3
            // 
            this.character3.Image = ((System.Drawing.Image)(resources.GetObject("character3.Image")));
            this.character3.Location = new System.Drawing.Point(428, 174);
            this.character3.Name = "character3";
            this.character3.Size = new System.Drawing.Size(109, 102);
            this.character3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character3.TabIndex = 2;
            this.character3.TabStop = false;
            this.character3.Click += new System.EventHandler(this.character3_Click);
            // 
            // character2
            // 
            this.character2.Image = ((System.Drawing.Image)(resources.GetObject("character2.Image")));
            this.character2.Location = new System.Drawing.Point(224, 174);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(109, 102);
            this.character2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character2.TabIndex = 3;
            this.character2.TabStop = false;
            this.character2.Click += new System.EventHandler(this.character2_Click);
            // 
            // charater4
            // 
            this.charater4.Image = ((System.Drawing.Image)(resources.GetObject("charater4.Image")));
            this.charater4.Location = new System.Drawing.Point(642, 174);
            this.charater4.Name = "charater4";
            this.charater4.Size = new System.Drawing.Size(109, 102);
            this.charater4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.charater4.TabIndex = 4;
            this.charater4.TabStop = false;
            this.charater4.Click += new System.EventHandler(this.charater4_Click);
            // 
            // Characterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charater4);
            this.Controls.Add(this.character2);
            this.Controls.Add(this.character3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.character1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Characterform";
            this.Text = "Choose a character";
            ((System.ComponentModel.ISupportInitialize)(this.character1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charater4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox character1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox character3;
        private System.Windows.Forms.PictureBox character2;
        private System.Windows.Forms.PictureBox charater4;
    }
}