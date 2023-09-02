
namespace Presentacion
{
    partial class FrmPantallaBienvenida
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
            this.lblTextoBienvenida = new System.Windows.Forms.Label();
            this.lblTextobievenida2 = new System.Windows.Forms.Label();
            this.btnMagia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextoBienvenida
            // 
            this.lblTextoBienvenida.AutoSize = true;
            this.lblTextoBienvenida.Location = new System.Drawing.Point(288, 179);
            this.lblTextoBienvenida.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTextoBienvenida.Name = "lblTextoBienvenida";
            this.lblTextoBienvenida.Size = new System.Drawing.Size(324, 25);
            this.lblTextoBienvenida.TabIndex = 0;
            this.lblTextoBienvenida.Text = "Bienvenido a mi entraga final!";
         
            // 
            // lblTextobievenida2
            // 
            this.lblTextobievenida2.AutoSize = true;
            this.lblTextobievenida2.Location = new System.Drawing.Point(348, 224);
            this.lblTextobievenida2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTextobievenida2.Name = "lblTextobievenida2";
            this.lblTextobievenida2.Size = new System.Drawing.Size(180, 25);
            this.lblTextobievenida2.TabIndex = 1;
            this.lblTextobievenida2.Text = "Curso C# Nivel2";
            // 
            // btnMagia
            // 
            this.btnMagia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMagia.FlatAppearance.BorderSize = 3;
            this.btnMagia.Location = new System.Drawing.Point(293, 299);
            this.btnMagia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMagia.Name = "btnMagia";
            this.btnMagia.Size = new System.Drawing.Size(351, 44);
            this.btnMagia.TabIndex = 2;
            this.btnMagia.Text = "Magia";
            this.btnMagia.UseVisualStyleBackColor = true;
            this.btnMagia.Click += new System.EventHandler(this.btnMagia_Click);
            // 
            // FrmPantallaBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.btnMagia);
            this.Controls.Add(this.lblTextobievenida2);
            this.Controls.Add(this.lblTextoBienvenida);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmPantallaBienvenida";
            this.Text = "Bienvenido al Catalogo!";
            this.Load += new System.EventHandler(this.FrmPantallaBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoBienvenida;
        private System.Windows.Forms.Label lblTextobievenida2;
        private System.Windows.Forms.Button btnMagia;
    }
}

