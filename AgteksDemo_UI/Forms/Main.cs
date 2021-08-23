using AgteksDemo_UI.Helpers;
using AgteksDemo_UI.Models;
using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Services;
using DevExpress.XtraBars;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public void populateGridview()
        {
            var result = IntegrationService.GetAll();
            dataGridView1.DataSource = result;
            var imageByteColumn = result.AsEnumerable()
                                        .Select(s => s.Field<string>("PICTURE"))
                                        .Distinct()
                                        .ToList();
            // TAKE BYTE ARRAY DATAS FROM JSON.
            Bitmap y = null;
            var picture = y;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                foreach (var item in imageByteColumn)
                {
                    string imageSource = item;
                    Bitmap bmpFromString = BitmapHelper.Base64StringToBitmap(imageSource);
                    picture = new Bitmap(bmpFromString);
                    break;
                }
                dataGridView1.Rows[i].Cells["bitmapImage"].Value = picture;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                lblJsonText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblInsDt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblisProcessed.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblProcessedDt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                lblProductType.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                // CONVERT STRİNG TO BASE64 // PRINT IMAGE TO PICTUREBOX
                string imageSource = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Bitmap bmpFromString = BitmapHelper.Base64StringToBitmap(imageSource);
                var picture = new Bitmap(bmpFromString); // picture format
                pbPicture.Image = picture;
            }
        }

        public string DataTableToJSONWithStringBuilder(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteSelectedItem()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
