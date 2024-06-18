using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsDiplom.Forms
{
    public partial class FormEquipmentCard : Form
    {
        private DbdContext db1 = new DbdContext();
        private Equipment equipmentInstance;
        private bool isEditing = false;

        public string UserName { get; private set; }
        public FormEquipmentCard(string userName)
        {
            InitializeComponent();
            this.UserName = userName;

            // Проверка имени пользователя и установка видимости кнопок
            if (this.UserName != "Admin")
            {
                btnSave.Visible = false;
                btnEdit.Visible = false;
            }

            // Добавляем обработчики для CheckBox
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void ViewCatEq()
        {
            var date = (from ViewMovEq in db1.ViewCatEqs select ViewMovEq);
            dgv_category.DataSource = date.ToList();
        }
        private void ViewStaff()
        {
            var date = (from ViewStaff in db1.ViewStaffs select ViewStaff);
            dgv_staff.DataSource = date.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTables formt = new FormTables(this.UserName);
            formt.ShowDialog();
        }

        public void FillData(string inventoryNumber, string Category, string model, string bookValue, string financiallyResponsible)
        {
            textBoxIN.Text = inventoryNumber;
            textBoxNCatEq.Text = Category;
            textBoxModel.Text = model;
            textBoxValue.Text = bookValue;
            textBoxFinResponsible.Text = financiallyResponsible;

            if (int.TryParse(inventoryNumber, out int inventoryNumberInt))
            {
                // Загружаем экземпляр оборудования
                equipmentInstance = db1.Equipment.FirstOrDefault(e => e.InventoryNumber == inventoryNumberInt);

                if (equipmentInstance != null)
                {
                    // Устанавливаем состояние CheckBox на основе id_status
                    switch (equipmentInstance.Status)
                    {
                        case 1:
                            checkBox1.Checked = true;
                            break;
                        case 2:
                            checkBox2.Checked = true;
                            break;
                        case 3:
                            checkBox3.Checked = true;
                            break;
                        default:
                            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
                            break;
                    }
                }
            }

            // Блокируем элементы управления, чтобы они были только для чтения
            LockControls();
        }

        private void FormEquipmentCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void LockControls()//Метод блокировки элементов формы
        {
            textBoxIN.Enabled = false;
            textBoxNCatEq.ReadOnly = true;
            textBoxModel.ReadOnly = true;
            textBoxValue.ReadOnly = true;
            textBoxFinResponsible.ReadOnly = true;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
        }

        private void UnlockControls()//Метод разблокировки элементов формы
        {
            textBoxIN.Enabled = true;
            textBoxNCatEq.ReadOnly = false;
            textBoxModel.ReadOnly = false;
            textBoxValue.ReadOnly = false;
            textBoxFinResponsible.ReadOnly = false;

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Разрешаем редактирование элементов
            UnlockControls();

            // Устанавливаем флаг, чтобы указать, что сейчас идет редактирование
            isEditing = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (equipmentInstance != null && isEditing)
            {
                try
                {
                    equipmentInstance.Category = int.Parse(textBoxNCatEq.Text);
                    equipmentInstance.Model = textBoxModel.Text;
                    equipmentInstance.BookValue = decimal.Parse(textBoxValue.Text);
                    equipmentInstance.FinanciallyResponsible = int.Parse(textBoxFinResponsible.Text);

                    // Обновляем id_status на основе выбранного CheckBox
                    if (checkBox1.Checked) equipmentInstance.Status = 1;
                    else if (checkBox2.Checked) equipmentInstance.Status = 2;
                    else if (checkBox3.Checked) equipmentInstance.Status = 3;

                    db1.SaveChanges();

                    LockControls();

                    isEditing = false;

                    MessageBox.Show("Данные успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbUpdateException ex)
                {
                    // Проверяем, является ли исключение вызванное ошибкой в базе данных
                    if (ex.InnerException is SqlException sqlException && sqlException.Number == 547)
                    {
                        MessageBox.Show("Номер Категории и(ли) Ответсвенного лица не существуют в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при сохранении данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("В одном или нескольких полях введен неверный тип данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)//Метод "Флажка"
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox.Checked)
            {
                if (changedCheckBox == checkBox1)
                {
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else if (changedCheckBox == checkBox2)
                {
                    checkBox1.Checked = false;
                    checkBox3.Checked = false;
                }
                else if (changedCheckBox == checkBox3)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment newEquipment = new Equipment
                {
                    InventoryNumber = int.Parse(textBoxIN.Text),
                    Category = int.Parse(textBoxNCatEq.Text),
                    Model = textBoxModel.Text,
                    BookValue = decimal.Parse(textBoxValue.Text),
                    FinanciallyResponsible = int.Parse(textBoxFinResponsible.Text)
                };

                // Устанавливаем статус в зависимости от выбранного CheckBox
                if (checkBox1.Checked) newEquipment.Status = 1;
                else if (checkBox2.Checked) newEquipment.Status = 2;
                else if (checkBox3.Checked) newEquipment.Status = 3;

                // Проверяем, существует ли уже запись с таким же InventoryNumber
                if (db1.Equipment.Any(e => e.InventoryNumber == newEquipment.InventoryNumber))
                {
                    MessageBox.Show("Оборудование с таким же инвентарным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Если номер инвентаря уникален, добавляем новую запись
                    db1.Equipment.Add(newEquipment);
                    db1.SaveChanges();
                    MessageBox.Show("Новая запись успешно добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException ex)
            {
                // Проверяем, является ли исключение вызванное ошибкой в базе данных
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 547)
                {
                    MessageBox.Show("Номер Категории и(ли) Ответсвенного лица не существуют в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении новой записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("В одном или нескольких полях введен неверный тип данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEquipmentCard_Load(object sender, EventArgs e)
        {
            ViewCatEq();
            ViewStaff();
        }
    }
}
