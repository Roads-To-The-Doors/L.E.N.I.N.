
namespace L.E.N.I.N
{
    partial class PasswordFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordFrame));
            this.textPassword = new System.Windows.Forms.TextBox();
            this.infoForUser = new System.Windows.Forms.TextBox();
            this.buttonToReturn = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(101, 310);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(279, 26);
            this.textPassword.TabIndex = 1;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // infoForUser
            // 
            this.infoForUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoForUser.Cursor = System.Windows.Forms.Cursors.No;
            this.infoForUser.ForeColor = System.Drawing.Color.Black;
            this.infoForUser.Location = new System.Drawing.Point(12, 12);
            this.infoForUser.Multiline = true;
            this.infoForUser.Name = "infoForUser";
            this.infoForUser.ReadOnly = true;
            this.infoForUser.Size = new System.Drawing.Size(478, 290);
            this.infoForUser.TabIndex = 2;
            this.infoForUser.Text = resources.GetString("infoForUser.Text");
            // 
            // buttonToReturn
            // 
            this.buttonToReturn.Location = new System.Drawing.Point(386, 308);
            this.buttonToReturn.Name = "buttonToReturn";
            this.buttonToReturn.Size = new System.Drawing.Size(104, 29);
            this.buttonToReturn.TabIndex = 3;
            this.buttonToReturn.Text = "Вернуть";
            this.buttonToReturn.UseVisualStyleBackColor = true;
            this.buttonToReturn.Click += new System.EventHandler(this.buttonToReturn_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPass.Location = new System.Drawing.Point(12, 313);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ReadOnly = true;
            this.textBoxPass.Size = new System.Drawing.Size(83, 19);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.Text = "Пароль:";
            // 
            // PasswordFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(502, 344);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonToReturn);
            this.Controls.Add(this.infoForUser);
            this.Controls.Add(this.textPassword);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Red October Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordFrame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внимание!";
            this.Load += new System.EventHandler(this.PasswordFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox infoForUser;
        private System.Windows.Forms.Button buttonToReturn;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}