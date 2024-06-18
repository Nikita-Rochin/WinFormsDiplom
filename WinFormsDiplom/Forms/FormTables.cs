using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDiplom.Сlasses;
using WinFormsDiplom.Views;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;

namespace WinFormsDiplom.Forms
{
    public partial class FormTables : Form
    {
        private DbdContext db1 = new DbdContext();

        public string username;

        private string currentCollection;
        public FormTables(string UserName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.username = UserName;
        }

        private void FormTables_Shown(object sender, EventArgs e)
        {
            lables_username.Text = username;
            btnchoose.Visible = false;
            btn_ConvertPDF.Visible = false;
            btn_write.Visible = false;
            btn_delete.Visible = false;
            btn_import.Visible = false;
        }

        private void FormTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        //Представления для ListBox
        private void ViewEquipment()
        {
            var date = (from EqAll in db1.ViewEquipments select EqAll);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewEvent()
        {
            var date = (from ViewEvent in db1.ViewEvents select ViewEvent);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewCatEq()
        {
            var date = (from ViewMovEq in db1.ViewCatEqs select ViewMovEq);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewUser()
        {
            var date = (from ViewUser in db1.ViewUsers select ViewUser);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewStaff()
        {
            var date = (from ViewStaff in db1.ViewStaffs select ViewStaff);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewStatus()
        {
            var date = (from ViewStatus in db1.ViewStatuses select ViewStatus);
            dataGridView1.DataSource = date.ToList();
        }

        private void ViewMovEqDataTransferDesc()
        {
            var date = (from ViewMovEqDateTransferDesc in db1.ViewMovEqDateTransferDescs select ViewMovEqDateTransferDesc);
            dataGridView1.DataSource = date.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = listBox1.SelectedItem.ToString();

            currentCollection = select;

            // Проверяем доступ пользователя к коллекции "Пользователи"
            if (select == "Пользователи" && username != "Admin")
            {
                MessageBox.Show("Недостаточно прав доступа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (select)
            {
                case "Оборудования":
                    ViewEquipment();
                    if (username != "Admin")
                    {
                        btn_write.Visible = false;
                        btnchoose.Visible = false;
                        btn_delete.Visible = false;
                        btn_import.Visible = false;
                    }
                    else
                    {
                        btn_write.Visible = true;
                        btnchoose.Visible = true;
                        btn_delete.Visible = true;
                        btn_import.Visible = true;
                    }
                    btn_ConvertPDF.Visible = true;
                    break;
                case "Мероприятия":
                    ViewEvent();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;
                case "Движение оборудования":
                    ViewMovEqDataTransferDesc();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;
                case "Пользователи":
                    ViewUser();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;
                case "Сотрудники":
                    ViewStaff();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;
                case "Категории оборудования":
                    ViewCatEq();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;
                case "Статусы":
                    ViewStatus();
                    btnchoose.Visible = false;
                    btn_ConvertPDF.Visible = false;
                    btn_write.Visible = false;
                    btn_delete.Visible = false;
                    btn_import.Visible = false;
                    break;

            }
        }

        private void RefreshDataGridView()
        {
            // Перезагружаем данные в DataGridView в соответствии с выбранной коллекцией
            switch (currentCollection)
            {
                case "Оборудования":
                    ViewEquipment();
                    break;
                case "Мероприятия":
                    ViewEvent();
                    break;
                case "Движение оборудования":
                    ViewMovEqDataTransferDesc();
                    break;
                case "Пользователи":
                    ViewUser();
                    break;
                case "Сотрудники":
                    ViewStaff();
                    break;
                case "Категории оборудования":
                    ViewCatEq();
                    break;
                case "Статусы":
                    ViewStatus();
                    break;
                default:
                    // В случае, если ни одна из коллекций не совпадает, просто обновляем DataGridView
                    dataGridView1.Refresh();
                    break;
            }
        }

        private void btnUpdateDataGrid_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentCollection != "Оборудования")
            {
                MessageBox.Show("Это не та коллекция", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Получение данных из выбранной строки и обработка возможных значений null
            string inventoryNumber = row.Cells["ИнвентарныйНомер"].Value?.ToString() ?? "";
            string Category = row.Cells["Категория"].Value?.ToString() ?? "";
            string model = row.Cells["Модель"].Value?.ToString() ?? "";
            string bookValue = row.Cells["БалансоваяСтоимость"].Value?.ToString() ?? "";
            string financiallyResponsible = row.Cells["ОтветственныйСотрудник"].Value?.ToString() ?? "";

            // Передача данных в элементы управления на форме FormEquipmentCard
            this.Hide();
            FormEquipmentCard equipmentCardForm = new FormEquipmentCard(username);
            equipmentCardForm.FillData(inventoryNumber, Category, model, bookValue, financiallyResponsible);
            equipmentCardForm.ShowDialog();
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string idEquipment = row.Cells[0].Value?.ToString() ?? "";

                this.Hide();
                FormTransfer transferForm = new FormTransfer(idEquipment, username);
                transferForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPdf(DataGridView dataGridView, string filePath)//Метод\События создани PDF документа
        {
            Document pdfDoc = new Document(PageSize.A4, 40f, 40f, 30f, 30f);
            try
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                Paragraph paragraphCenter = new Paragraph();
                Paragraph paragraphJustified = new Paragraph();

                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\Fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 14f, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font font_ = new iTextSharp.text.Font(baseFont, 14f, iTextSharp.text.Font.UNDERLINE);

                paragraphCenter.Alignment = Element.ALIGN_CENTER;
                paragraphJustified.Alignment = Element.ALIGN_JUSTIFIED;

                paragraphCenter.Add(new Chunk("Акт приёма-передачи оргтехники\n\n\n\n", font));

                // Создание списков для хранения уникальных значений оргтехники и инвентарных номеров
                List<string> equipmentList = new List<string>();
                List<string> inventoryNumbersList = new List<string>();

                paragraphJustified.Add(new Chunk("          Оргтехника ", font));

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.Index >= 0 && row.Cells.Count >= 4)
                    {
                        string equipment = row.Cells[3].Value.ToString(); // Оргтехника
                        string inventoryNumber = row.Cells[1].Value.ToString(); // Инвентарный номер

                        // Добавляем только уникальные значения оргтехники
                        if (!equipmentList.Contains(equipment))
                        {
                            paragraphJustified.Add(new Chunk($"{equipment}, ", font_));
                            equipmentList.Add(equipment);
                        }
                        inventoryNumbersList.Add(inventoryNumber);
                    }
                }

                paragraphJustified.Add("\n\n");

                // Добавляем инвентарные номера
                paragraphJustified.Add(new Chunk("инвентарный номер ", font));
                foreach (string inventoryNumber in inventoryNumbersList)
                {
                    paragraphJustified.Add(new Chunk($"{inventoryNumber}, ", font_));
                }
                paragraphJustified.Add("\n\n");

                paragraphJustified.Add(new Chunk("передается от ____________________________________________________________,\n\n", font));
                paragraphJustified.Add(new Chunk("на демонстрационный экзамен по компетенции _________________________________________________________________________\n\n", font));
                paragraphJustified.Add(new Chunk("техническому эксперту _____________________________________________________\n\n", font));
                paragraphJustified.Add(new Chunk($"с ____________ {DateTime.Now.Year}г. по ____________ {DateTime.Now.Year}г. под личную ответственность.\n\n", font));
                paragraphJustified.Add(new Chunk("          На момент передачи оргтехники осмотрена на отсутствие неисправностей.\n\n\n\n\n", font));

                paragraphJustified.Add(new Chunk("          Передал ___________________________________________________________\n", font));
                paragraphJustified.Add(new Chunk("                                  (ФИО)\t                                     (Подпись)\n\n", font));

                paragraphJustified.Add(new Chunk("          Принял ____________________________________________________________\n", font));
                paragraphJustified.Add(new Chunk("                                  (ФИО)\t                                     (Подпись)\n\n", font));

                paragraphJustified.Add(new Chunk("          Проверил __________________________________________________________\n", font));
                paragraphJustified.Add(new Chunk("                                  (ФИО)\t                                     (Подпись)\n\n", font));

                paragraphJustified.Add(new Chunk($"Дата ____________________{DateTime.Now.Year}г.\n\n", font));

                pdfDoc.Add(paragraphCenter);
                pdfDoc.Add(paragraphJustified);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                pdfDoc.Close();
            }
        }

        private void btn_ConvertPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF File|*.pdf";
            saveDialog.Title = "Save PDF";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(dataGridView1, saveDialog.FileName);
                MessageBox.Show("PDF сохранен успешно!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            btn_write.Visible = true;
            this.Hide();
            FormEquipmentCard card = new FormEquipmentCard(username);
            card.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string inventoryNumber = selectedRow.Cells["ИнвентарныйНомер"].Value.ToString();

            Equipment equipmentToDelete = db1.Equipment.FirstOrDefault(e => e.InventoryNumber == int.Parse(inventoryNumber));
            MovementEquipment mEtoDelete = db1.MovementEquipments.FirstOrDefault(m => m.IdEquipment == int.Parse(inventoryNumber));

            if (equipmentToDelete != null || mEtoDelete != null)
            {
                try
                {
                    if (equipmentToDelete != null)
                    {
                        db1.Equipment.Remove(equipmentToDelete);
                    }
                    else
                    {
                        db1.MovementEquipments.Remove(mEtoDelete);
                    }

                    db1.SaveChanges();

                    string tableName = equipmentToDelete != null ? "Equipment" : "MovementEquipments";
                    int maxId = 0;

                    if (tableName == "Equipment")
                    {
                        maxId = db1.Equipment.Max(e => e.Id);
                    }
                    else
                    {
                        maxId = db1.MovementEquipments.Max(m => m.Id);
                    }

                    if (maxId > 0)
                    {
                        db1.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('{tableName}', RESEED, {maxId})");
                    }

                    MessageBox.Show("Запись успешно удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorMessage = "Произошла ошибка при удалении записи: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                    }
                    MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void ImportFromExcel(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();

                if (worksheet != null)
                {
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) //Первая строка является заголовком
                    {
                        Equipment equipment = new Equipment
                        {
                            InventoryNumber = int.TryParse(worksheet.Cells[row, 1].Value?.ToString(), out int invNum) ? invNum : null,
                            Category = int.TryParse(worksheet.Cells[row, 2].Value?.ToString(), out int cat) ? cat : null,
                            Model = worksheet.Cells[row, 3].Value?.ToString(),
                            BookValue = decimal.TryParse(worksheet.Cells[row, 4].Value?.ToString(), out decimal bv) ? bv : null,
                            FinanciallyResponsible = int.TryParse(worksheet.Cells[row, 5].Value?.ToString(), out int fr) ? fr : null,
                            Status = int.TryParse(worksheet.Cells[row, 6].Value?.ToString(), out int status) ? status : null
                        };
                        db1.Equipment.Add(equipment);
                    }
                    db1.SaveChanges();
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportFromExcel(filePath);
            }
        }
    }
}
