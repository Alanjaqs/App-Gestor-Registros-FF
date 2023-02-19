
namespace Final_Fantasy_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.lblPersonajes = new System.Windows.Forms.Label();
            this.pboxPersonajes = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTextoAgregar = new System.Windows.Forms.Label();
            this.btnAgregarPersVentana = new System.Windows.Forms.Button();
            this.lblDeletePers = new System.Windows.Forms.Label();
            this.btnDeletePers = new System.Windows.Forms.Button();
            this.lblModificarPers = new System.Windows.Forms.Label();
            this.btnModificarPers = new System.Windows.Forms.Button();
            this.lblDeleteTemp = new System.Windows.Forms.Label();
            this.btnDeleteTemp = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltroRap = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pboxPapelera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonajes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPersonajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dgvPersonajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonajes.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvPersonajes.Location = new System.Drawing.Point(41, 163);
            this.dgvPersonajes.MultiSelect = false;
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.RowHeadersWidth = 51;
            this.dgvPersonajes.RowTemplate.Height = 24;
            this.dgvPersonajes.Size = new System.Drawing.Size(540, 315);
            this.dgvPersonajes.TabIndex = 0;
            this.dgvPersonajes.SelectionChanged += new System.EventHandler(this.dgvPersonajes_SelectionChanged);
            // 
            // lblPersonajes
            // 
            this.lblPersonajes.AutoSize = true;
            this.lblPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonajes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPersonajes.Location = new System.Drawing.Point(31, 27);
            this.lblPersonajes.Name = "lblPersonajes";
            this.lblPersonajes.Size = new System.Drawing.Size(145, 29);
            this.lblPersonajes.TabIndex = 1;
            this.lblPersonajes.Text = "Personajes";
            // 
            // pboxPersonajes
            // 
            this.pboxPersonajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxPersonajes.Location = new System.Drawing.Point(654, 163);
            this.pboxPersonajes.Name = "pboxPersonajes";
            this.pboxPersonajes.Size = new System.Drawing.Size(323, 315);
            this.pboxPersonajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPersonajes.TabIndex = 2;
            this.pboxPersonajes.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(36, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 25);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 500);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTextoAgregar
            // 
            this.lblTextoAgregar.AutoSize = true;
            this.lblTextoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTextoAgregar.Location = new System.Drawing.Point(12, 634);
            this.lblTextoAgregar.Name = "lblTextoAgregar";
            this.lblTextoAgregar.Size = new System.Drawing.Size(169, 20);
            this.lblTextoAgregar.TabIndex = 5;
            this.lblTextoAgregar.Text = "Agregar personaje:";
            // 
            // btnAgregarPersVentana
            // 
            this.btnAgregarPersVentana.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarPersVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPersVentana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPersVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPersVentana.Location = new System.Drawing.Point(215, 627);
            this.btnAgregarPersVentana.Name = "btnAgregarPersVentana";
            this.btnAgregarPersVentana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarPersVentana.Size = new System.Drawing.Size(110, 37);
            this.btnAgregarPersVentana.TabIndex = 6;
            this.btnAgregarPersVentana.Text = "Agregar";
            this.btnAgregarPersVentana.UseVisualStyleBackColor = false;
            this.btnAgregarPersVentana.Click += new System.EventHandler(this.btnAgregarPersVentana_Click);
            this.btnAgregarPersVentana.MouseLeave += new System.EventHandler(this.btnAgregarPersVentana_MouseLeave);
            this.btnAgregarPersVentana.MouseHover += new System.EventHandler(this.btnAgregarPersVentana_MouseHover);
            // 
            // lblDeletePers
            // 
            this.lblDeletePers.AutoSize = true;
            this.lblDeletePers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletePers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeletePers.Location = new System.Drawing.Point(345, 635);
            this.lblDeletePers.Name = "lblDeletePers";
            this.lblDeletePers.Size = new System.Drawing.Size(188, 20);
            this.lblDeletePers.TabIndex = 7;
            this.lblDeletePers.Text = "Eliminar permanente:";
            // 
            // btnDeletePers
            // 
            this.btnDeletePers.BackColor = System.Drawing.Color.DimGray;
            this.btnDeletePers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePers.Location = new System.Drawing.Point(561, 629);
            this.btnDeletePers.Name = "btnDeletePers";
            this.btnDeletePers.Size = new System.Drawing.Size(110, 36);
            this.btnDeletePers.TabIndex = 8;
            this.btnDeletePers.Text = "Eliminar";
            this.btnDeletePers.UseVisualStyleBackColor = false;
            this.btnDeletePers.Click += new System.EventHandler(this.btnDeletePers_Click);
            this.btnDeletePers.MouseLeave += new System.EventHandler(this.btnDeletePers_MouseLeave);
            this.btnDeletePers.MouseHover += new System.EventHandler(this.btnDeletePers_MouseHover);
            // 
            // lblModificarPers
            // 
            this.lblModificarPers.AutoSize = true;
            this.lblModificarPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModificarPers.Location = new System.Drawing.Point(12, 686);
            this.lblModificarPers.Name = "lblModificarPers";
            this.lblModificarPers.Size = new System.Drawing.Size(181, 20);
            this.lblModificarPers.TabIndex = 9;
            this.lblModificarPers.Text = "Modificar personaje:";
            // 
            // btnModificarPers
            // 
            this.btnModificarPers.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarPers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarPers.Location = new System.Drawing.Point(216, 679);
            this.btnModificarPers.Name = "btnModificarPers";
            this.btnModificarPers.Size = new System.Drawing.Size(109, 36);
            this.btnModificarPers.TabIndex = 10;
            this.btnModificarPers.Text = "Modificar";
            this.btnModificarPers.UseVisualStyleBackColor = false;
            this.btnModificarPers.Click += new System.EventHandler(this.btnModificarPers_Click);
            this.btnModificarPers.MouseLeave += new System.EventHandler(this.btnModificarPers_MouseLeave);
            this.btnModificarPers.MouseHover += new System.EventHandler(this.btnModificarPers_MouseHover);
            // 
            // lblDeleteTemp
            // 
            this.lblDeleteTemp.AutoSize = true;
            this.lblDeleteTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeleteTemp.Location = new System.Drawing.Point(694, 636);
            this.lblDeleteTemp.Name = "lblDeleteTemp";
            this.lblDeleteTemp.Size = new System.Drawing.Size(163, 20);
            this.lblDeleteTemp.TabIndex = 11;
            this.lblDeleteTemp.Text = "Eliminar temporal:";
            // 
            // btnDeleteTemp
            // 
            this.btnDeleteTemp.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTemp.Location = new System.Drawing.Point(884, 630);
            this.btnDeleteTemp.Name = "btnDeleteTemp";
            this.btnDeleteTemp.Size = new System.Drawing.Size(110, 35);
            this.btnDeleteTemp.TabIndex = 12;
            this.btnDeleteTemp.Text = "Eliminar";
            this.btnDeleteTemp.UseVisualStyleBackColor = false;
            this.btnDeleteTemp.Click += new System.EventHandler(this.btnDeleteTemp_Click);
            this.btnDeleteTemp.MouseLeave += new System.EventHandler(this.btnDeleteTemp_MouseLeave);
            this.btnDeleteTemp.MouseHover += new System.EventHandler(this.btnDeleteTemp_MouseHover);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(145, 128);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(182, 22);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblFiltroRap
            // 
            this.lblFiltroRap.AutoSize = true;
            this.lblFiltroRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltroRap.Location = new System.Drawing.Point(38, 128);
            this.lblFiltroRap.Name = "lblFiltroRap";
            this.lblFiltroRap.Size = new System.Drawing.Size(101, 17);
            this.lblFiltroRap.TabIndex = 14;
            this.lblFiltroRap.Text = "Filtro rápido:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(333, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 36);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pboxPapelera
            // 
            this.pboxPapelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxPapelera.Location = new System.Drawing.Point(898, 27);
            this.pboxPapelera.Name = "pboxPapelera";
            this.pboxPapelera.Size = new System.Drawing.Size(59, 54);
            this.pboxPapelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPapelera.TabIndex = 16;
            this.pboxPapelera.TabStop = false;
            this.pboxPapelera.Click += new System.EventHandler(this.pboxPapelera_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1046, 736);
            this.Controls.Add(this.pboxPapelera);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFiltroRap);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDeleteTemp);
            this.Controls.Add(this.lblDeleteTemp);
            this.Controls.Add(this.btnModificarPers);
            this.Controls.Add(this.lblModificarPers);
            this.Controls.Add(this.btnDeletePers);
            this.Controls.Add(this.lblDeletePers);
            this.Controls.Add(this.btnAgregarPersVentana);
            this.Controls.Add(this.lblTextoAgregar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pboxPersonajes);
            this.Controls.Add(this.lblPersonajes);
            this.Controls.Add(this.dgvPersonajes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1064, 783);
            this.MinimumSize = new System.Drawing.Size(1064, 783);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Characters";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPapelera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.Label lblPersonajes;
        private System.Windows.Forms.PictureBox pboxPersonajes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTextoAgregar;
        private System.Windows.Forms.Button btnAgregarPersVentana;
        private System.Windows.Forms.Label lblDeletePers;
        private System.Windows.Forms.Button btnDeletePers;
        private System.Windows.Forms.Label lblModificarPers;
        private System.Windows.Forms.Button btnModificarPers;
        private System.Windows.Forms.Label lblDeleteTemp;
        private System.Windows.Forms.Button btnDeleteTemp;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltroRap;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pboxPapelera;
    }
}