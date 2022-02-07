using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.BL.Controller;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Controller controller;
        public Form1()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
           
            int id;
            string password;
            try
            {
                id = Convert.ToInt32(IdTextBox.Text); //TODO: проверка
                password = PasswordTextBox.Text;
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(
                    "Проверте поля Id и пароль\n" + ex,
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            if (controller.IsLogIn(id, password))
            {
                DialogResult result = MessageBox.Show(
                    $"Здраствейте {controller.NameUser()} вы вошли :)",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );

            }
            else
            {
                DialogResult result = MessageBox.Show(
                   $"Пользователь не найден :(",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly
                   );
            }

            var Notes = controller.ListUserNotes();
            if (Notes.Count == 0)
            {
                 DialogResult result = MessageBox.Show(
                   $"У вас нет заметок.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly
                   );
                return;
            }
            foreach (var item in Notes)
            {
                checkedListBox.Items.Add(item.TextF(), item.IsCheckedF());

            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
