using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace ImageResizerAndLogoAdder
{
    public partial class Form1 : Form
    {
        DirectoryInfo InputFolderDir;
        bool InputFolderSet = false;
        string WatermarkPath = "";
        bool WatermarkPathSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if(InputFolderSet == true)
            {
                if(IncludeLogoChk.Checked == true)
                {
                    if(WatermarkPathSet == true)
                    {
                        Convert();
                        WarningMessage.Text = "";
                    }
                    else
                    {
                        WarningMessage.Text = "You must choose the logo/watermark file first.";
                    }
                }
                else
                {
                    Convert();
                    WarningMessage.Text = "";
                }
            }
            else
            {
                WarningMessage.Text = "You must set the input folder first before trying to convert files.";
            }
        }


        /*
         * code to write text over image. Not needed, but a possibility for the future.
using (Font arialFont = new Font("Arial", 20))
{
    PointF Location = new PointF(100f, 1000f);
    imageGraphics.DrawString(WebSite, arialFont, Brushes.Blue, Location);
}
*/



        void Convert()
        {
            //string output = "";
            var ext = new List<string> { ".jpg", ".gif", ".png" };
            if (IncludeSubDirsCheck.Checked == true)
            {
                foreach (var file in InputFolderDir.GetFiles("*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s.FullName).ToLowerInvariant())))
                {
                    using (var srcImage = Image.FromFile(file.FullName.ToString()))
                    {
                        var newWidth = (int)Xaxis.Value;
                        var newHeight = (int)Yaxis.Value;
                        using (var newImage = new Bitmap(newWidth, newHeight))
                        using (var graphics = Graphics.FromImage(newImage))

                        {
                            if (QualityBar.Value == 0)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                                graphics.InterpolationMode = InterpolationMode.Low;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                            }
                            else if (QualityBar.Value == 1)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                                graphics.InterpolationMode = InterpolationMode.Low;
                                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                            }
                            else if (QualityBar.Value == 2)
                            {
                                graphics.SmoothingMode = SmoothingMode.Default;
                                graphics.InterpolationMode = InterpolationMode.Default;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.Default;
                            }
                            else if (QualityBar.Value == 3)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighQuality;
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.HighQuality;
                            }
                            else if (QualityBar.Value == 4)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighQuality;
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                                graphics.CompositingQuality = CompositingQuality.AssumeLinear;
                            }
                            graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                            if (WatermarkPathSet == true && IncludeLogoChk.Checked == true)
                            {
                                using (Image watermarkImage = Image.FromFile(WatermarkPath))
                                using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                                {
                                    int x = (int)logoxaxis.Value;
                                    int y = (int)logoyaxis.Value;
                                    watermarkBrush.TranslateTransform(x, y);
                                    graphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width, watermarkImage.Height)));
                                }
                            }
                            if (QualityBar.Value == 0)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".JPEG", System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            else if (QualityBar.Value == 1)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                            }
                            else if (QualityBar.Value == 2)
                            {
                                newImage.Save("Resized_" + file.ToString());
                            }
                            else if (QualityBar.Value == 3)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                            }
                            else if (QualityBar.Value == 4)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var file in InputFolderDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Where(s => ext.Contains(Path.GetExtension(s.FullName).ToLowerInvariant())))
                {
                    using (var srcImage = Image.FromFile(file.FullName.ToString()))
                    {
                        var newWidth = (int)Xaxis.Value;
                        var newHeight = (int)Yaxis.Value;
                        using (var newImage = new Bitmap(newWidth, newHeight))
                        using (var graphics = Graphics.FromImage(newImage))

                        {
                            if (QualityBar.Value == 0)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                                graphics.InterpolationMode = InterpolationMode.Low;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                            }
                            else if (QualityBar.Value == 1)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                                graphics.InterpolationMode = InterpolationMode.Low;
                                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                            }
                            else if (QualityBar.Value == 2)
                            {
                                graphics.SmoothingMode = SmoothingMode.Default;
                                graphics.InterpolationMode = InterpolationMode.Default;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.Default;
                            }
                            else if (QualityBar.Value == 3)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighQuality;
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = PixelOffsetMode.Half;
                                graphics.CompositingQuality = CompositingQuality.HighQuality;
                            }
                            else if (QualityBar.Value == 4)
                            {
                                graphics.SmoothingMode = SmoothingMode.HighQuality;
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                                graphics.CompositingQuality = CompositingQuality.AssumeLinear;
                            }
                            graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                            if (WatermarkPathSet == true && IncludeLogoChk.Checked == true)
                            {
                                using (Image watermarkImage = Image.FromFile(WatermarkPath))
                                using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                                {
                                    int x = (int)logoxaxis.Value;
                                    int y = (int)logoyaxis.Value;
                                    watermarkBrush.TranslateTransform(x, y);
                                    graphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width, watermarkImage.Height)));
                                }
                            }
                            if (QualityBar.Value == 0)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".JPEG", System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            else if (QualityBar.Value == 1)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                            }
                            else if (QualityBar.Value == 2)
                            {
                                newImage.Save("Resized_" + file.ToString());
                            }
                            else if (QualityBar.Value == 3)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                            }
                            else if (QualityBar.Value == 4)
                            {
                                newImage.Save("Resized_" + file.ToString() + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            }
                        }
                    }
                }
            }
        }


        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = InputFolder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(InputFolder.SelectedPath))
            {
                InputFolderDir = new DirectoryInfo(InputFolder.SelectedPath);
                InputFolderSet = true;
            }
        }

        private void ChooseLogoBtn_Click(object sender, EventArgs e)
        {
            WaterMarkChooser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            WaterMarkChooser.FileName = "";
            DialogResult result = WaterMarkChooser.ShowDialog();
            WatermarkPath = WaterMarkChooser.FileName.ToString();
            WatermarkPathSet = true;
        }

        private void IncludeLogoChk_CheckedChanged(object sender, EventArgs e)
        {
            LogoSettings.Enabled = IncludeLogoChk.Checked;
        }

    }
}
