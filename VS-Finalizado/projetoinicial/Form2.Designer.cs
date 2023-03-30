namespace projetoinicial
{
    partial class frmcombustivel
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
            this.lblcom = new System.Windows.Forms.Label();
            this.lblql = new System.Windows.Forms.Label();
            this.lblv = new System.Windows.Forms.Label();
            this.txtv = new System.Windows.Forms.TextBox();
            this.txtql = new System.Windows.Forms.TextBox();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcom
            // 
            this.lblcom.AutoSize = true;
            this.lblcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcom.Location = new System.Drawing.Point(35, 106);
            this.lblcom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcom.Name = "lblcom";
            this.lblcom.Size = new System.Drawing.Size(808, 31);
            this.lblcom.TabIndex = 0;
            this.lblcom.Text = "Digite o tipo de combustível (A para álcool e G para gasolina)";
            this.lblcom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblql
            // 
            this.lblql.AutoSize = true;
            this.lblql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblql.Location = new System.Drawing.Point(35, 182);
            this.lblql.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblql.Name = "lblql";
            this.lblql.Size = new System.Drawing.Size(276, 31);
            this.lblql.TabIndex = 1;
            this.lblql.Text = "Quantidade de litros";
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv.Location = new System.Drawing.Point(35, 260);
            this.lblv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(260, 31);
            this.lblv.TabIndex = 2;
            this.lblv.Text = "Valor a ser pago é:";
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(359, 266);
            this.txtv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtv.Name = "txtv";
            this.txtv.ReadOnly = true;
            this.txtv.Size = new System.Drawing.Size(260, 22);
            this.txtv.TabIndex = 3;
            // 
            // txtql
            // 
            this.txtql.Location = new System.Drawing.Point(359, 188);
            this.txtql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtql.Name = "txtql";
            this.txtql.Size = new System.Drawing.Size(260, 22);
            this.txtql.TabIndex = 4;
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(917, 115);
            this.txtcom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(100, 22);
            this.txtcom.TabIndex = 5;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(281, 389);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(131, 46);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(68, 389);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(141, 46);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(493, 389);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(127, 46);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmcombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.txtql);
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.lblql);
            this.Controls.Add(this.lblcom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmcombustivel";
            this.Text = "Cálculo Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcom;
        private System.Windows.Forms.Label lblql;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.TextBox txtql;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
    }
}