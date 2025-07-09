namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class EditAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdmin));
            TextBoxLogin = new TextBox();
            TextBoxPassword = new TextBox();
            EditButton = new Button();
            LabelPassword = new Label();
            LabelLogin = new Label();
            label1 = new Label();
            SetDefaultButton = new Button();
            SuspendLayout();
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Location = new Point(12, 79);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(208, 23);
            TextBoxLogin.TabIndex = 9;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(238, 79);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(208, 23);
            TextBoxPassword.TabIndex = 8;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Transparent;
            EditButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            EditButton.Font = new Font("Tahoma", 9F);
            EditButton.Location = new Point(275, 222);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(171, 52);
            EditButton.TabIndex = 7;
            EditButton.Text = "Изменить данные";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Tahoma", 9F);
            LabelPassword.Location = new Point(238, 61);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(48, 14);
            LabelPassword.TabIndex = 6;
            LabelPassword.Text = "Пароль";
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.BackColor = Color.Transparent;
            LabelLogin.Font = new Font("Tahoma", 9F);
            LabelLogin.Location = new Point(12, 61);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(41, 14);
            LabelLogin.TabIndex = 5;
            LabelLogin.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(438, 29);
            label1.TabIndex = 10;
            label1.Text = "Изменить параметры администратора";
            // 
            // SetDefaultButton
            // 
            SetDefaultButton.BackColor = Color.Transparent;
            SetDefaultButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            SetDefaultButton.Font = new Font("Tahoma", 9F);
            SetDefaultButton.Location = new Point(12, 222);
            SetDefaultButton.Name = "SetDefaultButton";
            SetDefaultButton.Size = new Size(171, 52);
            SetDefaultButton.TabIndex = 11;
            SetDefaultButton.Text = "Установить стандартные данные";
            SetDefaultButton.UseVisualStyleBackColor = false;
            SetDefaultButton.Click += SetDefaultButton_Click;
            // 
            // EditAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AuthorizationBackground;
            ClientSize = new Size(477, 290);
            Controls.Add(SetDefaultButton);
            Controls.Add(label1);
            Controls.Add(TextBoxLogin);
            Controls.Add(TextBoxPassword);
            Controls.Add(EditButton);
            Controls.Add(LabelPassword);
            Controls.Add(LabelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить параметры администратора";
            Load += EditAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxLogin;
        private TextBox TextBoxPassword;
        private Button EditButton;
        private Label LabelPassword;
        private Label LabelLogin;
        private Label label1;
        private Button SetDefaultButton;
    }
}