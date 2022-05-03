using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    public partial class UsersForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public UsersForm()
        {
            InitializeComponent();
        }

        #region Обработчики событий
        
        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as User;
                new AddEditUserForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as User;
                var result = MessageBox.Show("Удалить пользователя с ID " + item.User_ID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item, d => d. User_ID == item.User_ID);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }
            }
        }

        /// <summary>
        /// Обработчик события добавления нового объекта
        /// </summary>
        private void buttonAddStatus_Click_1(object sender, EventArgs e)
        {
            new AddEditUserForm().ShowDialog();
            UpdateDatagrid();
        }
        
        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
           UpdateDatagrid();
        }

       
        

        #endregion

        #region Приватные методы

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<User>();
            dataGridView.ClearSelection();
        }


       

        #endregion

       

    }
}
