
namespace L.E.N.I.N
{
    partial class falsePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(falsePass));
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.Control;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Location = new System.Drawing.Point(12, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.infoBox.Size = new System.Drawing.Size(451, 449);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "";
            // 
            // falsePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 473);
            this.Controls.Add(this.infoBox);
            this.Font = new System.Drawing.Font("Red October Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "falsePass";
            this.Text = "Неверный пароль!";
            this.Load += new System.EventHandler(this.falsePass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoBox;
    }
}