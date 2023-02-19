
namespace Final_Fantasy_App
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblAgrNombre = new System.Windows.Forms.Label();
            this.lblAgrDescripcion = new System.Windows.Forms.Label();
            this.lblAgrImagen = new System.Windows.Forms.Label();
            this.txtAgrNombre = new System.Windows.Forms.TextBox();
            this.txtAgrDescripcion = new System.Windows.Forms.TextBox();
            this.txtAgrImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarPers = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFFNum = new System.Windows.Forms.Label();
            this.pboxAgrImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgrImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgrNombre
            // 
            this.lblAgrNombre.AutoSize = true;
            this.lblAgrNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgrNombre.Location = new System.Drawing.Point(33, 89);
            this.lblAgrNombre.Name = "lblAgrNombre";
            this.lblAgrNombre.Size = new System.Drawing.Size(80, 20);
            this.lblAgrNombre.TabIndex = 0;
            this.lblAgrNombre.Text = "Nombre:";
            // 
            // lblAgrDescripcion
            // 
            this.lblAgrDescripcion.AutoSize = true;
            this.lblAgrDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgrDescripcion.Location = new System.Drawing.Point(33, 150);
            this.lblAgrDescripcion.Name = "lblAgrDescripcion";
            this.lblAgrDescripcion.Size = new System.Drawing.Size(116, 20);
            this.lblAgrDescripcion.TabIndex = 1;
            this.lblAgrDescripcion.Text = "Descripción:";
            // 
            // lblAgrImagen
            // 
            this.lblAgrImagen.AutoSize = true;
            this.lblAgrImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgrImagen.Location = new System.Drawing.Point(33, 209);
            this.lblAgrImagen.Name = "lblAgrImagen";
            this.lblAgrImagen.Size = new System.Drawing.Size(75, 20);
            this.lblAgrImagen.TabIndex = 2;
            this.lblAgrImagen.Text = "Imagen:";
            // 
            // txtAgrNombre
            // 
            this.txtAgrNombre.Location = new System.Drawing.Point(180, 87);
            this.txtAgrNombre.Name = "txtAgrNombre";
            this.txtAgrNombre.Size = new System.Drawing.Size(165, 22);
            this.txtAgrNombre.TabIndex = 3;
            // 
            // txtAgrDescripcion
            // 
            this.txtAgrDescripcion.Location = new System.Drawing.Point(180, 148);
            this.txtAgrDescripcion.Name = "txtAgrDescripcion";
            this.txtAgrDescripcion.Size = new System.Drawing.Size(165, 22);
            this.txtAgrDescripcion.TabIndex = 4;
            // 
            // txtAgrImagen
            // 
            this.txtAgrImagen.Location = new System.Drawing.Point(180, 209);
            this.txtAgrImagen.Name = "txtAgrImagen";
            this.txtAgrImagen.Size = new System.Drawing.Size(165, 22);
            this.txtAgrImagen.TabIndex = 5;
            this.txtAgrImagen.Leave += new System.EventHandler(this.txtAgrImagen_Leave);
            // 
            // btnAgregarPers
            // 
            this.btnAgregarPers.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarPers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPers.Location = new System.Drawing.Point(64, 279);
            this.btnAgregarPers.Name = "btnAgregarPers";
            this.btnAgregarPers.Size = new System.Drawing.Size(112, 37);
            this.btnAgregarPers.TabIndex = 6;
            this.btnAgregarPers.Text = "Agregar";
            this.btnAgregarPers.UseVisualStyleBackColor = false;
            this.btnAgregarPers.Click += new System.EventHandler(this.btnAgregarPers_Click);
            this.btnAgregarPers.MouseLeave += new System.EventHandler(this.btnAgregarPers_MouseLeave);
            this.btnAgregarPers.MouseHover += new System.EventHandler(this.btnAgregarPers_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(212, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // lblFFNum
            // 
            this.lblFFNum.AutoSize = true;
            this.lblFFNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFFNum.Location = new System.Drawing.Point(266, 23);
            this.lblFFNum.Name = "lblFFNum";
            this.lblFFNum.Size = new System.Drawing.Size(108, 18);
            this.lblFFNum.TabIndex = 8;
            this.lblFFNum.Text = "Final Fantasy";
            // 
            // pboxAgrImagen
            // 
            this.pboxAgrImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxAgrImagen.Location = new System.Drawing.Point(409, 79);
            this.pboxAgrImagen.Name = "pboxAgrImagen";
            this.pboxAgrImagen.Size = new System.Drawing.Size(234, 237);
            this.pboxAgrImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAgrImagen.TabIndex = 9;
            this.pboxAgrImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarImagen.Location = new System.Drawing.Point(351, 204);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarImagen.TabIndex = 10;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 355);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pboxAgrImagen);
            this.Controls.Add(this.lblFFNum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarPers);
            this.Controls.Add(this.txtAgrImagen);
            this.Controls.Add(this.txtAgrDescripcion);
            this.Controls.Add(this.txtAgrNombre);
            this.Controls.Add(this.lblAgrImagen);
            this.Controls.Add(this.lblAgrDescripcion);
            this.Controls.Add(this.lblAgrNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(694, 402);
            this.MinimumSize = new System.Drawing.Size(694, 402);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar personaje";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgrImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgrNombre;
        private System.Windows.Forms.Label lblAgrDescripcion;
        private System.Windows.Forms.Label lblAgrImagen;
        private System.Windows.Forms.TextBox txtAgrNombre;
        private System.Windows.Forms.TextBox txtAgrDescripcion;
        private System.Windows.Forms.TextBox txtAgrImagen;
        private System.Windows.Forms.Button btnAgregarPers;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFFNum;
        private System.Windows.Forms.PictureBox pboxAgrImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}