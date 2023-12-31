﻿
namespace Presentacion
{
    partial class frmCatalogoMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoMain));
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.lblBienvenidaCatalogo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBajaFisica = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.lblFiltroEspecifico = new System.Windows.Forms.Label();
            this.txtbFiltroRapido = new System.Windows.Forms.TextBox();
            this.txtboxCriterio = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio1 = new System.Windows.Forms.Label();
            this.lblCriterio2 = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.pboxCamaro = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ttipConsejos = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.agregarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCamaro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.Location = new System.Drawing.Point(218, 164);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(632, 382);
            this.dgvCatalogo.TabIndex = 4;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // lblBienvenidaCatalogo
            // 
            this.lblBienvenidaCatalogo.AutoSize = true;
            this.lblBienvenidaCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaCatalogo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBienvenidaCatalogo.Location = new System.Drawing.Point(596, 28);
            this.lblBienvenidaCatalogo.Name = "lblBienvenidaCatalogo";
            this.lblBienvenidaCatalogo.Size = new System.Drawing.Size(206, 25);
            this.lblBienvenidaCatalogo.TabIndex = 1;
            this.lblBienvenidaCatalogo.Text = "Catalogo de Autos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 338);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.ttipConsejos.SetToolTip(this.btnAgregar, "Agregar un nuevo registro a la base de datos.");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pboxImagen
            // 
            this.pboxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxImagen.Location = new System.Drawing.Point(958, 209);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(377, 337);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 3;
            this.pboxImagen.TabStop = false;
            this.pboxImagen.Click += new System.EventHandler(this.pboxImagen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(986, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imagen";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 759);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1368, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.ttipConsejos.SetToolTip(this.btnModificar, "Modificar un registro de la base de datos.Primero selecciones el registro en la t" +
        "abla.");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBajaFisica
            // 
            this.btnBajaFisica.Location = new System.Drawing.Point(9, 432);
            this.btnBajaFisica.Name = "btnBajaFisica";
            this.btnBajaFisica.Size = new System.Drawing.Size(137, 23);
            this.btnBajaFisica.TabIndex = 2;
            this.btnBajaFisica.Text = "Eliminar ";
            this.ttipConsejos.SetToolTip(this.btnBajaFisica, "Eliminar definitivo de un registro,primero seleccion el registro en la tabla.");
            this.btnBajaFisica.UseVisualStyleBackColor = true;
            this.btnBajaFisica.Click += new System.EventHandler(this.btnBajaFisica_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFiltroRapido.Location = new System.Drawing.Point(215, 123);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(54, 13);
            this.lblFiltroRapido.TabIndex = 14;
            this.lblFiltroRapido.Text = "Buscar: ";
            // 
            // lblFiltroEspecifico
            // 
            this.lblFiltroEspecifico.AutoSize = true;
            this.lblFiltroEspecifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEspecifico.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFiltroEspecifico.Location = new System.Drawing.Point(235, 577);
            this.lblFiltroEspecifico.Name = "lblFiltroEspecifico";
            this.lblFiltroEspecifico.Size = new System.Drawing.Size(98, 13);
            this.lblFiltroEspecifico.TabIndex = 15;
            this.lblFiltroEspecifico.Text = "Filtro Especifico";
            // 
            // txtbFiltroRapido
            // 
            this.txtbFiltroRapido.Location = new System.Drawing.Point(284, 120);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(434, 20);
            this.txtbFiltroRapido.TabIndex = 0;
            this.ttipConsejos.SetToolTip(this.txtbFiltroRapido, "Escriba algo..");
            this.txtbFiltroRapido.TextChanged += new System.EventHandler(this.txtbFiltroRapido_TextChanged);
            // 
            // txtboxCriterio
            // 
            this.txtboxCriterio.Location = new System.Drawing.Point(655, 609);
            this.txtboxCriterio.Name = "txtboxCriterio";
            this.txtboxCriterio.Size = new System.Drawing.Size(100, 20);
            this.txtboxCriterio.TabIndex = 3;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(215, 612);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 18;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio1
            // 
            this.lblCriterio1.AutoSize = true;
            this.lblCriterio1.Location = new System.Drawing.Point(398, 612);
            this.lblCriterio1.Name = "lblCriterio1";
            this.lblCriterio1.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio1.TabIndex = 19;
            this.lblCriterio1.Text = "Criterio";
            // 
            // lblCriterio2
            // 
            this.lblCriterio2.AutoSize = true;
            this.lblCriterio2.Location = new System.Drawing.Point(598, 612);
            this.lblCriterio2.Name = "lblCriterio2";
            this.lblCriterio2.Size = new System.Drawing.Size(26, 13);
            this.lblCriterio2.TabIndex = 20;
            this.lblCriterio2.Text = "filtro";
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(271, 608);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(121, 21);
            this.cboxCampo.TabIndex = 1;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio1
            // 
            this.cboxCriterio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio1.FormattingEnabled = true;
            this.cboxCriterio1.Location = new System.Drawing.Point(445, 608);
            this.cboxCriterio1.Name = "cboxCriterio1";
            this.cboxCriterio1.Size = new System.Drawing.Size(121, 21);
            this.cboxCriterio1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(775, 607);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblArticulo.Location = new System.Drawing.Point(215, 148);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(64, 13);
            this.lblArticulo.TabIndex = 24;
            this.lblArticulo.Text = "Articulos: ";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLateral.Controls.Add(this.pboxCamaro);
            this.panelLateral.Controls.Add(this.lblNombre);
            this.panelLateral.Controls.Add(this.btnAgregar);
            this.panelLateral.Controls.Add(this.btnModificar);
            this.panelLateral.Controls.Add(this.btnBajaFisica);
            this.panelLateral.Location = new System.Drawing.Point(0, 28);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(173, 504);
            this.panelLateral.TabIndex = 25;
            this.panelLateral.DockChanged += new System.EventHandler(this.panel1_DockChanged);
            this.panelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLateral_Paint);
            // 
            // pboxCamaro
            // 
            this.pboxCamaro.Location = new System.Drawing.Point(0, 73);
            this.pboxCamaro.Name = "pboxCamaro";
            this.pboxCamaro.Size = new System.Drawing.Size(173, 188);
            this.pboxCamaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCamaro.TabIndex = 12;
            this.pboxCamaro.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(4, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(166, 17);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Concesionaria \"PEPE\"";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1368, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRegistroToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripSplitButton1.Text = "Archivo";
            // 
            // agregarRegistroToolStripMenuItem
            // 
            this.agregarRegistroToolStripMenuItem.Name = "agregarRegistroToolStripMenuItem";
            this.agregarRegistroToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.agregarRegistroToolStripMenuItem.Text = "Agregar Registro";
            this.agregarRegistroToolStripMenuItem.Click += new System.EventHandler(this.agregarRegistroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(75, 22);
            this.toolStripSplitButton2.Text = "Acerca de";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.acercaDeToolStripMenuItem.Text = "Desarrolador";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmCatalogoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1368, 781);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboxCriterio1);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.lblCriterio2);
            this.Controls.Add(this.lblCriterio1);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtboxCriterio);
            this.Controls.Add(this.txtbFiltroRapido);
            this.Controls.Add(this.lblFiltroEspecifico);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(this.lblBienvenidaCatalogo);
            this.Controls.Add(this.dgvCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCatalogoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCatalogoMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCamaro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Label lblBienvenidaCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBajaFisica;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Label lblFiltroEspecifico;
        private System.Windows.Forms.TextBox txtbFiltroRapido;
        private System.Windows.Forms.TextBox txtboxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio1;
        private System.Windows.Forms.Label lblCriterio2;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pboxCamaro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip ttipConsejos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem agregarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}