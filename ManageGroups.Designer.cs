namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class ManageGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroups));
            panel1 = new Panel();
            label5 = new Label();
            SortDownButton = new Button();
            SortUpButton = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            DeleteGroupTextBox = new TextBox();
            DeleteGroupButton = new Button();
            EditGroupTextBox = new TextBox();
            EditGroupButton = new Button();
            AddGroupButton = new Button();
            dataGridView1 = new DataGridView();
            RefreshButton = new Button();
            DeleteGroupAndStudentsButton = new Button();
            label1 = new Label();
            DeleteGroupAndStudentsTextBox = new TextBox();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImage = Properties.Resources.PanelsImage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SortDownButton);
            panel1.Controls.Add(SortUpButton);
            panel1.Location = new Point(730, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 126);
            panel1.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(142, 29);
            label5.TabIndex = 15;
            label5.Text = "Сортировка";
            // 
            // SortDownButton
            // 
            SortDownButton.BackColor = Color.Transparent;
            SortDownButton.BackgroundImage = Properties.Resources.ButtonsImage;
            SortDownButton.BackgroundImageLayout = ImageLayout.Stretch;
            SortDownButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortDownButton.Location = new Point(86, 50);
            SortDownButton.Name = "SortDownButton";
            SortDownButton.Size = new Size(49, 44);
            SortDownButton.TabIndex = 14;
            SortDownButton.Text = "▼";
            SortDownButton.UseVisualStyleBackColor = false;
            SortDownButton.Click += SortDownButton_Click;
            // 
            // SortUpButton
            // 
            SortUpButton.BackColor = Color.Transparent;
            SortUpButton.BackgroundImage = Properties.Resources.ButtonsImage;
            SortUpButton.BackgroundImageLayout = ImageLayout.Stretch;
            SortUpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortUpButton.Location = new Point(14, 50);
            SortUpButton.Name = "SortUpButton";
            SortUpButton.Size = new Size(49, 44);
            SortUpButton.TabIndex = 13;
            SortUpButton.Text = "▲";
            SortUpButton.UseVisualStyleBackColor = false;
            SortUpButton.Click += SortUpButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(260, 29);
            label2.TabIndex = 50;
            label2.Text = "Управление группами";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 8.25F);
            label4.Location = new Point(833, 164);
            label4.Name = "label4";
            label4.Size = new Size(15, 13);
            label4.TabIndex = 49;
            label4.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 8.25F);
            label3.Location = new Point(833, 112);
            label3.Name = "label3";
            label3.Size = new Size(15, 13);
            label3.TabIndex = 48;
            label3.Text = "id";
            // 
            // DeleteGroupTextBox
            // 
            DeleteGroupTextBox.Location = new Point(849, 161);
            DeleteGroupTextBox.Name = "DeleteGroupTextBox";
            DeleteGroupTextBox.Size = new Size(39, 23);
            DeleteGroupTextBox.TabIndex = 47;
            // 
            // DeleteGroupButton
            // 
            DeleteGroupButton.BackColor = Color.Transparent;
            DeleteGroupButton.BackgroundImage = Properties.Resources.ButtonsImage;
            DeleteGroupButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteGroupButton.Font = new Font("Tahoma", 8.25F);
            DeleteGroupButton.Location = new Point(726, 148);
            DeleteGroupButton.Name = "DeleteGroupButton";
            DeleteGroupButton.Size = new Size(106, 46);
            DeleteGroupButton.TabIndex = 46;
            DeleteGroupButton.Text = "Удалить группу";
            DeleteGroupButton.UseVisualStyleBackColor = false;
            DeleteGroupButton.Click += DeleteGroupButton_Click;
            // 
            // EditGroupTextBox
            // 
            EditGroupTextBox.Location = new Point(849, 109);
            EditGroupTextBox.Name = "EditGroupTextBox";
            EditGroupTextBox.Size = new Size(39, 23);
            EditGroupTextBox.TabIndex = 45;
            // 
            // EditGroupButton
            // 
            EditGroupButton.BackColor = Color.Transparent;
            EditGroupButton.BackgroundImage = Properties.Resources.ButtonsImage;
            EditGroupButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditGroupButton.Font = new Font("Tahoma", 8.25F);
            EditGroupButton.Location = new Point(726, 96);
            EditGroupButton.Name = "EditGroupButton";
            EditGroupButton.Size = new Size(106, 46);
            EditGroupButton.TabIndex = 43;
            EditGroupButton.Text = "Редактировать группу";
            EditGroupButton.UseVisualStyleBackColor = false;
            EditGroupButton.Click += EditGroupButton_Click;
            // 
            // AddGroupButton
            // 
            AddGroupButton.BackColor = Color.Transparent;
            AddGroupButton.BackgroundImage = Properties.Resources.ButtonsImage;
            AddGroupButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddGroupButton.Font = new Font("Tahoma", 8.25F);
            AddGroupButton.Location = new Point(726, 44);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(162, 46);
            AddGroupButton.TabIndex = 42;
            AddGroupButton.Text = "Добавить группу";
            AddGroupButton.UseVisualStyleBackColor = false;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 426);
            dataGridView1.TabIndex = 41;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.Transparent;
            RefreshButton.BackgroundImage = Properties.Resources.ButtonsImage;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.Font = new Font("Tahoma", 8.25F);
            RefreshButton.Location = new Point(726, 386);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(162, 46);
            RefreshButton.TabIndex = 44;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // DeleteGroupAndStudentsButton
            // 
            DeleteGroupAndStudentsButton.BackColor = Color.Transparent;
            DeleteGroupAndStudentsButton.BackgroundImage = Properties.Resources.ButtonsImage;
            DeleteGroupAndStudentsButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteGroupAndStudentsButton.Font = new Font("Tahoma", 8.25F);
            DeleteGroupAndStudentsButton.Location = new Point(726, 200);
            DeleteGroupAndStudentsButton.Name = "DeleteGroupAndStudentsButton";
            DeleteGroupAndStudentsButton.Size = new Size(106, 46);
            DeleteGroupAndStudentsButton.TabIndex = 52;
            DeleteGroupAndStudentsButton.Text = "Удалить группу и студентов";
            DeleteGroupAndStudentsButton.UseVisualStyleBackColor = false;
            DeleteGroupAndStudentsButton.Click += DeleteGroupAndStudentsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 8.25F);
            label1.Location = new Point(833, 216);
            label1.Name = "label1";
            label1.Size = new Size(15, 13);
            label1.TabIndex = 54;
            label1.Text = "id";
            // 
            // DeleteGroupAndStudentsTextBox
            // 
            DeleteGroupAndStudentsTextBox.Location = new Point(849, 213);
            DeleteGroupAndStudentsTextBox.Name = "DeleteGroupAndStudentsTextBox";
            DeleteGroupAndStudentsTextBox.Size = new Size(39, 23);
            DeleteGroupAndStudentsTextBox.TabIndex = 53;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = Properties.Resources.ButtonsImage;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Font = new Font("Tahoma", 9F);
            searchButton.Location = new Point(221, 477);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 46);
            searchButton.TabIndex = 57;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 490);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(203, 23);
            searchTextBox.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(12, 473);
            label6.Name = "label6";
            label6.Size = new Size(83, 14);
            label6.TabIndex = 55;
            label6.Text = "Найти группу";
            // 
            // ManageGroups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(894, 552);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(DeleteGroupAndStudentsTextBox);
            Controls.Add(DeleteGroupAndStudentsButton);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DeleteGroupTextBox);
            Controls.Add(DeleteGroupButton);
            Controls.Add(EditGroupTextBox);
            Controls.Add(EditGroupButton);
            Controls.Add(AddGroupButton);
            Controls.Add(dataGridView1);
            Controls.Add(RefreshButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageGroups";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление группами";
            FormClosing += ManageGroups_FormClosing;
            Load += ManageGroups_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button SortDownButton;
        private Button SortUpButton;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox DeleteGroupTextBox;
        private Button DeleteGroupButton;
        private TextBox EditGroupTextBox;
        private Button EditGroupButton;
        private Button AddGroupButton;
        private DataGridView dataGridView1;
        private Button RefreshButton;
        private Button DeleteGroupAndStudentsButton;
        private Label label1;
        private TextBox DeleteGroupAndStudentsTextBox;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label6;
    }
}