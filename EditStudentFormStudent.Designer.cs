namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class EditStudentFormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentFormStudent));
            ClearButton = new Button();
            AddStudentButton = new Button();
            PasswordTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            PatronymicTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Transparent;
            ClearButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            ClearButton.BackgroundImageLayout = ImageLayout.Center;
            ClearButton.Font = new Font("Tahoma", 9F);
            ClearButton.Location = new Point(337, 280);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 49);
            ClearButton.TabIndex = 80;
            ClearButton.Text = "Очистить поля";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.BackColor = Color.Transparent;
            AddStudentButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            AddStudentButton.BackgroundImageLayout = ImageLayout.Center;
            AddStudentButton.Font = new Font("Tahoma", 9F);
            AddStudentButton.Location = new Point(460, 280);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(165, 49);
            AddStudentButton.TabIndex = 79;
            AddStudentButton.Text = "Отредактирвоать студента";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 168);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(132, 23);
            PasswordTextBox.TabIndex = 76;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(162, 168);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(132, 23);
            AddressTextBox.TabIndex = 75;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(459, 83);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(132, 23);
            PhoneTextBox.TabIndex = 70;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress_1;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(311, 83);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(132, 23);
            PatronymicTextBox.TabIndex = 69;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(162, 83);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(132, 23);
            SurnameTextBox.TabIndex = 68;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 83);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(132, 23);
            NameTextBox.TabIndex = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 9F);
            label12.Location = new Point(12, 150);
            label12.Name = "label12";
            label12.Size = new Size(48, 14);
            label12.TabIndex = 65;
            label12.Text = "Пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 9F);
            label8.Location = new Point(162, 150);
            label8.Name = "label8";
            label8.Size = new Size(117, 14);
            label8.TabIndex = 61;
            label8.Text = "Адрес проживания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(459, 65);
            label5.Name = "label5";
            label5.Size = new Size(105, 14);
            label5.TabIndex = 58;
            label5.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(311, 65);
            label4.Name = "label4";
            label4.Size = new Size(116, 14);
            label4.TabIndex = 57;
            label4.Text = "Отчество студента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(162, 65);
            label3.Name = "label3";
            label3.Size = new Size(114, 14);
            label3.TabIndex = 56;
            label3.Text = "Фамилия студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(85, 14);
            label2.TabIndex = 55;
            label2.Text = "Имя студента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(283, 29);
            label1.TabIndex = 54;
            label1.Text = "Редактировать студента";
            // 
            // EditStudentFormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AuthorizationBackground;
            ClientSize = new Size(637, 341);
            Controls.Add(ClearButton);
            Controls.Add(AddStudentButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(PatronymicTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditStudentFormStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать студента";
            FormClosing += EditStudentFormStudent_FormClosing;
            Load += EditStudentFormStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button AddStudentButton;
        private TextBox PasswordTextBox;
        private TextBox AddressTextBox;
        private TextBox PhoneTextBox;
        private TextBox PatronymicTextBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label label12;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}