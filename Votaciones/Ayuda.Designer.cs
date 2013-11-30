namespace Votaciones
{
    partial class FormAyuda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyudar = new System.Windows.Forms.Button();
            this.txtIncidencias = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.wbSolucion = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soporte Técnico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Problema";
            // 
            // btnAyudar
            // 
            this.btnAyudar.Location = new System.Drawing.Point(279, 123);
            this.btnAyudar.Name = "btnAyudar";
            this.btnAyudar.Size = new System.Drawing.Size(75, 23);
            this.btnAyudar.TabIndex = 2;
            this.btnAyudar.Text = "Ver solución";
            this.btnAyudar.UseVisualStyleBackColor = true;
            this.btnAyudar.Click += new System.EventHandler(this.btnAyudar_Click);
            // 
            // txtIncidencias
            // 
            this.txtIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIncidencias.FormattingEnabled = true;
            this.txtIncidencias.Location = new System.Drawing.Point(12, 87);
            this.txtIncidencias.Name = "txtIncidencias";
            this.txtIncidencias.Size = new System.Drawing.Size(353, 21);
            this.txtIncidencias.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1255, 679);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visitar Página Oficial";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 52);
            this.label5.TabIndex = 7;
            this.label5.Text = "Para mayor información favor de contactarnos\r\n                    TEL:    331-289" +
                "-0626\r\n        e-mail: UrnaDevelop@gmail.com\r\n          WEB: www.UrnaElectronica" +
                ".es.tl";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(160, 507);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 75);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // wbSolucion
            // 
            this.wbSolucion.Location = new System.Drawing.Point(383, 60);
            this.wbSolucion.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSolucion.Name = "wbSolucion";
            this.wbSolucion.Size = new System.Drawing.Size(975, 602);
            this.wbSolucion.TabIndex = 22;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 704);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wbSolucion);
            this.Controls.Add(this.btnAyudar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncidencias);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FormAyuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIncidencias;
        private System.Windows.Forms.Button btnAyudar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser wbSolucion;
    }
}