using System;
using System.Windows.Forms;
using EquipmentDB.Controller;

using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;


namespace EquipmentDB.Forms
{
    public partial class AboutForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public AboutForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
