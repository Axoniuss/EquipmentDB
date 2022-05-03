using EquipmentDB.TemplateFiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Model.Verfication;
using Task = System.Threading.Tasks.Task;

namespace EquipmentDB.Forms.MainForms
{
    public partial class VerificationEquipmentForm : Form
    {
        private List<EquipemntExcel> _equipemntExcels;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public VerificationEquipmentForm(List<EquipemntExcel> equipemntExcels)
        {
            _equipemntExcels = equipemntExcels;
            InitializeComponent();
        }


        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _equipemntExcels;
        }
        //Метод: Оборудование на складе
        private void buttonInStore_Click(object sender, EventArgs e)
        {
            var data = dataGridView.DataSource as List<EquipemntExcel>;
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels.Where(eq => eq.EquipLocationStatus == EquipLocationStatus.InStock).ToList();
        }
        //Метод: Сброс фильтров
        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels;
        }
        //Метод: Оборудование во временном использовании
        private void buttonInEmplyee_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels.Where(eq => eq.EquipLocationStatus == EquipLocationStatus.InEmployee).ToList();
        }
        //Метод: Оборудование в эксплуатации (помещении)
        private void buttonInRoom_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels.Where(eq => eq.EquipLocationStatus == EquipLocationStatus.InRoom).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels.Where(eq => eq.EquipLocationStatus == EquipLocationStatus.WriteOff).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipemntExcels.Where(eq => eq.EquipLocationStatus == EquipLocationStatus.Unknown).ToList();
        }
        //Метод: Печати результата инвентаризационной сверки
        private async void button6_Click(object sender, EventArgs e)
        {
            var data = dataGridView.DataSource as List<EquipemntExcel>;
            //new ReportForm("VerificationReport"){EquipemntExcels = data}.ShowDialog();
            var saveFile = new SaveFileDialog()
            {
                Filter = "MS Word files (*.docx)|*.docx",
                FileName = "Результат инвентаризационной сверки.docx"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;
            MessageBox.Show("Документ формируется в фоновом режиме", "", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            await Task.Run(() =>
            {

                try
                {
                    using (var template = new VerificationTemplate(data))
                    {
                        WordTemplateFiller.CreateWordDocument(template, saveFile.FileName);
                    }
                    var result = MessageBox.Show("Документ успешно создан. Открыть его для просмотра?",
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var application = new Microsoft.Office.Interop.Word.Application();
                        application.Documents.Open(saveFile.FileName);
                        application.Visible = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            });
        }

    }
}
