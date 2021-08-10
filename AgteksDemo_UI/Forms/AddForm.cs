using AgteksDemo_UI.Models;
using AgteksDemo_UI.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgteksDemo_UI.Connection;
using System.Buffers.Text;
using NPOI.Util;

namespace AgteksDemo_UI.Forms
{
    public partial class AddForm : Form
    {
        private IntegrationService _integrationService;
        Integration integration = new Integration();
        public Socket sendSocket;
        public AddForm(IntegrationService integrationService)
        {
            _integrationService = integrationService;            
        }

        public AddForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(integration);
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            var sendingImageData = pbPicture.Image.ToString();

            byte[] imageArray = File.ReadAllBytes(sendingImageData);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            AsynchronousClient.Send(sendSocket, base64ImageRepresentation);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pbPicture.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add(Integration integration)
        {
            integration.JSON_TEXT = txtJsonText.Text;
            integration.PRODUCT_TYPE = Convert.ToInt16(txtProductType.Text);
            integration.PICTURE = pbPicture.Image.ToString();
            _integrationService.Add(integration);
        }
    }
}
