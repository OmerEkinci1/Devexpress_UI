using AgteksDemo_UI.Services;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgteksDemo_UI.Forms
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly IntegrationService _integrationService;

        public Main(IntegrationService integrationService)
        {
            integrationService = _integrationService;
        }
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populateGridView()
        {
            //string apiGetAll = "https://localhost:44368/api/integrations/getall";
            //_integrationService.GetAll(apiGetAll);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            populateGridView();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
