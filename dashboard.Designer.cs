
namespace KemasProject
{
    partial class dashboard
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
            this.panelSide = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelCenter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.btnUser);
            this.panelSide.Controls.Add(this.btnRole);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.FillColor = System.Drawing.Color.SteelBlue;
            this.panelSide.FillColor3 = System.Drawing.Color.LightSkyBlue;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(118, 556);
            this.panelSide.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(118, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(682, 62);
            this.panelTop.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.FillColor4 = System.Drawing.Color.SkyBlue;
            this.panelCenter.Location = new System.Drawing.Point(118, 62);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(682, 494);
            this.panelCenter.TabIndex = 2;
            // 
            // btnRole
            // 
            this.btnRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRole.FillColor = System.Drawing.Color.White;
            this.btnRole.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.Color.Black;
            this.btnRole.Location = new System.Drawing.Point(9, 95);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(100, 25);
            this.btnRole.TabIndex = 0;
            this.btnRole.Text = "ROLE";
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnUser
            // 
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(9, 133);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 25);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "USER";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSide);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelSide;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnRole;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTop;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelCenter;
    }
}