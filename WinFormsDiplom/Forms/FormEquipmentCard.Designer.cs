namespace WinFormsDiplom.Forms
{
    partial class FormEquipmentCard
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
            btnBack = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            textBoxNCatEq = new TextBox();
            textBoxValue = new TextBox();
            textBoxFinResponsible = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxModel = new TextBox();
            dgv_category = new DataGridView();
            dgv_staff = new DataGridView();
            textBoxIN = new TextBox();
            labelNumCategory = new Label();
            labelNumStaff = new Label();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_category).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_staff).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(12, 613);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 56);
            btnBack.TabIndex = 4;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(966, 613);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 56);
            btnSave.TabIndex = 5;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(1112, 613);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 56);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12F);
            checkBox1.Location = new Point(30, 420);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Активен для м.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 12F);
            checkBox2.Location = new Point(30, 465);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(145, 23);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Неактивен для м.";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Times New Roman", 12F);
            checkBox3.Location = new Point(30, 509);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(78, 23);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Ремонт";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 31);
            label1.TabIndex = 11;
            label1.Text = "ИН";
            // 
            // textBoxNCatEq
            // 
            textBoxNCatEq.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNCatEq.Location = new Point(412, 127);
            textBoxNCatEq.Name = "textBoxNCatEq";
            textBoxNCatEq.Size = new Size(150, 29);
            textBoxNCatEq.TabIndex = 12;
            // 
            // textBoxValue
            // 
            textBoxValue.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxValue.Location = new Point(306, 204);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(150, 29);
            textBoxValue.TabIndex = 13;
            // 
            // textBoxFinResponsible
            // 
            textBoxFinResponsible.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFinResponsible.Location = new Point(445, 287);
            textBoxFinResponsible.Name = "textBoxFinResponsible";
            textBoxFinResponsible.Size = new Size(150, 29);
            textBoxFinResponsible.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(376, 31);
            label2.TabIndex = 16;
            label2.Text = "Номер категории оборудования";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(30, 204);
            label3.Name = "label3";
            label3.Size = new Size(270, 31);
            label3.TabIndex = 17;
            label3.Text = "Балансовая стоимость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(30, 282);
            label5.Name = "label5";
            label5.Size = new Size(409, 31);
            label5.TabIndex = 19;
            label5.Text = "Номер ответственного сотрудника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(30, 354);
            label6.Name = "label6";
            label6.Size = new Size(101, 31);
            label6.TabIndex = 20;
            label6.Text = "Модель";
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxModel.Location = new Point(137, 354);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(150, 29);
            textBoxModel.TabIndex = 21;
            // 
            // dgv_category
            // 
            dgv_category.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_category.Location = new Point(966, 85);
            dgv_category.Name = "dgv_category";
            dgv_category.Size = new Size(272, 150);
            dgv_category.TabIndex = 22;
            // 
            // dgv_staff
            // 
            dgv_staff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_staff.Location = new Point(966, 306);
            dgv_staff.Name = "dgv_staff";
            dgv_staff.Size = new Size(272, 150);
            dgv_staff.TabIndex = 23;
            // 
            // textBoxIN
            // 
            textBoxIN.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIN.Location = new Point(108, 67);
            textBoxIN.Name = "textBoxIN";
            textBoxIN.Size = new Size(150, 29);
            textBoxIN.TabIndex = 25;
            // 
            // labelNumCategory
            // 
            labelNumCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNumCategory.AutoSize = true;
            labelNumCategory.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumCategory.Location = new Point(674, 85);
            labelNumCategory.Name = "labelNumCategory";
            labelNumCategory.Size = new Size(280, 21);
            labelNumCategory.TabIndex = 26;
            labelNumCategory.Text = "Номера категорий оборудования:\r\n";
            // 
            // labelNumStaff
            // 
            labelNumStaff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNumStaff.AutoSize = true;
            labelNumStaff.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumStaff.Location = new Point(848, 306);
            labelNumStaff.Name = "labelNumStaff";
            labelNumStaff.Size = new Size(112, 42);
            labelNumStaff.TabIndex = 27;
            labelNumStaff.Text = "Сотрудники:\r\n\r\n";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_add.Location = new Point(814, 613);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(140, 56);
            btn_add.TabIndex = 28;
            btn_add.Text = "Добавить";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // FormEquipmentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_add);
            Controls.Add(labelNumStaff);
            Controls.Add(labelNumCategory);
            Controls.Add(textBoxIN);
            Controls.Add(dgv_staff);
            Controls.Add(dgv_category);
            Controls.Add(textBoxModel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxFinResponsible);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxNCatEq);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 720);
            Name = "FormEquipmentCard";
            Text = "Карточка оборудования";
            Load += FormEquipmentCard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_category).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_staff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private Button btnEdit;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private TextBox textBoxNCatEq;
        private TextBox textBoxValue;
        private TextBox textBoxFinResponsible;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBoxModel;
        private DataGridView dgv_category;
        private DataGridView dgv_staff;
        private TextBox textBoxIN;
        private Label labelNumCategory;
        private Label labelNumStaff;
        private Button btn_add;
    }
}