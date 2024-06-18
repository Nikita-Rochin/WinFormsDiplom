namespace WinFormsDiplom.Forms
{
    partial class FormTables
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
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            btnUpdateDataGrid = new Button();
            btnchoose = new Button();
            btnExit = new Button();
            btn_ConvertPDF = new Button();
            lables_username = new Label();
            btn_write = new Button();
            btn_delete = new Button();
            btn_import = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1043, 585);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "Оборудования", "Мероприятия", "Движение оборудования", "Пользователи", "Сотрудники", "Категории оборудования", "Статусы" });
            listBox1.Location = new Point(1061, 45);
            listBox1.MaximumSize = new Size(200, 175);
            listBox1.MinimumSize = new Size(155, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 137);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnUpdateDataGrid
            // 
            btnUpdateDataGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateDataGrid.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdateDataGrid.Location = new Point(1112, 613);
            btnUpdateDataGrid.Name = "btnUpdateDataGrid";
            btnUpdateDataGrid.Size = new Size(140, 56);
            btnUpdateDataGrid.TabIndex = 3;
            btnUpdateDataGrid.Text = "Обновить таблицу";
            btnUpdateDataGrid.UseVisualStyleBackColor = true;
            btnUpdateDataGrid.Click += btnUpdateDataGrid_Click;
            // 
            // btnchoose
            // 
            btnchoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnchoose.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnchoose.Location = new Point(808, 613);
            btnchoose.Name = "btnchoose";
            btnchoose.Size = new Size(140, 56);
            btnchoose.TabIndex = 4;
            btnchoose.Text = "Переместить";
            btnchoose.UseVisualStyleBackColor = true;
            btnchoose.Click += btnchoose_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(12, 613);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 56);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btn_ConvertPDF
            // 
            btn_ConvertPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ConvertPDF.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_ConvertPDF.Location = new Point(954, 613);
            btn_ConvertPDF.Name = "btn_ConvertPDF";
            btn_ConvertPDF.Size = new Size(152, 56);
            btn_ConvertPDF.TabIndex = 6;
            btn_ConvertPDF.Text = "АКТ п/п\r\n";
            btn_ConvertPDF.UseVisualStyleBackColor = true;
            btn_ConvertPDF.Click += btn_ConvertPDF_Click;
            // 
            // lables_username
            // 
            lables_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lables_username.AutoSize = true;
            lables_username.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lables_username.Location = new Point(1112, 12);
            lables_username.Name = "lables_username";
            lables_username.Size = new Size(88, 21);
            lables_username.TabIndex = 7;
            lables_username.Text = "UserName";
            // 
            // btn_write
            // 
            btn_write.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_write.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_write.Location = new Point(1112, 541);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(140, 56);
            btn_write.TabIndex = 8;
            btn_write.Text = "Добавить запись";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_delete.Location = new Point(1112, 470);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(140, 56);
            btn_delete.TabIndex = 30;
            btn_delete.Text = "Удалить";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_import
            // 
            btn_import.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_import.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_import.Location = new Point(1112, 394);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(140, 56);
            btn_import.TabIndex = 31;
            btn_import.Text = "Импорт оборудования";
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // FormTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_import);
            Controls.Add(btn_delete);
            Controls.Add(btn_write);
            Controls.Add(lables_username);
            Controls.Add(btn_ConvertPDF);
            Controls.Add(btnExit);
            Controls.Add(btnchoose);
            Controls.Add(btnUpdateDataGrid);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 720);
            Name = "FormTables";
            Text = "Главная";
            Shown += FormTables_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Button btnUpdateDataGrid;
        private Button btnchoose;
        private Button btnExit;
        private Button btn_ConvertPDF;
        private Label lables_username;
        private Button btn_write;
        private Button btn_delete;
        private Button btn_import;
    }
}