namespace projetoinicial
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioLooping1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioLoopingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioLooping3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem,
            this.exercícioLooping1ToolStripMenuItem,
            this.exercícioLoopingToolStripMenuItem,
            this.exercícioLooping3ToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio1";
            this.exercicio1ToolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // exercícioLooping1ToolStripMenuItem
            // 
            this.exercícioLooping1ToolStripMenuItem.Name = "exercícioLooping1ToolStripMenuItem";
            this.exercícioLooping1ToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exercícioLooping1ToolStripMenuItem.Text = "Exercício - Looping1";
            this.exercícioLooping1ToolStripMenuItem.Click += new System.EventHandler(this.exercícioLooping1ToolStripMenuItem_Click);
            // 
            // exercícioLoopingToolStripMenuItem
            // 
            this.exercícioLoopingToolStripMenuItem.Name = "exercícioLoopingToolStripMenuItem";
            this.exercícioLoopingToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exercícioLoopingToolStripMenuItem.Text = "Exercício - Looping2";
            this.exercícioLoopingToolStripMenuItem.Click += new System.EventHandler(this.exercícioLoopingToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exercícioLooping3ToolStripMenuItem
            // 
            this.exercícioLooping3ToolStripMenuItem.Name = "exercícioLooping3ToolStripMenuItem";
            this.exercícioLooping3ToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exercícioLooping3ToolStripMenuItem.Text = "Exercício -Looping3";
            this.exercícioLooping3ToolStripMenuItem.Click += new System.EventHandler(this.exercícioLooping3ToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícioLooping1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícioLoopingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícioLooping3ToolStripMenuItem;
    }
}

