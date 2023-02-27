namespace PSVITA_VPK_MAKER
{
    partial class Acerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca));
            this.Acercatxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Acercatxt
            // 
            this.Acercatxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Acercatxt.Location = new System.Drawing.Point(25, 30);
            this.Acercatxt.Multiline = true;
            this.Acercatxt.Name = "Acercatxt";
            this.Acercatxt.ReadOnly = true;
            this.Acercatxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Acercatxt.Size = new System.Drawing.Size(470, 265);
            this.Acercatxt.TabIndex = 0;
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 326);
            this.Controls.Add(this.Acercatxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Acerca";
            this.Text = "Acerca de..";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Acerca_FormClosed);
            this.Load += new System.EventHandler(this.Acerca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Acercatxt;
    }
}