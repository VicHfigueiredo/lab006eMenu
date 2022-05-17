
namespace lab006.LabCalculos.Lab007
{
    partial class TelaPrincipal
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.tbxfrete = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(138, 144);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(139, 181);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 15);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(139, 216);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(46, 15);
            this.lblFrete.TabIndex = 2;
            this.lblFrete.Text = "% Frete";
            // 
            // tbxCliente
            // 
            this.tbxCliente.Location = new System.Drawing.Point(225, 136);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.Size = new System.Drawing.Size(396, 23);
            this.tbxCliente.TabIndex = 3;
            // 
            // tbxfrete
            // 
            this.tbxfrete.Location = new System.Drawing.Point(225, 208);
            this.tbxfrete.Name = "tbxfrete";
            this.tbxfrete.Size = new System.Drawing.Size(133, 23);
            this.tbxfrete.TabIndex = 4;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(225, 173);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(133, 23);
            this.tbxValor.TabIndex = 5;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(470, 181);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 15);
            this.lblUF.TabIndex = 6;
            this.lblUF.Text = "UF:";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblResultado.Location = new System.Drawing.Point(283, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(215, 107);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(423, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(500, 173);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(121, 23);
            this.cbxUF.TabIndex = 9;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxfrete);
            this.Controls.Add(this.tbxCliente);
            this.Controls.Add(this.lblFrete);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.TextBox tbxfrete;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxUF;
    }
}