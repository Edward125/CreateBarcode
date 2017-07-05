using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using Edward;
using ZXing.Common;

namespace CreateBarcode
{
    public partial class frmOtherBarcodeFormat : Form
    {
        public frmOtherBarcodeFormat()
        {
            InitializeComponent();
        }

        private void loadUI()
        {
            Type bartype = typeof(BarcodeFormat);
            foreach (string s in Enum.GetNames(bartype))
            {
                comboFormate.Items.Add(s);
            }
            if (comboFormate.Items.Count > 0)
                comboFormate.SelectedIndex = 0;

            grbOther.Text = "BarCode Format:" + comboFormate.Text;
            txtInput.SetWatermark("Input what you want to create barcode...");
        }

        private void frmOtherBarcodeFormat_Load(object sender, EventArgs e)
        {
            loadUI();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtInput.Text.Trim()))
                return;

            picBar.Image = CreateBarCode(txtInput.Text.Trim(), (BarcodeFormat)Enum.Parse(typeof(BarcodeFormat), comboFormate.Text), picBar);
           
        }

        /// <summary>
        /// 一维码生成
        /// </summary>
        /// <param name="contents"></param>
        public static Bitmap CreateBarCode(string contents, BarcodeFormat format, PictureBox pic)
        {

            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = pic.Width,
                Height = pic.Height
            };
            writer = new BarcodeWriter();
            writer.Format = format;
            writer.Options = options;
            Bitmap bitmap = null;
            try
            {
                bitmap = writer.Write(contents);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            return bitmap;
        }

        private void picBar_DoubleClick(object sender, EventArgs e)
        {
            if (picBar.Image == null)
            {

            }
            else
                saveImg(picBar);
        
        }

        private void saveImg(PictureBox picbar)
        {
            //Bitmap bit = new Bitmap(picbar.BackgroundImage);
            Image img = picbar.Image;
            string filename = @"./" + comboFormate.Text + "-" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".png";
            //picbar.BackgroundImage.Save(filename);
            img.Save(filename);
            MessageBox.Show(comboFormate.Text + "-" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".png" + ",save OK");

        }

        private void comboFormate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text.Trim()))
                return;
            grbOther.Text = comboFormate.Text;
            picBar.Image = CreateBarCode(txtInput.Text.Trim(), (BarcodeFormat)Enum.Parse(typeof(BarcodeFormat), comboFormate.Text), picBar);
        }

    
    }
}
