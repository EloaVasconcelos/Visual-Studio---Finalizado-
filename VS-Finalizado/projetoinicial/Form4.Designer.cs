namespace projetoinicial
{
    partial class frmtabuada2
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
            this.bntcalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntcalcular
            // 
            this.bntcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcalcular.Location = new System.Drawing.Point(57, 343);
            this.bntcalcular.Name = "bntcalcular";
            this.bntcalcular.Size = new System.Drawing.Size(116, 42);
            this.bntcalcular.TabIndex = 0;
            this.bntcalcular.Text = "Calcular";
            this.bntcalcular.UseVisualStyleBackColor = true;
            this.bntcalcular.Click += new System.EventHandler(this.bntcalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(241, 343);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(116, 42);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(422, 343);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(116, 42);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(26, 57);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(226, 29);
            this.lblnum.TabIndex = 3;
            this.lblnum.Text = "Digite um número:";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(26, 140);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(376, 29);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "Tabuada do número escolhido:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(280, 64);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 22);
            this.txtnum.TabIndex = 5;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(444, 140);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(125, 86);
            this.txtresult.TabIndex = 6;
            // 
            // frmtabuada2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.bntcalcular);
            this.Name = "frmtabuada2";
            this.Text = "Tabuada2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntcalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
    }
}