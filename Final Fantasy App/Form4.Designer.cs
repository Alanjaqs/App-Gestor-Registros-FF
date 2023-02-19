
namespace Final_Fantasy_App
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblPapelera = new System.Windows.Forms.Label();
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnEliminarPapelera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPapelera
            // 
            this.lblPapelera.AutoSize = true;
            this.lblPapelera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapelera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPapelera.Location = new System.Drawing.Point(67, 27);
            this.lblPapelera.Name = "lblPapelera";
            this.lblPapelera.Size = new System.Drawing.Size(214, 25);
            this.lblPapelera.TabIndex = 0;
            this.lblPapelera.Text = "Papelera de reciclaje";
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.Location = new System.Drawing.Point(38, 71);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.RowHeadersWidth = 51;
            this.dgvPapelera.RowTemplate.Height = 24;
            this.dgvPapelera.Size = new System.Drawing.Size(341, 281);
            this.dgvPapelera.TabIndex = 1;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.DimGray;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestaurar.Location = new System.Drawing.Point(72, 369);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(106, 35);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnEliminarPapelera
            // 
            this.btnEliminarPapelera.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarPapelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPapelera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPapelera.Location = new System.Drawing.Point(231, 369);
            this.btnEliminarPapelera.Name = "btnEliminarPapelera";
            this.btnEliminarPapelera.Size = new System.Drawing.Size(106, 35);
            this.btnEliminarPapelera.TabIndex = 3;
            this.btnEliminarPapelera.Text = "Eliminar";
            this.btnEliminarPapelera.UseVisualStyleBackColor = false;
            this.btnEliminarPapelera.Click += new System.EventHandler(this.btnEliminarPapelera_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(413, 416);
            this.Controls.Add(this.btnEliminarPapelera);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvPapelera);
            this.Controls.Add(this.lblPapelera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 463);
            this.MinimumSize = new System.Drawing.Size(431, 463);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelera de reciclaje";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPapelera;
        private System.Windows.Forms.DataGridView dgvPapelera;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnEliminarPapelera;
    }
}