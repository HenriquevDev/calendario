namespace calendario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDataInicial = new System.Windows.Forms.TextBox();
            this.txtBoxCaixaFinal = new System.Windows.Forms.TextBox();
            this.txtBoxCaixaAtual = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Atual:";
            // 
            // txtBoxDataInicial
            // 
            this.txtBoxDataInicial.Location = new System.Drawing.Point(381, 60);
            this.txtBoxDataInicial.Name = "txtBoxDataInicial";
            this.txtBoxDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDataInicial.TabIndex = 2;
            // 
            // txtBoxCaixaFinal
            // 
            this.txtBoxCaixaFinal.Location = new System.Drawing.Point(381, 85);
            this.txtBoxCaixaFinal.Name = "txtBoxCaixaFinal";
            this.txtBoxCaixaFinal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCaixaFinal.TabIndex = 2;
            // 
            // txtBoxCaixaAtual
            // 
            this.txtBoxCaixaAtual.Location = new System.Drawing.Point(381, 111);
            this.txtBoxCaixaAtual.Name = "txtBoxCaixaAtual";
            this.txtBoxCaixaAtual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCaixaAtual.TabIndex = 2;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(286, 154);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(206, 26);
            this.buttonSelecionar.TabIndex = 3;
            this.buttonSelecionar.Text = "Selecionar Data";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 258);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.txtBoxCaixaAtual);
            this.Controls.Add(this.txtBoxCaixaFinal);
            this.Controls.Add(this.txtBoxDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDataInicial;
        private System.Windows.Forms.TextBox txtBoxCaixaFinal;
        private System.Windows.Forms.TextBox txtBoxCaixaAtual;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}

