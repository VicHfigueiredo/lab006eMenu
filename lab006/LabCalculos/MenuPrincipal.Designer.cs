
namespace lab006.LabCalculos
{
    partial class MenuPrincipal
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenu.Location = new System.Drawing.Point(183, 67);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(451, 32);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal de Atividades";
            // 
            // btnMaior
            // 
            this.btnMaior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaior.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaior.Location = new System.Drawing.Point(253, 141);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(280, 93);
            this.btnMaior.TabIndex = 1;
            this.btnMaior.Text = "Maior Número de três";
            this.btnMaior.UseVisualStyleBackColor = false;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculo.Location = new System.Drawing.Point(253, 265);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(280, 95);
            this.btnCalculo.TabIndex = 2;
            this.btnCalculo.Text = "Calculo de Frete";
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.lblMenu);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnCalculo;
    }
}