namespace projetoinicial
{
    partial class frmtabuada1
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtlimpar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(33, 79);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(226, 29);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(33, 170);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(376, 29);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Tabuada do número escolhido:";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(438, 158);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(121, 81);
            this.txtresult.TabIndex = 2;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(282, 81);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 28);
            this.txtnum.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(51, 331);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(120, 53);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtlimpar
            // 
            this.txtlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlimpar.Location = new System.Drawing.Point(221, 331);
            this.txtlimpar.Name = "txtlimpar";
            this.txtlimpar.Size = new System.Drawing.Size(110, 53);
            this.txtlimpar.TabIndex = 5;
            this.txtlimpar.Text = "Limpar";
            this.txtlimpar.UseVisualStyleBackColor = true;
            this.txtlimpar.Click += new System.EventHandler(this.txtlimpar_Click);
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(384, 331);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(122, 52);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // frmtabuada1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.txtlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabuada1";
            this.Text = "Tabuada1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button txtlimpar;
        private System.Windows.Forms.Button Voltar;
    }
}