﻿namespace Votaciones
{
    partial class FormGenerales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPartido = new System.Windows.Forms.Button();
            this.txtPartidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargo = new System.Windows.Forms.Button();
            this.txtCargos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCandidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIngresoCandidatos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 621);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(16, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPartido);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartidos);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pbLogo);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFecha);
            this.splitContainer1.Panel1.Controls.Add(this.txtFecha);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargo);
            this.splitContainer1.Panel1.Controls.Add(this.txtCargos);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtMostrar);
            this.splitContainer1.Size = new System.Drawing.Size(750, 527);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnPartido
            // 
            this.btnPartido.Location = new System.Drawing.Point(258, 469);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(90, 23);
            this.btnPartido.TabIndex = 23;
            this.btnPartido.Text = "Nuevo Partido";
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // txtPartidos
            // 
            this.txtPartidos.Location = new System.Drawing.Point(87, 250);
            this.txtPartidos.Name = "txtPartidos";
            this.txtPartidos.Size = new System.Drawing.Size(261, 20);
            this.txtPartidos.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Partidos";
            // 
            // pbLogo
            // 
            this.pbLogo.Enabled = false;
            this.pbLogo.Location = new System.Drawing.Point(111, 290);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(219, 162);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Registros generalizados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seleccionar logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click aquí");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(258, 199);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(90, 23);
            this.btnFecha.TabIndex = 14;
            this.btnFecha.Text = "Nueva Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(136, 173);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(212, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Periodo Duración";
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(258, 121);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(90, 23);
            this.btnCargo.TabIndex = 11;
            this.btnCargo.Text = "Nuevo Cargo";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // txtCargos
            // 
            this.txtCargos.Location = new System.Drawing.Point(87, 95);
            this.txtCargos.Name = "txtCargos";
            this.txtCargos.Size = new System.Drawing.Size(261, 20);
            this.txtCargos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Registros Guardados";
            // 
            // txtMostrar
            // 
            this.txtMostrar.Enabled = false;
            this.txtMostrar.FormattingEnabled = true;
            this.txtMostrar.Location = new System.Drawing.Point(10, 47);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(345, 459);
            this.txtMostrar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.ToolTipText = "Recueda GUARDAR los cambio";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatosToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroCandidatosToolStripMenuItem,
            this.partidosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.organizadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // registroCandidatosToolStripMenuItem
            // 
            this.registroCandidatosToolStripMenuItem.Name = "registroCandidatosToolStripMenuItem";
            this.registroCandidatosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.registroCandidatosToolStripMenuItem.Text = "Candidatos";
            this.registroCandidatosToolStripMenuItem.Click += new System.EventHandler(this.registroCandidatosToolStripMenuItem_Click);
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.partidosToolStripMenuItem.Text = "Partidos";
            this.partidosToolStripMenuItem.Click += new System.EventHandler(this.partidosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // organizadosToolStripMenuItem
            // 
            this.organizadosToolStripMenuItem.Name = "organizadosToolStripMenuItem";
            this.organizadosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.organizadosToolStripMenuItem.Text = "Todos";
            this.organizadosToolStripMenuItem.Click += new System.EventHandler(this.organizadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPlanillaToolStripMenuItem,
            this.páginaSoporteToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ingresarPlanillaToolStripMenuItem
            // 
            this.ingresarPlanillaToolStripMenuItem.Name = "ingresarPlanillaToolStripMenuItem";
            this.ingresarPlanillaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ingresarPlanillaToolStripMenuItem.Text = "Manual ";
            // 
            // páginaSoporteToolStripMenuItem
            // 
            this.páginaSoporteToolStripMenuItem.Name = "páginaSoporteToolStripMenuItem";
            this.páginaSoporteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.páginaSoporteToolStripMenuItem.Text = "Página Soporte";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúAdministradorToolStripMenuItem,
            this.páginaPrincipalToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // menúAdministradorToolStripMenuItem
            // 
            this.menúAdministradorToolStripMenuItem.Name = "menúAdministradorToolStripMenuItem";
            this.menúAdministradorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.menúAdministradorToolStripMenuItem.Text = "Menú Administrador";
            this.menúAdministradorToolStripMenuItem.Click += new System.EventHandler(this.menúAdministradorToolStripMenuItem_Click);
            // 
            // páginaPrincipalToolStripMenuItem
            // 
            this.páginaPrincipalToolStripMenuItem.Name = "páginaPrincipalToolStripMenuItem";
            this.páginaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.páginaPrincipalToolStripMenuItem.Text = "Página Principal";
            this.páginaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.páginaPrincipalToolStripMenuItem_Click);
            // 
            // btnIngresoCandidatos
            // 
            this.btnIngresoCandidatos.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresoCandidatos.Image")));
            this.btnIngresoCandidatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoCandidatos.Location = new System.Drawing.Point(611, 639);
            this.btnIngresoCandidatos.Name = "btnIngresoCandidatos";
            this.btnIngresoCandidatos.Size = new System.Drawing.Size(155, 36);
            this.btnIngresoCandidatos.TabIndex = 8;
            this.btnIngresoCandidatos.Text = "Ingresar Candidatos";
            this.toolTip1.SetToolTip(this.btnIngresoCandidatos, "Si no has terminado esta parte puedes tener problemas.\r\n");
            this.btnIngresoCandidatos.UseVisualStyleBackColor = true;
            this.btnIngresoCandidatos.Click += new System.EventHandler(this.btnIngresoCandidatos_Click);
            // 
            // FormGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1376, 710);
            this.Controls.Add(this.btnIngresoCandidatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGenerales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Datos Generales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGenerales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCandidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.TextBox txtCargos;
        private System.Windows.Forms.ListBox txtMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresoCandidatos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.TextBox txtPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}