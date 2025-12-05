using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace CreatingQR
{
    public partial class Form1 : Form
    {
        private Bitmap currentQr;
        private Bitmap logoBitmap;

        public Form1()
        {
            InitializeComponent();
            this.Btn_GenerarQR.Click += Btn_GenerarQR_Click;
            this.Btn_SaveQR.Click += Btn_SaveQR_Click;
        }

        private void Btn_ImportarImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dispose previous logo
                        logoBitmap?.Dispose();
                        // Load as Bitmap (create copy to avoid locking file)
                        using (var tmp = new Bitmap(ofd.FileName))
                        {
                            logoBitmap = new Bitmap(tmp);
                        }

                        // Update button text briefly to show loaded
                        Img_IconoPreview.Image = logoBitmap;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar el icono: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_GenerarQR_Click(object sender, EventArgs e)
        {
            var text = Txt_Codigo.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Ingrese un texto para generar el QR.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var qrGenerator = new QRCodeGenerator())
                using (var qrData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q))
                using (var qrCode = new QRCode(qrData))
                {
                    // GetGraphic(size) returns a Bitmap
                    using (var bmp = qrCode.GetGraphic(20))
                    using (var composed = ComposeQrWithLogoAndSubtitle(bmp, logoBitmap, Txt_Subtitulo?.Text))
                    {
                        // Dispose previous image
                        currentQr?.Dispose();
                        currentQr = new Bitmap(composed);
                        Img_QR.Image = currentQr;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar QR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Compose final image with optional centered logo and optional subtitle below the QR.
        /// </summary>
        private Bitmap ComposeQrWithLogoAndSubtitle(Bitmap qrBmp, Bitmap logo, string subtitle)
        {
            if (qrBmp == null) throw new ArgumentNullException(nameof(qrBmp));

            // Start with the QR image
            Bitmap result = null;

            // Determine subtitle height
            int subtitleHeight = 0;
            Font subtitleFont = null;
            SizeF measured = SizeF.Empty;
            if (!string.IsNullOrWhiteSpace(subtitle))
            {
                subtitleFont = new Font("Calibri", 44F, FontStyle.Bold);
                using (var g = Graphics.FromImage(qrBmp))
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    measured = g.MeasureString(subtitle, subtitleFont);
                }
                subtitleHeight = (int)Math.Ceiling(measured.Height) + 10; // padding
            }

            int finalWidth = qrBmp.Width;
            int finalHeight = qrBmp.Height + subtitleHeight;

            result = new Bitmap(finalWidth, finalHeight);

            using (var g = Graphics.FromImage(result))
            {
                // White background
                g.Clear(Color.White);

                // Improve quality
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // Draw QR centered horizontally at top
                int qrX = (finalWidth - qrBmp.Width) / 2;
                g.DrawImage(qrBmp, qrX, 0, qrBmp.Width, qrBmp.Height);

                // Draw logo if provided
                if (logo != null)
                {
                    // Calculate logo size (max 20% of QR width)
                    int maxLogoWidth = (int)(qrBmp.Width * 0.20f);
                    int maxLogoHeight = (int)(qrBmp.Height * 0.20f);

                    int logoW = logo.Width;
                    int logoH = logo.Height;

                    // Scale preserving aspect ratio
                    float scale = Math.Min((float)maxLogoWidth / logoW, (float)maxLogoHeight / logoH);
                    if (scale > 1f) scale = 1f; // don't upscale

                    int drawW = (int)(logoW * scale);
                    int drawH = (int)(logoH * scale);

                    int logoX = qrX + (qrBmp.Width - drawW) / 2;
                    int logoY = (qrBmp.Height - drawH) / 2;

                    // Optional: draw a white rounded background behind logo to improve contrast
                    using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int padding = 6;
                        var rect = new Rectangle(logoX - padding, logoY - padding, drawW + padding * 2, drawH + padding * 2);
                        int radius = Math.Min(rect.Width, rect.Height) / 16;
                        // Rounded rectangle
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseFigure();

                        using (var brush = new SolidBrush(Color.White))
                        {
                            g.FillPath(brush, path);
                        }

                        // Draw logo image
                        g.DrawImage(logo, new Rectangle(logoX, logoY, drawW, drawH));
                    }
                }

                // Draw subtitle if provided
                if (!string.IsNullOrWhiteSpace(subtitle) && subtitleFont != null)
                {
                    using (var brush = new SolidBrush(Color.Black))
                    using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    {
                        var textRect = new RectangleF(0, qrBmp.Height + 5, finalWidth, subtitleHeight);
                        g.DrawString(subtitle, subtitleFont, brush, textRect, sf);
                    }
                }
            }

            return result;
        }

        private void Btn_SaveQR_Click(object sender, EventArgs e)
        {
            if (Img_QR.Image == null)
            {
                MessageBox.Show("No hay imagen para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.FileName = "qrcode.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;
                    var ext = Path.GetExtension(sfd.FileName).ToLowerInvariant();
                    if (ext == ".jpg" || ext == ".jpeg") format = ImageFormat.Jpeg;
                    else if (ext == ".bmp") format = ImageFormat.Bmp;

                    try
                    {
                        Img_QR.Image.Save(sfd.FileName, format);
                        MessageBox.Show("Guardado correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            currentQr?.Dispose();
            logoBitmap?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
