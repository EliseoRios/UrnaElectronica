namespace Votaciones
{
    partial class FormNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNumeros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerCogigos = new System.Windows.Forms.Button();
            this.txtGenerados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wbPDF = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosYPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVerCogigos);
            this.panel1.Controls.Add(this.txtGenerados);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.wbPDF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLista);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 747);
            this.panel1.TabIndex = 11;
            // 
            // btnVerCogigos
            // 
            this.btnVerCogigos.Location = new System.Drawing.Point(1229, 44);
            this.btnVerCogigos.Name = "btnVerCogigos";
            this.btnVerCogigos.Size = new System.Drawing.Size(75, 23);
            this.btnVerCogigos.TabIndex = 36;
            this.btnVerCogigos.Text = "Ver Códigos";
            this.btnVerCogigos.UseVisualStyleBackColor = true;
            this.btnVerCogigos.Click += new System.EventHandler(this.btnVerCogigos_Click);
            // 
            // txtGenerados
            // 
            this.txtGenerados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGenerados.FormattingEnabled = true;
            this.txtGenerados.Location = new System.Drawing.Point(802, 46);
            this.txtGenerados.Name = "txtGenerados";
            this.txtGenerados.Size = new System.Drawing.Size(392, 21);
            this.txtGenerados.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Números generados:";
            // 
            // wbPDF
            // 
            this.wbPDF.Location = new System.Drawing.Point(694, 74);
            this.wbPDF.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPDF.Name = "wbPDF";
            this.wbPDF.Size = new System.Drawing.Size(654, 626);
            this.wbPDF.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "¿Cuántos números desea?";
            // 
            // txtLista
            // 
            this.txtLista.FormattingEnabled = true;
            this.txtLista.Location = new System.Drawing.Point(201, 46);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(463, 654);
            this.txtLista.TabIndex = 29;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(23, 84);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(130, 20);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.Tag = "";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(23, 130);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 23);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Generar Numeros";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1326, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
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
            this.candidatosToolStripMenuItem,
            this.cargosYPartidosToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // cargosYPartidosToolStripMenuItem
            // 
            this.cargosYPartidosToolStripMenuItem.Name = "cargosYPartidosToolStripMenuItem";
            this.cargosYPartidosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cargosYPartidosToolStripMenuItem.Text = "Cargos y partidos";
            this.cargosYPartidosToolStripMenuItem.Click += new System.EventHandler(this.cargosYPartidosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúAdministradorToolStripMenuItem,
            this.páginaPrincipalToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // FormNumeros
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNumeros";
            this.Text = "Generación de numeros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNumeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosYPartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaPrincipalToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ListBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbPDF;
        private System.Windows.Forms.ComboBox txtGenerados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerCogigos;
    }
}