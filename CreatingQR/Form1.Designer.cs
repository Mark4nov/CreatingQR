namespace CreatingQR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_GenerarQR = new System.Windows.Forms.Button();
            this.Btn_SaveQR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Img_QR = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Subtitulo = new System.Windows.Forms.TextBox();
            this.Btn_GenerarCodigo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_importarImagen = new System.Windows.Forms.Button();
            this.Img_IconoPreview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_QR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_IconoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(132, 17);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(347, 31);
            this.Txt_Codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto codigo:";
            // 
            // Btn_GenerarQR
            // 
            this.Btn_GenerarQR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarQR.Location = new System.Drawing.Point(16, 196);
            this.Btn_GenerarQR.Name = "Btn_GenerarQR";
            this.Btn_GenerarQR.Size = new System.Drawing.Size(463, 44);
            this.Btn_GenerarQR.TabIndex = 5;
            this.Btn_GenerarQR.Text = "Generar QR";
            this.Btn_GenerarQR.UseVisualStyleBackColor = true;
            // 
            // Btn_SaveQR
            // 
            this.Btn_SaveQR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveQR.Location = new System.Drawing.Point(76, 463);
            this.Btn_SaveQR.Name = "Btn_SaveQR";
            this.Btn_SaveQR.Size = new System.Drawing.Size(347, 44);
            this.Btn_SaveQR.TabIndex = 6;
            this.Btn_SaveQR.Text = "Guardar";
            this.Btn_SaveQR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Img_QR);
            this.panel1.Location = new System.Drawing.Point(76, 257);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(347, 200);
            this.panel1.TabIndex = 7;
            // 
            // Img_QR
            // 
            this.Img_QR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Img_QR.Location = new System.Drawing.Point(4, 4);
            this.Img_QR.Name = "Img_QR";
            this.Img_QR.Size = new System.Drawing.Size(339, 192);
            this.Img_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_QR.TabIndex = 3;
            this.Img_QR.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subtitulo:";
            // 
            // Txt_Subtitulo
            // 
            this.Txt_Subtitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subtitulo.Location = new System.Drawing.Point(132, 95);
            this.Txt_Subtitulo.Name = "Txt_Subtitulo";
            this.Txt_Subtitulo.Size = new System.Drawing.Size(347, 31);
            this.Txt_Subtitulo.TabIndex = 8;
            // 
            // Btn_GenerarCodigo
            // 
            this.Btn_GenerarCodigo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarCodigo.Location = new System.Drawing.Point(277, 54);
            this.Btn_GenerarCodigo.Name = "Btn_GenerarCodigo";
            this.Btn_GenerarCodigo.Size = new System.Drawing.Size(202, 35);
            this.Btn_GenerarCodigo.TabIndex = 10;
            this.Btn_GenerarCodigo.Text = "🎲 Generar código";
            this.Btn_GenerarCodigo.UseVisualStyleBackColor = true;
            this.Btn_GenerarCodigo.Click += new System.EventHandler(this.Btn_GenerarCodigo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ícono:";
            // 
            // Btn_importarImagen
            // 
            this.Btn_importarImagen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_importarImagen.Location = new System.Drawing.Point(277, 137);
            this.Btn_importarImagen.Name = "Btn_importarImagen";
            this.Btn_importarImagen.Size = new System.Drawing.Size(198, 35);
            this.Btn_importarImagen.TabIndex = 12;
            this.Btn_importarImagen.Text = "🖼️ Importar imagen";
            this.Btn_importarImagen.UseVisualStyleBackColor = true;
            this.Btn_importarImagen.Click += new System.EventHandler(this.Btn_ImportarImage_Click);
            // 
            // Img_IconoPreview
            // 
            this.Img_IconoPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Img_IconoPreview.Location = new System.Drawing.Point(132, 137);
            this.Img_IconoPreview.Name = "Img_IconoPreview";
            this.Img_IconoPreview.Size = new System.Drawing.Size(139, 35);
            this.Img_IconoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_IconoPreview.TabIndex = 13;
            this.Img_IconoPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 521);
            this.Controls.Add(this.Img_IconoPreview);
            this.Controls.Add(this.Btn_importarImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_GenerarCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Subtitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_SaveQR);
            this.Controls.Add(this.Btn_GenerarQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_QR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_IconoPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_GenerarQR;
        private System.Windows.Forms.Button Btn_SaveQR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Img_QR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Subtitulo;
        private System.Windows.Forms.Button Btn_GenerarCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_importarImagen;
        private System.Windows.Forms.PictureBox Img_IconoPreview;
    }
}

