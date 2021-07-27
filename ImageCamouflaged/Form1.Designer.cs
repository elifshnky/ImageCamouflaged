namespace ImageCamouflaged
{
    partial class CamouflageWindow
    {

        private System.ComponentModel.IContainer componentsImage = null;

        protected override void Dispose(bool dispos)
        {
            if (dispos && (componentsImage != null))
            {
                componentsImage.Dispose();
            }
            base.Dispose(dispos);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ImageAfter = new System.Windows.Forms.PictureBox();
            this.ImageBefore = new System.Windows.Forms.PictureBox();
            this.btnCamouflaged = new System.Windows.Forms.Button();
            this.beforelabel = new System.Windows.Forms.Label();
            this.afterlabel = new System.Windows.Forms.Label();
            this.messagelabel = new System.Windows.Forms.Label();
            this.ImageGrey = new System.Windows.Forms.PictureBox();
            this.greylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGrey)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageAfter
            // 
            this.ImageAfter.BackColor = System.Drawing.Color.Orange;
            this.ImageAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageAfter.Location = new System.Drawing.Point(462, 86);
            this.ImageAfter.Margin = new System.Windows.Forms.Padding(2);
            this.ImageAfter.Name = "ImageAfter";
            this.ImageAfter.Size = new System.Drawing.Size(436, 421);
            this.ImageAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageAfter.TabIndex = 7;
            this.ImageAfter.TabStop = false;
            // 
            // ImageBefore
            // 
            this.ImageBefore.BackColor = System.Drawing.Color.SlateBlue;
            this.ImageBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBefore.Location = new System.Drawing.Point(22, 86);
            this.ImageBefore.Margin = new System.Windows.Forms.Padding(2);
            this.ImageBefore.Name = "ImageBefore";
            this.ImageBefore.Size = new System.Drawing.Size(436, 421);
            this.ImageBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBefore.TabIndex = 4;
            this.ImageBefore.TabStop = false;
            // 
            // ImageGrey
            // 
            this.ImageGrey.BackColor = System.Drawing.Color.Silver;
            this.ImageGrey.Location = new System.Drawing.Point(903, 86);
            this.ImageGrey.Name = "p2";
            this.ImageGrey.Size = new System.Drawing.Size(436, 421);
            this.ImageGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageGrey.TabIndex = 11;
            this.ImageGrey.TabStop = false;
            // 
            // btnCamouflaged
            // 
            this.btnCamouflaged.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCamouflaged.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCamouflaged.FlatAppearance.BorderSize = 4;
            this.btnCamouflaged.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnCamouflaged.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCamouflaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamouflaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamouflaged.ForeColor = System.Drawing.Color.Indigo;
            this.btnCamouflaged.Location = new System.Drawing.Point(499, 522);
            this.btnCamouflaged.Margin = new System.Windows.Forms.Padding(2);
            this.btnCamouflaged.Name = "btnCamouflaged";
            this.btnCamouflaged.Size = new System.Drawing.Size(357, 68);
            this.btnCamouflaged.TabIndex = 5;
            this.btnCamouflaged.Text = "Camouflage the picture";
            this.btnCamouflaged.UseVisualStyleBackColor = false;
            this.btnCamouflaged.Click += new System.EventHandler(this.ButtonClickfile);
            // 
            // beforelabel
            // 
            this.beforelabel.AutoSize = true;
            this.beforelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beforelabel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.beforelabel.Location = new System.Drawing.Point(171, 48);
            this.beforelabel.Name = "beforelabel";
            this.beforelabel.Size = new System.Drawing.Size(112, 36);
            this.beforelabel.TabIndex = 8;
            this.beforelabel.Text = "-Before";
            // 
            // afterlabel
            // 
            this.afterlabel.AutoSize = true;
            this.afterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afterlabel.ForeColor = System.Drawing.Color.Orange;
            this.afterlabel.Location = new System.Drawing.Point(617, 48);
            this.afterlabel.Name = "afterlabel";
            this.afterlabel.Size = new System.Drawing.Size(95, 36);
            this.afterlabel.TabIndex = 9;
            this.afterlabel.Text = "+After";
            // 
            // greylabel
            // 
            this.greylabel.AutoSize = true;
            this.greylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.greylabel.ForeColor = System.Drawing.Color.Gray;
            this.greylabel.Location = new System.Drawing.Point(1078, 47);
            this.greylabel.Name = "label1";
            this.greylabel.Size = new System.Drawing.Size(96, 36);
            this.greylabel.TabIndex = 12;
            this.greylabel.Text = "#Grey";
            // 
            // messagelabel
            // 
            this.messagelabel.AutoSize = true;
            this.messagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagelabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.messagelabel.Location = new System.Drawing.Point(514, 601);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(0, 20);
            this.messagelabel.TabIndex = 10;
            // 
            // CamouflageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1361, 645);
            this.Controls.Add(this.greylabel);
            this.Controls.Add(this.ImageGrey);
            this.Controls.Add(this.messagelabel);
            this.Controls.Add(this.afterlabel);
            this.Controls.Add(this.beforelabel);
            this.Controls.Add(this.ImageAfter);
            this.Controls.Add(this.btnCamouflaged);
            this.Controls.Add(this.ImageBefore);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CamouflageWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamouflageWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGrey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageAfter;
        private System.Windows.Forms.PictureBox ImageBefore;
        private System.Windows.Forms.PictureBox ImageGrey;
        private System.Windows.Forms.Button btnCamouflaged;
        private System.Windows.Forms.Label beforelabel;
        private System.Windows.Forms.Label afterlabel;
        private System.Windows.Forms.Label greylabel;
        private System.Windows.Forms.Label messagelabel;
        
    }
}

