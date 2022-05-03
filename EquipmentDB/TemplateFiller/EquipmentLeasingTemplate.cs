using System;
using System.IO;
using EquipmentDB.Model;


namespace EquipmentDB.TemplateFiller
{
    public class EmployeeEquipmentTemplate : IWordTemplate, IDisposable
    {
        private readonly object _data;
        private Microsoft.Office.Interop.Word._Document _document;

        public string TempFilePath { get; set; }
        public string TemplateName { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="data">Данные для заполнения</param>
        /// <param name="templateName">Название шаблона</param>
        public EmployeeEquipmentTemplate(object data)
        {
            if (!(data is EquipmentLeasing))
                throw new InvalidOperationException("Не верный тип данных при заполнении шаблона");
            _data = data;
            TemplateName = "EmployeeEquipmentTemplate";
        }

        public void FillFile(Microsoft.Office.Interop.Word._Document document)
        {
            var equipmentLeasing = _data as EquipmentLeasing;
            if (equipmentLeasing == null) return;
            _document = document;
            document.Application.Caption = "Акт приема передачи";
            // имена полей заполняемых в документе
            // EmployeeOutPost, EmployeeOut, EmployeeIn, EmployeeInPost, DateIn, DateReturn 

            _document.Variables["DateIn"].Value = equipmentLeasing.DateOfIssue.ToShortDateString();
            _document.Variables["EmpOutPost"].Value = equipmentLeasing.Employee.Post.ToString().ToLower();
            _document.Variables["EmployeeOut"].Value = equipmentLeasing.Employee.EmployeeFio;
            _document.Variables["EmployeeIn"].Value = equipmentLeasing.Employee1.EmployeeFio;
            _document.Variables["Organization"].Value = equipmentLeasing.Employee.Organization==null?
                " - ": 
                equipmentLeasing.Employee.Organization.OrganizationName;

            


            _document.Variables["EmployeeInPost"].Value = equipmentLeasing.Employee1.Post.ToString().ToLower();
            _document.Variables["ReturnDate"].Value = equipmentLeasing.DateReturn.ToShortDateString();
            _document.Fields.Update();
            var table = _document.Tables[3];
            int i = 1;
            foreach (var eq in equipmentLeasing.EmployeeEquipments)
            {
                table.Rows.Add();
                table.Cell(i + 1, 1).Range.Text = (i).ToString();
                table.Cell(i + 1, 2).Range.Text = eq.EquipmentStr;
                table.Cell(i + 1, 3).Range.Text = eq.Equipment.InventoryNumber;
                table.Cell(i + 1, 4).Range.Text = eq.Equipment.Serial;
                table.Cell(i + 1, 5).Range.Text = eq.Quantity.ToString();
                i++;
            }
        }

        private void ReleaseUnmanagedResources()
        {
            var app = _document.Application;
            _document.Close();
            app.Quit();
            if (File.Exists(TempFilePath))
            {
                File.Delete(TempFilePath);
            }
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~EmployeeEquipmentTemplate()
        {
            ReleaseUnmanagedResources();
        }
    }
}
