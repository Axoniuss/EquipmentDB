using System;
using System.IO;
using EquipmentDB.Model;



namespace EquipmentDB.TemplateFiller
{
   public class RoomPassportTemplate:IWordTemplate, IDisposable
    {
        private readonly object _data;

        private Microsoft.Office.Interop.Word._Document _document;

        public string TempFilePath { get; set; }
        public string TemplateName { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="data">Данные для заполнения</param>
        /// <param name="templateName">Название шаблона</param>
        public RoomPassportTemplate(object data)
        {
            if (!(data is Room))
                throw new InvalidOperationException("Не верный тип данных при заполнении шаблона");
            _data = data;
            TemplateName = "RoomPassportTemplate";
        }

        public void FillFile(Microsoft.Office.Interop.Word._Document document)
        {
            var room = _data as Room;
            if (room == null) return;
            _document = document;
            _document.Application.Caption = "Паспорт помещения";
            // имена полей заполняемых в документе
            // Room, Adress, CurrentDate

            _document.Variables["Room"].Value = room.ToString();
            _document.Variables["Adress"].Value = room.Corps.Adress;
            _document.Variables["CurrentDate"].Value = DateTime.Now.Date.ToShortDateString();

            _document.Fields.Update();
            var table = _document.Tables[1];
            int i = 2;
            foreach (var er in room.EmployeeRooms)
            {
                table.Rows.Add();
                table.Cell(i , 1).Range.Text = (i-1).ToString();
                table.Cell(i , 2).Range.Text = er.EmployeeStr;
                table.Cell(i , 3).Range.Text = er.Date.ToShortDateString();
                i++;
            }
            table = _document.Tables[2];
             i = 2;
            foreach (var er in room.RoomEquipments)
            {
                table.Rows.Add();
                table.Cell(i, 1).Range.Text = (i - 1).ToString();
                table.Cell(i, 2).Range.Text = er.Equipment.ToString();
                table.Cell(i, 4).Range.Text = er.EquipInventoryNumber;
                table.Cell(i, 5).Range.Text = er.DateOfIssue.ToShortDateString();
                table.Cell(i, 6).Range.Text = er.Quantity.ToString();

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

        ~RoomPassportTemplate()
        {
            ReleaseUnmanagedResources();
        }
    }
}
