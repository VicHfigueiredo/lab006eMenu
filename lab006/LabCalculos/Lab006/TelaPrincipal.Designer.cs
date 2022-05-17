
namespace lab006.LabCalculos.Lab006
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            this.nudValor2 = new System.Windows.Forms.NumericUpDown();
            this.nudValor3 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(131, 123);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(55, 19);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(131, 191);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(55, 19);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2:";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor3.Location = new System.Drawing.Point(131, 250);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(55, 19);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Valor 3:";
            // 
            // nudValor1
            // 
            this.nudValor1.Location = new System.Drawing.Point(235, 121);
            this.nudValor1.Name = "nudValor1";
            this.nudValor1.Size = new System.Drawing.Size(92, 23);
            this.nudValor1.TabIndex = 3;
            this.nudValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudValor2
            // 
            this.nudValor2.Location = new System.Drawing.Point(235, 183);
            this.nudValor2.Name = "nudValor2";
            this.nudValor2.Size = new System.Drawing.Size(92, 23);
            this.nudValor2.TabIndex = 4;
            this.nudValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudValor3
            // 
            this.nudValor3.Location = new System.Drawing.Point(235, 242);
            this.nudValor3.Name = "nudValor3";
            this.nudValor3.Size = new System.Drawing.Size(92, 23);
            this.nudValor3.TabIndex = 5;
            this.nudValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(364, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Wheat;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(524, 119);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(232, 146);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudValor3);
            this.Controls.Add(this.nudValor2);
            this.Controls.Add(this.nudValor1);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.NumericUpDown nudValor1;
        private System.Windows.Forms.NumericUpDown nudValor2;
        private System.Windows.Forms.NumericUpDown nudValor3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}