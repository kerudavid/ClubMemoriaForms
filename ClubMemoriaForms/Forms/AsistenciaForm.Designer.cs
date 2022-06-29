namespace ClubMemoriaForms.Forms
{
    partial class AsistenciaForm
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
            this.grdAsistencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAsistencia
            // 
            this.grdAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAsistencia.Location = new System.Drawing.Point(22, 220);
            this.grdAsistencia.Name = "grdAsistencia";
            this.grdAsistencia.Size = new System.Drawing.Size(736, 150);
            this.grdAsistencia.TabIndex = 0;
            // 
            // AsistenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdAsistencia);
            this.Name = "AsistenciaForm";
            this.Text = "AsistenciaForm";
            this.Load += new System.EventHandler(this.AsistenciaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAsistencia;
    }
}