namespace Закупки_Win_Forms
{
    partial class LoginForm
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
            panel1 = new System.Windows.Forms.Panel();
            showPassword = new System.Windows.Forms.Label();
            LogoPictureBox = new System.Windows.Forms.PictureBox();
            buttonLogin = new System.Windows.Forms.Button();
            passField = new System.Windows.Forms.TextBox();
            passwordPictureBox = new System.Windows.Forms.PictureBox();
            loginField = new System.Windows.Forms.TextBox();
            userPictureBox = new System.Windows.Forms.PictureBox();
            loginPanel = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Label();
            headingOfLoginWindow = new System.Windows.Forms.Label();
            registerLabel = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(LogoPictureBox);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(passwordPictureBox);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(userPictureBox);
            panel1.Controls.Add(loginPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(495, 568);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new System.Drawing.Point(3, 461);
            showPassword.Name = "showPassword";
            showPassword.Size = new System.Drawing.Size(98, 15);
            showPassword.TabIndex = 10;
            showPassword.Text = "показать пароль";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = Properties.Resources.logo_marsat;
            LogoPictureBox.Location = new System.Drawing.Point(140, 122);
            LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new System.Drawing.Size(211, 145);
            LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 6;
            LogoPictureBox.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            buttonLogin.Location = new System.Drawing.Point(189, 461);
            buttonLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(135, 54);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            passField.Location = new System.Drawing.Point(96, 384);
            passField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passField.Name = "passField";
            passField.Size = new System.Drawing.Size(384, 47);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources._lock;
            passwordPictureBox.Location = new System.Drawing.Point(14, 384);
            passwordPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new System.Drawing.Size(75, 74);
            passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            passwordPictureBox.TabIndex = 3;
            passwordPictureBox.TabStop = false;
            passwordPictureBox.Click += passwordPictureBox_Click;
            // 
            // loginField
            // 
            loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            loginField.Location = new System.Drawing.Point(96, 303);
            loginField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new System.Drawing.Size(384, 73);
            loginField.TabIndex = 2;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = Properties.Resources.user;
            userPictureBox.Location = new System.Drawing.Point(14, 303);
            userPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new System.Drawing.Size(75, 74);
            userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 1;
            userPictureBox.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = System.Drawing.SystemColors.Highlight;
            loginPanel.Controls.Add(closeButton);
            loginPanel.Controls.Add(headingOfLoginWindow);
            loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            loginPanel.Location = new System.Drawing.Point(0, 0);
            loginPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new System.Drawing.Size(495, 115);
            loginPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.Control;
            closeButton.Location = new System.Drawing.Point(463, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(24, 29);
            closeButton.TabIndex = 1;
            closeButton.Text = "х";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // headingOfLoginWindow
            // 
            headingOfLoginWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            headingOfLoginWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            headingOfLoginWindow.ForeColor = System.Drawing.SystemColors.ControlLight;
            headingOfLoginWindow.Location = new System.Drawing.Point(0, 0);
            headingOfLoginWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            headingOfLoginWindow.Name = "headingOfLoginWindow";
            headingOfLoginWindow.Size = new System.Drawing.Size(495, 115);
            headingOfLoginWindow.TabIndex = 1;
            headingOfLoginWindow.Text = "Авторизация";
            headingOfLoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new System.Drawing.Point(202, 531);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new System.Drawing.Size(107, 15);
            registerLabel.TabIndex = 11;
            registerLabel.Text = "Еще нет аккаунта?";
            registerLabel.Click += registerLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(495, 568);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label headingOfLoginWindow;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label showPassword;
        private System.Windows.Forms.Label registerLabel;
    }
}