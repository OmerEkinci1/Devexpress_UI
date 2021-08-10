
namespace AgteksDemo_UI.Forms
{
    partial class AddForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.btnPrediction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJsonText = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrediction
            // 
            this.btnPrediction.Location = new System.Drawing.Point(212, 169);
            this.btnPrediction.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(115, 33);
            this.btnPrediction.TabIndex = 15;
            this.btnPrediction.Text = "Prediction";
            this.btnPrediction.UseVisualStyleBackColor = true;
            this.btnPrediction.Click += new System.EventHandler(this.btnPrediction_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(353, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 532);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(96, 328);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(213, 184);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 12;
            this.pbPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(84, 169);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(115, 33);
            this.btnSelectImage.TabIndex = 16;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "JSON TEXT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "PRODUCT TYPE :";
            // 
            // txtJsonText
            // 
            this.txtJsonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJsonText.Location = new System.Drawing.Point(198, 242);
            this.txtJsonText.Name = "txtJsonText";
            this.txtJsonText.Size = new System.Drawing.Size(150, 27);
            this.txtJsonText.TabIndex = 20;
            // 
            // txtProductType
            // 
            this.txtProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType.Location = new System.Drawing.Point(198, 275);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(150, 27);
            this.txtProductType.TabIndex = 21;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 600);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.txtJsonText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnPrediction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrediction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJsonText;
        private System.Windows.Forms.TextBox txtProductType;
    }
}
