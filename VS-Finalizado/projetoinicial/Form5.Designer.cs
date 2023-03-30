namespace projetoinicial
{
    partial class frmtabuada3
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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(42, 81);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(226, 29);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(38, 187);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(383, 29);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = " Tabuada do número escolhido:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(465, 165);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(115, 86);
            this.txtresult.TabIndex = 2;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(287, 88);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 22);
            this.txtnum.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(95, 343);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(131, 55);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(287, 343);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(115, 54);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(465, 343);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(115, 54);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmtabuada3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabuada3";
            this.Text = "Tabuada 3";
            this.Load += new System.EventHandler(this.frmtabuada3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}