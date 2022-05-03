using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.TemplateFiller;

namespace EquipmentDB.Forms.MainForms
{
    public partial class EmployeeEquipmentReportForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private readonly Employee _employee;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeeEquipmentReportForm(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<EmployeeEquipment>(empEq => empEq.EquipmentLeasing.Employee1.Employee_ID == _employee.Employee_ID).Where(equipment =>!equipment.EquipmentLeasing.IsArchive).ToList();
            dataGridView.ClearSelection();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            
            var saveFile = new SaveFileDialog()
            {
                Filter = "MS Word files (*.docx)|*.docx",
                FileName = $"Задолженность по оборудованию {_employee.EmployeeFio}.docx"
            };
            var data = dataGridView.DataSource as List<EmployeeEquipment>;

            if (saveFile.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var template = new EmployeeTemplate(_employee) { DataList = data })
                {
                    WordTemplateFiller.CreateWordDocument(template, saveFile.FileName);
                }
                var result = MessageBox.Show("Документ успешно создан. Открыть его для просмотра?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start(saveFile.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }



    }
}
