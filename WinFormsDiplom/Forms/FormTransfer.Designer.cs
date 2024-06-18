namespace WinFormsDiplom.Forms
{
    partial class FormTransfer
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
            btnTranfer = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            labelNumStaff = new Label();
            dgv_staff = new DataGridView();
            dgv_events = new DataGridView();
            labelNumEvents = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_staff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_events).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(12, 612);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 56);
            btnBack.TabIndex = 5;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnTranfer
            // 
            btnTranfer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTranfer.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTranfer.Location = new Point(1098, 612);
            btnTranfer.Name = "btnTranfer";
            btnTranfer.Size = new Size(140, 56);
            btnTranfer.TabIndex = 6;
            btnTranfer.Text = "Отправить";
            btnTranfer.UseVisualStyleBackColor = true;
            btnTranfer.Click += btnTranfer_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(275, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 29);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(287, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 29);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(265, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 29);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(252, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 29);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(177, 360);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 29);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(207, 426);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 29);
            textBox6.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 19;
            label1.Text = "Инвентарный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 202);
            label2.Name = "label2";
            label2.Size = new Size(226, 62);
            label2.TabIndex = 20;
            label2.Text = "Номер сотрудника\r\nотправителя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 277);
            label3.Name = "label3";
            label3.Size = new Size(226, 62);
            label3.TabIndex = 21;
            label3.Text = "Номер сотрудника\r\n получателя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 129);
            label4.Name = "label4";
            label4.Size = new Size(259, 31);
            label4.TabIndex = 22;
            label4.Text = "Номер мероприятияй";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(22, 360);
            label5.Name = "label5";
            label5.Size = new Size(149, 31);
            label5.TabIndex = 23;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(22, 426);
            label6.Name = "label6";
            label6.Size = new Size(179, 31);
            label6.TabIndex = 24;
            label6.Text = "Дата передачи";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(22, 503);
            label7.Name = "label7";
            label7.Size = new Size(172, 31);
            label7.TabIndex = 25;
            label7.Text = "Дата возврата";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(207, 503);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 29);
            textBox7.TabIndex = 26;
            // 
            // labelNumStaff
            // 
            labelNumStaff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNumStaff.AutoSize = true;
            labelNumStaff.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumStaff.Location = new Point(806, 48);
            labelNumStaff.Name = "labelNumStaff";
            labelNumStaff.Size = new Size(112, 42);
            labelNumStaff.TabIndex = 31;
            labelNumStaff.Text = "Сотрудники:\r\n\r\n";
            // 
            // dgv_staff
            // 
            dgv_staff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_staff.Location = new Point(924, 48);
            dgv_staff.Name = "dgv_staff";
            dgv_staff.Size = new Size(272, 150);
            dgv_staff.TabIndex = 29;
            // 
            // dgv_events
            // 
            dgv_events.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_events.Location = new Point(924, 233);
            dgv_events.Name = "dgv_events";
            dgv_events.Size = new Size(272, 150);
            dgv_events.TabIndex = 32;
            // 
            // labelNumEvents
            // 
            labelNumEvents.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNumEvents.AutoSize = true;
            labelNumEvents.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumEvents.Location = new Point(798, 233);
            labelNumEvents.Name = "labelNumEvents";
            labelNumEvents.Size = new Size(120, 21);
            labelNumEvents.TabIndex = 33;
            labelNumEvents.Text = "Мероприятия";
            // 
            // FormTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelNumEvents);
            Controls.Add(dgv_events);
            Controls.Add(labelNumStaff);
            Controls.Add(dgv_staff);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnTranfer);
            Controls.Add(btnBack);
            MaximumSize = new Size(1660, 960);
            MinimumSize = new Size(1280, 720);
            Name = "FormTransfer";
            Text = "Перемещение оборудования";
            Load += FormTransfer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_staff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_events).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnTranfer;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox7;
        private Label labelNumStaff;
        private DataGridView dgv_staff;
        private DataGridView dgv_events;
        private Label labelNumEvents;
    }
}