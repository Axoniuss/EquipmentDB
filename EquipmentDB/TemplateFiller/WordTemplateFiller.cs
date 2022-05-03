using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EquipmentDB.TemplateFiller
{
    public class WordTemplateFiller
    {
        /// <summary>
        /// Путь к папке с шаблонами
        /// </summary>
        private static readonly string TemplatesPath = Directory.GetCurrentDirectory() + "\\Templates\\";

        /// <summary>
        ///  Метод создания отчёта в Word
        /// </summary>
        /// <param name="template"></param>
        /// <param name="saveFilePath">Путь для сохранения файла</param>
        public static void CreateWordDocument(IWordTemplate template, string saveFilePath)
        {
            IWordTemplate wordTemplate = template;

            var file = TemplatesPath + template.TemplateName;

            if (!CheckTemplateAvailability(file)) return;

            // создём копию шаблона
            var source = CreateTempFile(file);

            template.TempFilePath = source;
            // --- Открываем шаблон документа
            var application = new Word.Application();
            var document = application.Documents.Open(source);
            wordTemplate.FillFile(document);
            document.SaveAs(saveFilePath);
        }

        /// <summary>
        /// Метод создания временного файла
        /// </summary>
        private static string CreateTempFile(string path)
        {
            var destFileName = path + "Temp";
            if (!File.Exists(destFileName))
            {
                File.Copy(path, destFileName, true);
            }
            return destFileName;
        }

        /// <summary>
        /// Метод проверки наличия шаблона
        /// </summary>
        /// <returns></returns>
        private static bool CheckTemplateAvailability(string templatePath)
        {
            if (File.Exists(templatePath)) return true;
            MessageBox.Show("Не найден файл EmployeeEquipmentTemplate в папке шаблонов Templates ", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

    }





}
