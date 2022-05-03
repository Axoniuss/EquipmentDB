using System;
using System.Collections.Generic;
using System.IO;
using EquipmentDB.Model;


namespace EquipmentDB.TemplateFiller
{
    public class EmployeeTemplate : IWordTemplate, IDisposable
    {
        private readonly object _data;
        private Microsoft.Office.Interop.Word._Document _document;
        public List<EmployeeEquipment> DataList { get; set; }

        public string TempFilePath { get; set; }
        public string TemplateName { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="data">Данные для заполнения</param>
        /// <param name="templateName">Название шаблона</param>
        public EmployeeTemplate(object data)
        {
            if (!(data is Employee))
                throw new InvalidOperationException("Не верный тип данных при заполнении шаблона");
            _data = data;
            TemplateName = "EmployeeTemplate";
        }

        public void FillFile(Microsoft.Office.Interop.Word._Document document)
        {
            var employee = _data as Employee;
            if (employee == null) return;
            _document = document;
            document.Application.Caption = "Оборудование выданное "+ employee;
            // имена полей заполняемых в документе
            // EmployeeOutPost, EmployeeOut, EmployeeIn, EmployeeInPost, DateIn, DateReturn 

            _document.Variables["Employee"].Value = employee.ToString();
            
            _document.Fields.Update();
            var table = _document.Tables[1];
           // table.Cell(2, 2).Range.Text = "кол-во";

            int i = 2;
            foreach (var equip in DataList)
            {
                table.Rows.Add();
                table.Cell(i, 1).Range.Text = equip.Equipment.ToString();
                table.Cell(i , 2).Range.Text = equip.InventoryNumber;
                table.Cell(i , 3).Range.Text = equip.Serial;
                table.Cell(i , 4).Range.Text = equip.DateIssue.ToShortDateString();
                table.Cell(i , 5).Range.Text = equip.DateReturn.ToShortDateString();
                table.Cell(i, 6).Range.Text = equip.BalanceType.ToString();
                table.Cell(i, 7).Range.Text = equip.Quantity.ToString();
                i++;
            }
        }

        private void ReleaseUnmanagedResources()
        {
            var app = _document?.Application;
            _document?.Close();
            app?.Quit();
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

        ~EmployeeTemplate()
        {
            ReleaseUnmanagedResources();
        }
    }
}
