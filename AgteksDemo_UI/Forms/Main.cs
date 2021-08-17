using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Services;
using DevExpress.XtraBars;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgteksDemo_UI.Forms
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblSelectedLanguage.Text = "C#/Devexpress";

            // RAM USAGE
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            lblCurrentRamUsage.Text = percentOccupied.ToString() + " MB"; // Makinenin kullandığı anlık RAM'i gösterir.
            lblTotalRamUsage.Text = tot.ToString() + " MB";

            // POPULATE GRIDVIEW
            populateGridview();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }

        private void populateGridview()
        {
            var result = IntegrationService.GetAll();
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            lblJsonText.Text     =   dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lblInsDt.Text        =   dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lblisProcessed.Text  =   dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            lblProcessedDt.Text  =   dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            lblProductType.Text  =   dataGridView1.SelectedRows[0].Cells[6].Value.ToString();       
        }
    }
}
