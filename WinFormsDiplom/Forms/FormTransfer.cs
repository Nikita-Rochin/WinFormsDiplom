using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDiplom.Views;
using WinFormsDiplom.Сlasses;

namespace WinFormsDiplom.Forms
{
    public partial class FormTransfer : Form
    {
        private DbdContext db1 = new DbdContext();
        public string idEquipment;
        public string userName;

        public FormTransfer(string idEquipment, string userName)
        {
            InitializeComponent();
            this.idEquipment = idEquipment;
            this.userName = userName;
            textBox1.Text = idEquipment;
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            if (userName != "Admin")
            {
                MessageBox.Show("Для отправки оборудования свяжитесь с нами по телефону: +123456789 или по электронной почте: ivc@vgkuint.ru", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получение данных из текстовых полей
            int? idEquipment = Convert.ToInt32(textBox1.Text);
            int? idEvent = Convert.ToInt32(textBox2.Text);
            int? idStaffSender = Convert.ToInt32(textBox3.Text);
            int? idStaffRecipient = Convert.ToInt32(textBox4.Text);
            int? quantity = Convert.ToInt32(textBox5.Text);
            DateOnly? dateTransfer = DateOnly.Parse(textBox6.Text);
            DateOnly? dateReturn = DateOnly.Parse(textBox7.Text);

            // Создание новой записи MovementEquipment
            MovementEquipment newRecord = new MovementEquipment
            {
                IdEquipment = idEquipment,
                IdEvent = idEvent,
                IdStaffSender = idStaffSender,
                IdStaffRecipient = idStaffRecipient,
                Quantity = quantity,
                DateTransfer = dateTransfer,
                DateReturn = dateReturn
            };

            using (var context = new DbdContext())
            {
                context.MovementEquipments.Add(newRecord);
                context.SaveChanges();
            }

            MessageBox.Show("Запись успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormTables formTables = new FormTables(userName);
            formTables.ShowDialog();
        }
        private void ViewStaff()
        {
            var date = (from ViewStaff in db1.ViewStaffs select ViewStaff);
            dgv_staff.DataSource = date.ToList();
        }

        private void ViewEvent()
        {
            var date = (from ViewEvent in db1.ViewEvents select ViewEvent);
            dgv_events.DataSource = date.ToList();
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            ViewStaff();
            ViewEvent();
        }
    }
}
