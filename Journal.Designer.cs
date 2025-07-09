namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            dataGridView1 = new DataGridView();
            AddStudentButton = new Button();
            EditStudentButton = new Button();
            EditStudentTextBox = new TextBox();
            DeleteStudentButton = new Button();
            ManageGroupsButton = new Button();
            ManageSpecialtyButton = new Button();
            ManageTutorsButton = new Button();
            DeleteStudentTextBox = new TextBox();
            SortComboBox = new ComboBox();
            SortButton = new Button();
            RefreshButton = new Button();
            SortButtonUp = new Button();
            SortButtonDown = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            editEmployeeButton = new Button();
            ChangeLoginOrPasswordAdmin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1018, 497);
            dataGridView1.TabIndex = 1;
            // 
            // AddStudentButton
            // 
            AddStudentButton.BackColor = Color.Transparent;
            AddStudentButton.BackgroundImage = Properties.Resources.ButtonsImage;
            AddStudentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddStudentButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddStudentButton.Location = new Point(1034, 61);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(152, 46);
            AddStudentButton.TabIndex = 2;
            AddStudentButton.Text = "Добавить студента";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += button1_Click;
            // 
            // EditStudentButton
            // 
            EditStudentButton.BackColor = Color.Transparent;
            EditStudentButton.BackgroundImage = Properties.Resources.ButtonsImage;
            EditStudentButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditStudentButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditStudentButton.Location = new Point(1034, 113);
            EditStudentButton.Name = "EditStudentButton";
            EditStudentButton.Size = new Size(106, 46);
            EditStudentButton.TabIndex = 3;
            EditStudentButton.Text = "Редактировать студента";
            EditStudentButton.UseVisualStyleBackColor = false;
            EditStudentButton.Click += EditStudentButton_Click;
            // 
            // EditStudentTextBox
            // 
            EditStudentTextBox.Location = new Point(1162, 126);
            EditStudentTextBox.Name = "EditStudentTextBox";
            EditStudentTextBox.Size = new Size(30, 23);
            EditStudentTextBox.TabIndex = 4;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.BackColor = Color.Transparent;
            DeleteStudentButton.BackgroundImage = Properties.Resources.ButtonsImage;
            DeleteStudentButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteStudentButton.Font = new Font("Tahoma", 9F);
            DeleteStudentButton.Location = new Point(1034, 165);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(106, 46);
            DeleteStudentButton.TabIndex = 5;
            DeleteStudentButton.Text = "Удалить студента";
            DeleteStudentButton.UseVisualStyleBackColor = false;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // ManageGroupsButton
            // 
            ManageGroupsButton.BackColor = Color.Transparent;
            ManageGroupsButton.BackgroundImage = Properties.Resources.ButtonsImage;
            ManageGroupsButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageGroupsButton.Font = new Font("Tahoma", 9F);
            ManageGroupsButton.Location = new Point(2, 3);
            ManageGroupsButton.Name = "ManageGroupsButton";
            ManageGroupsButton.Size = new Size(152, 46);
            ManageGroupsButton.TabIndex = 6;
            ManageGroupsButton.Text = "Управление группами";
            ManageGroupsButton.UseVisualStyleBackColor = false;
            ManageGroupsButton.Click += ManageGroupsButton_Click;
            // 
            // ManageSpecialtyButton
            // 
            ManageSpecialtyButton.BackColor = Color.Transparent;
            ManageSpecialtyButton.BackgroundImage = Properties.Resources.ButtonsImage;
            ManageSpecialtyButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageSpecialtyButton.Font = new Font("Tahoma", 9F);
            ManageSpecialtyButton.Location = new Point(160, 3);
            ManageSpecialtyButton.Name = "ManageSpecialtyButton";
            ManageSpecialtyButton.Size = new Size(152, 46);
            ManageSpecialtyButton.TabIndex = 7;
            ManageSpecialtyButton.Text = "Управление специальностями";
            ManageSpecialtyButton.UseVisualStyleBackColor = false;
            ManageSpecialtyButton.Click += ManageSpecialtyButton_Click;
            // 
            // ManageTutorsButton
            // 
            ManageTutorsButton.BackColor = Color.Transparent;
            ManageTutorsButton.BackgroundImage = Properties.Resources.ButtonsImage;
            ManageTutorsButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageTutorsButton.Font = new Font("Tahoma", 9F);
            ManageTutorsButton.Location = new Point(318, 3);
            ManageTutorsButton.Name = "ManageTutorsButton";
            ManageTutorsButton.Size = new Size(152, 46);
            ManageTutorsButton.TabIndex = 8;
            ManageTutorsButton.Text = "Управление руководителями групп";
            ManageTutorsButton.UseVisualStyleBackColor = false;
            ManageTutorsButton.Click += ManageTutorsButton_Click;
            // 
            // DeleteStudentTextBox
            // 
            DeleteStudentTextBox.Location = new Point(1162, 178);
            DeleteStudentTextBox.Name = "DeleteStudentTextBox";
            DeleteStudentTextBox.Size = new Size(30, 23);
            DeleteStudentTextBox.TabIndex = 9;
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(14, 152);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(121, 23);
            SortComboBox.TabIndex = 10;
            // 
            // SortButton
            // 
            SortButton.BackColor = Color.Transparent;
            SortButton.BackgroundImage = Properties.Resources.ButtonsImage;
            SortButton.BackgroundImageLayout = ImageLayout.Stretch;
            SortButton.Font = new Font("Tahoma", 9F);
            SortButton.Location = new Point(3, 100);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(152, 46);
            SortButton.TabIndex = 11;
            SortButton.Text = "Отсортировать по группе";
            SortButton.UseVisualStyleBackColor = false;
            SortButton.Click += SortButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.Transparent;
            RefreshButton.BackgroundImage = Properties.Resources.ButtonsImage;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.Font = new Font("Tahoma", 9F);
            RefreshButton.Location = new Point(1034, 471);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(152, 46);
            RefreshButton.TabIndex = 12;
            RefreshButton.Text = "Обновить таблицу";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SortButtonUp
            // 
            SortButtonUp.BackColor = Color.Transparent;
            SortButtonUp.BackgroundImage = Properties.Resources.ButtonsImage;
            SortButtonUp.BackgroundImageLayout = ImageLayout.Stretch;
            SortButtonUp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortButtonUp.Location = new Point(14, 50);
            SortButtonUp.Name = "SortButtonUp";
            SortButtonUp.Size = new Size(49, 44);
            SortButtonUp.TabIndex = 13;
            SortButtonUp.Text = "▲";
            SortButtonUp.UseVisualStyleBackColor = false;
            SortButtonUp.Click += SortButtonUp_Click;
            // 
            // SortButtonDown
            // 
            SortButtonDown.BackColor = Color.Transparent;
            SortButtonDown.BackgroundImage = Properties.Resources.ButtonsImage;
            SortButtonDown.BackgroundImageLayout = ImageLayout.Stretch;
            SortButtonDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortButtonDown.Location = new Point(86, 50);
            SortButtonDown.Name = "SortButtonDown";
            SortButtonDown.Size = new Size(49, 44);
            SortButtonDown.TabIndex = 14;
            SortButtonDown.Text = "▼";
            SortButtonDown.UseVisualStyleBackColor = false;
            SortButtonDown.Click += SortButtonDown_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 15;
            label1.Text = "Сортировка";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImage = Properties.Resources.PanelsImage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SortButtonDown);
            panel1.Controls.Add(SortButtonUp);
            panel1.Controls.Add(SortButton);
            panel1.Controls.Add(SortComboBox);
            panel1.Location = new Point(1034, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 228);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImage = Properties.Resources.PanelsImage;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(editEmployeeButton);
            panel2.Controls.Add(ChangeLoginOrPasswordAdmin);
            panel2.Controls.Add(ManageTutorsButton);
            panel2.Controls.Add(ManageSpecialtyButton);
            panel2.Controls.Add(ManageGroupsButton);
            panel2.Location = new Point(10, 536);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 131);
            panel2.TabIndex = 17;
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.BackColor = Color.Transparent;
            editEmployeeButton.BackgroundImage = Properties.Resources.ButtonsImage;
            editEmployeeButton.BackgroundImageLayout = ImageLayout.Stretch;
            editEmployeeButton.Font = new Font("Tahoma", 9F);
            editEmployeeButton.Location = new Point(3, 55);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(152, 46);
            editEmployeeButton.TabIndex = 21;
            editEmployeeButton.Text = "Изменить логин или пароль сотрудника";
            editEmployeeButton.UseVisualStyleBackColor = false;
            editEmployeeButton.Click += editEmployeeButton_Click;
            // 
            // ChangeLoginOrPasswordAdmin
            // 
            ChangeLoginOrPasswordAdmin.BackColor = Color.Transparent;
            ChangeLoginOrPasswordAdmin.BackgroundImage = Properties.Resources.ButtonsImage;
            ChangeLoginOrPasswordAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeLoginOrPasswordAdmin.Font = new Font("Tahoma", 9F);
            ChangeLoginOrPasswordAdmin.Location = new Point(476, 3);
            ChangeLoginOrPasswordAdmin.Name = "ChangeLoginOrPasswordAdmin";
            ChangeLoginOrPasswordAdmin.Size = new Size(152, 46);
            ChangeLoginOrPasswordAdmin.TabIndex = 20;
            ChangeLoginOrPasswordAdmin.Text = "Изменить логин или пароль администратора";
            ChangeLoginOrPasswordAdmin.UseVisualStyleBackColor = false;
            ChangeLoginOrPasswordAdmin.Visible = false;
            ChangeLoginOrPasswordAdmin.Click += ChangeLoginOrPasswordAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 1);
            label2.Name = "label2";
            label2.Size = new Size(294, 29);
            label2.TabIndex = 16;
            label2.Text = "Учет студентов - Журнал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(1146, 129);
            label3.Name = "label3";
            label3.Size = new Size(16, 14);
            label3.TabIndex = 18;
            label3.Text = "id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(1146, 181);
            label4.Name = "label4";
            label4.Size = new Size(16, 14);
            label4.TabIndex = 19;
            label4.Text = "id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(661, 539);
            label5.Name = "label5";
            label5.Size = new Size(96, 14);
            label5.TabIndex = 20;
            label5.Text = "Найти студента";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(661, 556);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(203, 23);
            searchTextBox.TabIndex = 21;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = Properties.Resources.ButtonsImage;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Font = new Font("Tahoma", 9F);
            searchButton.Location = new Point(870, 543);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 46);
            searchButton.TabIndex = 22;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1198, 669);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteStudentTextBox);
            Controls.Add(DeleteStudentButton);
            Controls.Add(EditStudentTextBox);
            Controls.Add(EditStudentButton);
            Controls.Add(AddStudentButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Journal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет студентов - Журнал";
            FormClosing += Journal_FormClosing;
            Load += Journal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddStudentButton;
        private Button EditStudentButton;
        private TextBox EditStudentTextBox;
        private Button DeleteStudentButton;
        private Button ManageGroupsButton;
        private Button ManageSpecialtyButton;
        private Button ManageTutorsButton;
        private TextBox DeleteStudentTextBox;
        private ComboBox SortComboBox;
        private Button SortButton;
        private Button RefreshButton;
        private Button SortButtonUp;
        private Button SortButtonDown;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ChangeLoginOrPasswordAdmin;
        private Label label5;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button editEmployeeButton;
    }
}