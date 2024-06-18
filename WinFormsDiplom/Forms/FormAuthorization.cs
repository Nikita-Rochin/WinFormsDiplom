using Microsoft.EntityFrameworkCore;
using WinFormsDiplom.Forms;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using WinFormsDiplom.�lasses;

namespace WinFormsDiplom
{
    public partial class FormAuthorization : Form
    {
        private DbdContext db1 = new DbdContext();
        public string UserName { get; private set; }
        public FormAuthorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var user = db1.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                MessageBox.Show($"����� ����������, {user.UserName}");

                this.UserName = user.UserName;
                this.Hide();
                FormTables formt = new FormTables(UserName);
                formt.ShowDialog();
            }
            else
            {
                MessageBox.Show("������������ ����� ��� ������");
            }
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e) //����������� ���������� ���� ��������
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
