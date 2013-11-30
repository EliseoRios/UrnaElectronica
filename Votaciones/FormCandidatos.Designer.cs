namespace Votaciones
{
    partial class FormCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCandidatos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCandidato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosYPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCandidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 685);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPeriodo);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPartido);
            this.panel3.Controls.Add(this.txtCargo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnCandidato);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(26, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 609);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPeriodo.FormattingEnabled = true;
            this.txtPeriodo.Location = new System.Drawing.Point(135, 252);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(361, 21);
            this.txtPeriodo.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(41, 371);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(542, 151);
            this.txtDescripcion.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descripción breve";
            // 
            // txtPartido
            // 
            this.txtPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPartido.FormattingEnabled = true;
            this.txtPartido.Location = new System.Drawing.Point(135, 193);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(361, 21);
            this.txtPartido.TabIndex = 34;
            // 
            // txtCargo
            // 
            this.txtCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCargo.FormattingEnabled = true;
            this.txtCargo.Location = new System.Drawing.Point(135, 140);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(361, 21);
            this.txtCargo.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Registro candidatos";
            // 
            // btnCandidato
            // 
            this.btnCandidato.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCandidato.Image = ((System.Drawing.Image)(resources.GetObject("btnCandidato.Image")));
            this.btnCandidato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidato.Location = new System.Drawing.Point(498, 552);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Size = new System.Drawing.Size(105, 34);
            this.btnCandidato.TabIndex = 31;
            this.btnCandidato.Text = "Guardar";
            this.btnCandidato.UseVisualStyleBackColor = false;
            this.btnCandidato.Click += new System.EventHandler(this.btnCandidato_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Partido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 90);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(361, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cargo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMostrar);
            this.panel2.Location = new System.Drawing.Point(692, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 609);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Registros Guardados\r\n  (CANDIDATOS)";
            // 
            // txtMostrar
            // 
            this.txtMostrar.FormattingEnabled = true;
            this.txtMostrar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMostrar.Location = new System.Drawing.Point(47, 114);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(531, 420);
            this.txtMostrar.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.ToolTipText = "Recueda GUARDAR los cambio";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosYPartidosToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // cargosYPartidosToolStripMenuItem
            // 
            this.cargosYPartidosToolStripMenuItem.Name = "cargosYPartidosToolStripMenuItem";
            this.cargosYPartidosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cargosYPartidosToolStripMenuItem.Text = "Generales";
            this.cargosYPartidosToolStripMenuItem.Click += new System.EventHandler(this.cargosYPartidosToolStripMenuItem_Click);
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúAdministradorToolStripMenuItem,
            this.páginaPrincipalToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Ir";
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
            this.páginaSoporteToolStripMenuItem.Click += new System.EventHandler(this.páginaSoporteToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1316, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 704);
            this.Controls.Add(this.panel1);
            this.Name = "FormCandidatos";
            this.Text = "Ingreso Candidatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCandidatos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosYPartidosToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox txtMostrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtPeriodo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtPartido;
        private System.Windows.Forms.ComboBox txtCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCandidato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}