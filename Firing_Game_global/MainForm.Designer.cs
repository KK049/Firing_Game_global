namespace Firing_Game_global
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnFireAway = new System.Windows.Forms.Button();
            this.pbBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(38, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Game Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoad.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(226, 120);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(185, 64);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Gun";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSpin.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpin.Location = new System.Drawing.Point(293, 227);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(185, 64);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin Gun";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFire.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFire.Location = new System.Drawing.Point(502, 305);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(185, 64);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire Gun";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnFireAway
            // 
            this.btnFireAway.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFireAway.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireAway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFireAway.Location = new System.Drawing.Point(691, 392);
            this.btnFireAway.Name = "btnFireAway";
            this.btnFireAway.Size = new System.Drawing.Size(185, 64);
            this.btnFireAway.TabIndex = 4;
            this.btnFireAway.Text = "Fire Away";
            this.btnFireAway.UseVisualStyleBackColor = false;
            this.btnFireAway.Click += new System.EventHandler(this.btnFireAway_Click);
            // 
            // pbBox
            // 
            this.pbBox.Location = new System.Drawing.Point(569, 12);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(354, 252);
            this.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBox.TabIndex = 5;
            this.pbBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Firing_Game_global.Properties.Resources.sd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 468);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.btnFireAway);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "+";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnFireAway;
        private System.Windows.Forms.PictureBox pbBox;
    }
}