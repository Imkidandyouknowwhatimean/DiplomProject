namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class EditGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroup));
            ClearButton = new Button();
            AddGroupButton = new Button();
            DateTextBox = new TextBox();
            CodeTextBox = new TextBox();
            NameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TutorComboBox = new ComboBox();
            SpecialtyComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Transparent;
            ClearButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            ClearButton.Font = new Font("Tahoma", 9F);
            ClearButton.Location = new Point(201, 257);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 49);
            ClearButton.TabIndex = 52;
            ClearButton.Text = "Очистить поля";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddGroupButton
            // 
            AddGroupButton.BackColor = Color.Transparent;
            AddGroupButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            AddGroupButton.Font = new Font("Tahoma", 9F);
            AddGroupButton.Location = new Point(324, 257);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(165, 49);
            AddGroupButton.TabIndex = 51;
            AddGroupButton.Text = "Отредактирвоать группу";
            AddGroupButton.UseVisualStyleBackColor = false;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(311, 83);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(132, 23);
            DateTextBox.TabIndex = 48;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(162, 83);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(132, 23);
            CodeTextBox.TabIndex = 47;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 83);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(132, 23);
            NameTextBox.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(159, 129);
            label6.Name = "label6";
            label6.Size = new Size(93, 14);
            label6.TabIndex = 45;
            label6.Text = "Специальность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(100, 14);
            label5.TabIndex = 44;
            label5.Text = "id руководителя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(311, 65);
            label4.Name = "label4";
            label4.Size = new Size(89, 14);
            label4.TabIndex = 43;
            label4.Text = "Дата создания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(157, 65);
            label3.Name = "label3";
            label3.Size = new Size(72, 14);
            label3.TabIndex = 42;
            label3.Text = "Код группы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(131, 14);
            label2.TabIndex = 41;
            label2.Text = "Короткое имя группы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 29);
            label1.TabIndex = 40;
            label1.Text = "Редактировать группу";
            // 
            // TutorComboBox
            // 
            TutorComboBox.FlatStyle = FlatStyle.System;
            TutorComboBox.FormattingEnabled = true;
            TutorComboBox.Location = new Point(12, 147);
            TutorComboBox.Name = "TutorComboBox";
            TutorComboBox.Size = new Size(132, 23);
            TutorComboBox.TabIndex = 53;
            // 
            // SpecialtyComboBox
            // 
            SpecialtyComboBox.FlatStyle = FlatStyle.System;
            SpecialtyComboBox.FormattingEnabled = true;
            SpecialtyComboBox.Location = new Point(162, 147);
            SpecialtyComboBox.Name = "SpecialtyComboBox";
            SpecialtyComboBox.Size = new Size(132, 23);
            SpecialtyComboBox.TabIndex = 54;
            // 
            // EditGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AuthorizationBackground;
            ClientSize = new Size(508, 321);
            Controls.Add(SpecialtyComboBox);
            Controls.Add(TutorComboBox);
            Controls.Add(ClearButton);
            Controls.Add(AddGroupButton);
            Controls.Add(DateTextBox);
            Controls.Add(CodeTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать группу";
            FormClosing += EditGroup_FormClosing;
            Load += EditGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button AddGroupButton;
        private TextBox DateTextBox;
        private TextBox CodeTextBox;
        private TextBox NameTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox TutorComboBox;
        private ComboBox SpecialtyComboBox;
    }
}