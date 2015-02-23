namespace Dominion
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.CreditsPicture = new System.Windows.Forms.PictureBox();
            this.ButtonLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditsPicture
            // 
            this.CreditsPicture.Image = ((System.Drawing.Image)(resources.GetObject("CreditsPicture.Image")));
            this.CreditsPicture.Location = new System.Drawing.Point(1, 0);
            this.CreditsPicture.Name = "CreditsPicture";
            this.CreditsPicture.Size = new System.Drawing.Size(483, 461);
            this.CreditsPicture.TabIndex = 0;
            this.CreditsPicture.TabStop = false;
            // 
            // ButtonLink
            // 
            this.ButtonLink.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLink.BackgroundImage = global::Dominion.Properties.Resources.DCG_Credits_Link;
            this.ButtonLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLink.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonLink.Location = new System.Drawing.Point(212, 424);
            this.ButtonLink.Name = "ButtonLink";
            this.ButtonLink.Size = new System.Drawing.Size(261, 29);
            this.ButtonLink.TabIndex = 1;
            this.ButtonLink.UseVisualStyleBackColor = false;
            this.ButtonLink.Click += new System.EventHandler(this.ButtonLink_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.ButtonLink);
            this.Controls.Add(this.CreditsPicture);
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CreditsPicture;
        private System.Windows.Forms.Button ButtonLink;


    }
}