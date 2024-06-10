namespace Presentacion
{
    partial class game
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
            this.p1_low = new System.Windows.Forms.Button();
            this.p1_medium = new System.Windows.Forms.Button();
            this.p1_high = new System.Windows.Forms.Button();
            this.p2_low = new System.Windows.Forms.Button();
            this.p2_medium = new System.Windows.Forms.Button();
            this.p2_high = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1_low
            // 
            this.p1_low.Location = new System.Drawing.Point(93, 231);
            this.p1_low.Name = "p1_low";
            this.p1_low.Size = new System.Drawing.Size(75, 23);
            this.p1_low.TabIndex = 0;
            this.p1_low.Text = "p1-low";
            this.p1_low.UseVisualStyleBackColor = true;
            this.p1_low.Click += new System.EventHandler(this.p1_low_Click);
            // 
            // p1_medium
            // 
            this.p1_medium.Location = new System.Drawing.Point(174, 231);
            this.p1_medium.Name = "p1_medium";
            this.p1_medium.Size = new System.Drawing.Size(90, 23);
            this.p1_medium.TabIndex = 1;
            this.p1_medium.Text = "p1-medium";
            this.p1_medium.UseVisualStyleBackColor = true;
            this.p1_medium.Click += new System.EventHandler(this.p1_medium_Click);
            // 
            // p1_high
            // 
            this.p1_high.Location = new System.Drawing.Point(270, 232);
            this.p1_high.Name = "p1_high";
            this.p1_high.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p1_high.Size = new System.Drawing.Size(75, 23);
            this.p1_high.TabIndex = 2;
            this.p1_high.Text = "p1-high";
            this.p1_high.UseVisualStyleBackColor = true;
            this.p1_high.Click += new System.EventHandler(this.p1_high_Click);
            // 
            // p2_low
            // 
            this.p2_low.Location = new System.Drawing.Point(524, 231);
            this.p2_low.Name = "p2_low";
            this.p2_low.Size = new System.Drawing.Size(75, 23);
            this.p2_low.TabIndex = 3;
            this.p2_low.Text = "p2-low";
            this.p2_low.UseVisualStyleBackColor = true;
            this.p2_low.Click += new System.EventHandler(this.p2_low_Click);
            // 
            // p2_medium
            // 
            this.p2_medium.Location = new System.Drawing.Point(606, 231);
            this.p2_medium.Name = "p2_medium";
            this.p2_medium.Size = new System.Drawing.Size(75, 23);
            this.p2_medium.TabIndex = 4;
            this.p2_medium.Text = "p2-medium";
            this.p2_medium.UseVisualStyleBackColor = true;
            this.p2_medium.Click += new System.EventHandler(this.p2_medium_Click);
            // 
            // p2_high
            // 
            this.p2_high.Location = new System.Drawing.Point(688, 232);
            this.p2_high.Name = "p2_high";
            this.p2_high.Size = new System.Drawing.Size(75, 23);
            this.p2_high.TabIndex = 5;
            this.p2_high.Text = "p2-high";
            this.p2_high.UseVisualStyleBackColor = true;
            this.p2_high.Click += new System.EventHandler(this.p2_high_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Energia Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Energia Player 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "100";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2_high);
            this.Controls.Add(this.p2_medium);
            this.Controls.Add(this.p2_low);
            this.Controls.Add(this.p1_high);
            this.Controls.Add(this.p1_medium);
            this.Controls.Add(this.p1_low);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1_low;
        private System.Windows.Forms.Button p1_medium;
        private System.Windows.Forms.Button p1_high;
        private System.Windows.Forms.Button p2_low;
        private System.Windows.Forms.Button p2_medium;
        private System.Windows.Forms.Button p2_high;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}