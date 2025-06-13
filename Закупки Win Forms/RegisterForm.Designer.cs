namespace Закупки_Win_Forms
{
    partial class RegisterForm
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
            autorisationLabel = new System.Windows.Forms.Label();
            showPassword = new System.Windows.Forms.Label();
            userSurnameField = new System.Windows.Forms.TextBox();
            userNameField = new System.Windows.Forms.TextBox();
            LogoPictureBox = new System.Windows.Forms.PictureBox();
            buttonRegister = new System.Windows.Forms.Button();
            passField = new System.Windows.Forms.TextBox();
            passwordPictureBox = new System.Windows.Forms.PictureBox();
            loginField = new System.Windows.Forms.TextBox();
            userPictureBox = new System.Windows.Forms.PictureBox();
            loginPanel = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Label();
            headingOfLoginWindow = new System.Windows.Forms.Label();
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
            panel1.Controls.Add(autorisationLabel);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(LogoPictureBox);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(passwordPictureBox);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(userPictureBox);
            panel1.Controls.Add(loginPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1026, 782);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // autorisationLabel
            // 
            autorisationLabel.AutoSize = true;
            autorisationLabel.Location = new System.Drawing.Point(468, 743);
            autorisationLabel.Name = "autorisationLabel";
            autorisationLabel.Size = new System.Drawing.Size(94, 15);
            autorisationLabel.TabIndex = 12;
            autorisationLabel.Text = "Авторизоваться";
            autorisationLabel.Click += autorisationLabel_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new System.Drawing.Point(514, 641);
            showPassword.Name = "showPassword";
            showPassword.Size = new System.Drawing.Size(98, 15);
            showPassword.TabIndex = 9;
            showPassword.Text = "показать пароль";
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            userSurnameField.Location = new System.Drawing.Point(608, 453);
            userSurnameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new System.Drawing.Size(384, 73);
            userSurnameField.TabIndex = 8;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            userNameField.Location = new System.Drawing.Point(106, 453);
            userNameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new System.Drawing.Size(384, 73);
            userNameField.TabIndex = 7;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = Properties.Resources.logo_marsat;
            LogoPictureBox.Location = new System.Drawing.Point(401, 121);
            LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new System.Drawing.Size(211, 145);
            LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 6;
            LogoPictureBox.TabStop = false;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            buttonRegister.Location = new System.Drawing.Point(386, 686);
            buttonRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new System.Drawing.Size(255, 54);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрировать";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            passField.Location = new System.Drawing.Point(608, 564);
            passField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passField.Name = "passField";
            passField.Size = new System.Drawing.Size(384, 47);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources._lock;
            passwordPictureBox.Location = new System.Drawing.Point(526, 564);
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
            loginField.Location = new System.Drawing.Point(107, 564);
            loginField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new System.Drawing.Size(384, 73);
            loginField.TabIndex = 2;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = Properties.Resources.user;
            userPictureBox.Location = new System.Drawing.Point(24, 564);
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
            loginPanel.Size = new System.Drawing.Size(1026, 115);
            loginPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.Control;
            closeButton.Location = new System.Drawing.Point(1002, 0);
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
            headingOfLoginWindow.Size = new System.Drawing.Size(1026, 115);
            headingOfLoginWindow.TabIndex = 1;
            headingOfLoginWindow.Text = "Регистрация";
            headingOfLoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1026, 782);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
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
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label headingOfLoginWindow;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label showPassword;
        private System.Windows.Forms.Label autorisationLabel;
    }
}