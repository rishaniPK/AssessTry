namespace AssessTry
{
    partial class Form1
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.btn_palyagain = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(118, 57);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(118, 107);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(75, 23);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.Btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Location = new System.Drawing.Point(118, 163);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(75, 23);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.Btn_shoot_Click);
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.Location = new System.Drawing.Point(118, 215);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(75, 23);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "Shoot away";
            this.btn_shootaway.UseVisualStyleBackColor = true;
            this.btn_shootaway.Click += new System.EventHandler(this.Btn_shootaway_Click);
            // 
            // btn_palyagain
            // 
            this.btn_palyagain.Location = new System.Drawing.Point(118, 261);
            this.btn_palyagain.Name = "btn_palyagain";
            this.btn_palyagain.Size = new System.Drawing.Size(75, 23);
            this.btn_palyagain.TabIndex = 4;
            this.btn_palyagain.Text = "Play Again";
            this.btn_palyagain.UseVisualStyleBackColor = true;
            this.btn_palyagain.Click += new System.EventHandler(this.Btn_palyagain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AssessTry.Reso1.download;
            this.pictureBox1.Location = new System.Drawing.Point(224, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 227);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_palyagain);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.Button btn_palyagain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

