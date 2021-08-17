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
using AgteksDemo_UI.Models.Responses;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing.Imaging;
using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Helpers;

namespace AgteksDemo_UI.Forms
{
    public partial class AddForm : Form
    {
        Integration integration = new Integration();
        public Socket sendSocket;
        
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

        public void Add(Integration integration)
        {
            // CONVERT IMAGE BITMAP TO BASE64
            byte[] imageArray = BitmapHelper.imageToByteArray(pbPicture.Image);
            integration.PICTURE = imageArray;
            integration.JSON_TEXT = txtJsonText.Text;
            integration.PRODUCT_TYPE = Convert.ToInt16(txtProductType.Text);
            IntegrationService.Add(integration);

            // SAVE BITMAP TO LOCAL FOLDER
            string fileName = DateTime.Now.ToString("MM-dd-yyyy-HHmmss") + "_" + integration.JSON_TEXT;
            //Bitmap bitmapImage = BitmapHelper.ByteArrayToImage(imageArray);
            string folderName = @"C:\services\";
            string pathString = System.IO.Path.Combine(folderName, "Images");
            pathString = System.IO.Path.Combine(pathString, fileName);
            //bitmapImage.Save(pathString + ".bmp", ImageFormat.Bmp); // GDI HATASI VERİYOR, RESMİ BOZUK ATIYOR.

            using (Bitmap bitmapImage = BitmapHelper.ByteArrayToImage(imageArray))
            {
                using (Graphics graphics = Graphics.FromImage(bitmapImage))
                {
                    graphics.Clear(Color.Transparent);
                    graphics.DrawImage(pictureBox1.Image, new Point(0, 0));
                }
                bitmapImage.Save(pathString + ".bmp", ImageFormat.Bmp);
            }
        }
    }
}
