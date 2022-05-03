using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;


namespace EquipmentDB.Forms.ReferenceForms
{
    public partial class EquipmentTypesForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public EquipmentTypesForm()
        {
            InitializeComponent();
            UpdateDatagrid();
        }

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<EquipmentType>();
            dataGridView.ClearSelection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EquipmentType;
                new AddEditEquipmentTypeForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EquipmentType;
                var result = MessageBox.Show("Удалить тип оборудования с ID " + item.EquipmentType_ID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item,d => d.EquipmentType_ID==item.EquipmentType_ID);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }
            }
        }

       
        private void buttonAddStatus_Click_1(object sender, EventArgs e)
        {
            new AddEditEquipmentTypeForm().ShowDialog();
            UpdateDatagrid();
        }
    }
}
