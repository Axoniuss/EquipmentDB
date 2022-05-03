using System;

namespace EquipmentDB.TemplateFiller
{
    public interface IWordTemplate : IDisposable
    {
        string TempFilePath { get; set; }
        string TemplateName { get; }
        void FillFile(Microsoft.Office.Interop.Word._Document document);
    }
}
