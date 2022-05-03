using System;
using System.Windows.Forms;
using EquipmentDB.Controller;


namespace EmployeeApp.View
{
    public partial class LoginForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                _repository.UserLogin(textBoxLogin.Text, textBoxPassword.Text);
                if (_repository.GetCurrentUser()!=null)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show(" Пользователь с таким логином и паролем не найден!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBoxPassword.Clear();
                }
            }
            catch (Exception e)
            {
                _repository.HandleException(e);
            }
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
           Login();
        }

       private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
               Login(); 
            }
        }

        
    }
}
