namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.gridAvion = new System.Windows.Forms.DataGridView();
            this.lblNombreAvion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(213, 110);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(118, 40);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // gridAvion
            // 
            this.gridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvion.Location = new System.Drawing.Point(437, 86);
            this.gridAvion.Name = "gridAvion";
            this.gridAvion.RowHeadersWidth = 62;
            this.gridAvion.RowTemplate.Height = 28;
            this.gridAvion.Size = new System.Drawing.Size(269, 150);
            this.gridAvion.TabIndex = 1;
            // 
            // lblNombreAvion
            // 
            this.lblNombreAvion.AutoSize = true;
            this.lblNombreAvion.Location = new System.Drawing.Point(48, 57);
            this.lblNombreAvion.Name = "lblNombreAvion";
            this.lblNombreAvion.Size = new System.Drawing.Size(108, 20);
            this.lblNombreAvion.TabIndex = 3;
            this.lblNombreAvion.Text = "Nombre Avion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreAvion);
            this.Controls.Add(this.gridAvion);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmAvion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView gridAvion;
        private System.Windows.Forms.Label lblNombreAvion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}