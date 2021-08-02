using AgteksDemo_UI.Models.Helpers;
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
    public partial class MainPage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            lblRamUsage.Text = percentOccupied.ToString(); // Makinenin kullandığı anlık RAM'i gösterir.
        }
    }
}
