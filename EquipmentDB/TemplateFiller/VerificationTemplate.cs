using System;
using System.Collections.Generic;
using System.IO;
using EquipmentDB.Model.Verfication;

namespace EquipmentDB.TemplateFiller
{
    public class VerificationTemplate : IWordTemplate, IDisposable
    {
        private readonly object _data;
        private Microsoft.Office.Interop.Word._Document _document;

        public string TempFilePath { get; set; }
       public string TemplateName { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="data">Данные для заполнения</param>
        public VerificationTemplate(object data)
        {
            if (!(data is List<EquipemntExcel>))
                throw new InvalidOperationException("Не верный тип данных при заполнении шаблона");
            _data = data;
            TemplateName = "VerificationTemplate";
        }

        public void FillFile(Microsoft.Office.Interop.Word._Document document)
        {
            var data = _data as List<EquipemntExcel>;
            if (data == null) return;
            _document = document;
            document.Application.Caption = "Результат сверки инвентаризационной описи";

            _document.Fields.Update();
            var table = _document.Tables[1];


            int i = 1;
            foreach (var equip in data)
            {
                table.Rows.Add();
                table.Cell(i+1, 1).Range.Text = i.ToString();
                table.Cell(i+1, 2).Range.Text = equip.EquipmentNameExcel;
                table.Cell(i+1, 3).Range.Text = equip.InventoryNumberExcel;
                table.Cell(i+1, 4).Range.Text = equip.EquipmentLocation;
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

        ~VerificationTemplate()
        {
            ReleaseUnmanagedResources();
        }
    }
}
