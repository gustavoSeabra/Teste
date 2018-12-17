namespace TesteETurn
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbPerguntas = new System.Windows.Forms.GroupBox();
            this.rbPergunta10 = new System.Windows.Forms.RadioButton();
            this.rbPergunta9 = new System.Windows.Forms.RadioButton();
            this.rbPergunta8 = new System.Windows.Forms.RadioButton();
            this.rbPergunta7 = new System.Windows.Forms.RadioButton();
            this.rbPergunta6 = new System.Windows.Forms.RadioButton();
            this.rbPergunta5 = new System.Windows.Forms.RadioButton();
            this.rbPergunta4 = new System.Windows.Forms.RadioButton();
            this.rbPergunta3 = new System.Windows.Forms.RadioButton();
            this.rbPergunta2 = new System.Windows.Forms.RadioButton();
            this.rbPergunta1 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbPerguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPerguntas
            // 
            this.gbPerguntas.Controls.Add(this.rbPergunta10);
            this.gbPerguntas.Controls.Add(this.rbPergunta9);
            this.gbPerguntas.Controls.Add(this.rbPergunta8);
            this.gbPerguntas.Controls.Add(this.rbPergunta7);
            this.gbPerguntas.Controls.Add(this.rbPergunta6);
            this.gbPerguntas.Controls.Add(this.rbPergunta5);
            this.gbPerguntas.Controls.Add(this.rbPergunta4);
            this.gbPerguntas.Controls.Add(this.rbPergunta3);
            this.gbPerguntas.Controls.Add(this.rbPergunta2);
            this.gbPerguntas.Controls.Add(this.rbPergunta1);
            this.gbPerguntas.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerguntas.Location = new System.Drawing.Point(12, 12);
            this.gbPerguntas.Name = "gbPerguntas";
            this.gbPerguntas.Size = new System.Drawing.Size(889, 381);
            this.gbPerguntas.TabIndex = 0;
            this.gbPerguntas.TabStop = false;
            this.gbPerguntas.Tag = "";
            this.gbPerguntas.Text = "  Perguntas  ";
            // 
            // rbPergunta10
            // 
            this.rbPergunta10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta10.Location = new System.Drawing.Point(18, 328);
            this.rbPergunta10.Name = "rbPergunta10";
            this.rbPergunta10.Size = new System.Drawing.Size(849, 40);
            this.rbPergunta10.TabIndex = 10;
            this.rbPergunta10.TabStop = true;
            this.rbPergunta10.Text = "O numero de viagens começando em C e terminando em C com distância menor que 30. " +
    "Baseado no contexto apresentado, serão as rotas seguintes: CDC, CEBC, CEBCDC, CD" +
    "CEBC, CDEBC, CEBCEBC, CEBCEBCEBC";
            this.rbPergunta10.UseVisualStyleBackColor = true;
            // 
            // rbPergunta9
            // 
            this.rbPergunta9.AutoSize = true;
            this.rbPergunta9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta9.Location = new System.Drawing.Point(18, 301);
            this.rbPergunta9.Name = "rbPergunta9";
            this.rbPergunta9.Size = new System.Drawing.Size(448, 21);
            this.rbPergunta9.TabIndex = 9;
            this.rbPergunta9.TabStop = true;
            this.rbPergunta9.Text = "O tamanho da menor viagem (em termos de distância) de B para B";
            this.rbPergunta9.UseVisualStyleBackColor = true;
            // 
            // rbPergunta8
            // 
            this.rbPergunta8.AutoSize = true;
            this.rbPergunta8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta8.Location = new System.Drawing.Point(18, 274);
            this.rbPergunta8.Name = "rbPergunta8";
            this.rbPergunta8.Size = new System.Drawing.Size(448, 21);
            this.rbPergunta8.TabIndex = 8;
            this.rbPergunta8.TabStop = true;
            this.rbPergunta8.Text = "O tamanho da menor viagem (em termos de distância) de A para C";
            this.rbPergunta8.UseVisualStyleBackColor = true;
            // 
            // rbPergunta7
            // 
            this.rbPergunta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta7.Location = new System.Drawing.Point(18, 218);
            this.rbPergunta7.Name = "rbPergunta7";
            this.rbPergunta7.Size = new System.Drawing.Size(849, 50);
            this.rbPergunta7.TabIndex = 7;
            this.rbPergunta7.TabStop = true;
            this.rbPergunta7.Text = resources.GetString("rbPergunta7.Text");
            this.rbPergunta7.UseVisualStyleBackColor = true;
            // 
            // rbPergunta6
            // 
            this.rbPergunta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta6.Location = new System.Drawing.Point(18, 164);
            this.rbPergunta6.Name = "rbPergunta6";
            this.rbPergunta6.Size = new System.Drawing.Size(849, 48);
            this.rbPergunta6.TabIndex = 6;
            this.rbPergunta6.TabStop = true;
            this.rbPergunta6.Text = "O número de viagens começando em C e terminando em C com no máximo 3 paradas. Bas" +
    "eado no contexto apresentado, serão 2 rotas possíveis: C-D-C (2 paradas) e C-E-B" +
    "-C (3 paradas)";
            this.rbPergunta6.UseVisualStyleBackColor = true;
            // 
            // rbPergunta5
            // 
            this.rbPergunta5.AutoSize = true;
            this.rbPergunta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta5.Location = new System.Drawing.Point(18, 137);
            this.rbPergunta5.Name = "rbPergunta5";
            this.rbPergunta5.Size = new System.Drawing.Size(186, 21);
            this.rbPergunta5.TabIndex = 5;
            this.rbPergunta5.TabStop = true;
            this.rbPergunta5.Text = "A distância da rota A-E-D";
            this.rbPergunta5.UseVisualStyleBackColor = true;
            // 
            // rbPergunta4
            // 
            this.rbPergunta4.AutoSize = true;
            this.rbPergunta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta4.Location = new System.Drawing.Point(18, 110);
            this.rbPergunta4.Name = "rbPergunta4";
            this.rbPergunta4.Size = new System.Drawing.Size(214, 21);
            this.rbPergunta4.TabIndex = 4;
            this.rbPergunta4.TabStop = true;
            this.rbPergunta4.Text = "A distância da rota A-E-B-C-D";
            this.rbPergunta4.UseVisualStyleBackColor = true;
            // 
            // rbPergunta3
            // 
            this.rbPergunta3.AutoSize = true;
            this.rbPergunta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta3.Location = new System.Drawing.Point(18, 83);
            this.rbPergunta3.Name = "rbPergunta3";
            this.rbPergunta3.Size = new System.Drawing.Size(186, 21);
            this.rbPergunta3.TabIndex = 3;
            this.rbPergunta3.TabStop = true;
            this.rbPergunta3.Text = "A distância da rota A-D-C";
            this.rbPergunta3.UseVisualStyleBackColor = true;
            // 
            // rbPergunta2
            // 
            this.rbPergunta2.AutoSize = true;
            this.rbPergunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta2.Location = new System.Drawing.Point(18, 56);
            this.rbPergunta2.Name = "rbPergunta2";
            this.rbPergunta2.Size = new System.Drawing.Size(172, 21);
            this.rbPergunta2.TabIndex = 2;
            this.rbPergunta2.TabStop = true;
            this.rbPergunta2.Text = "A distância da rota A-D";
            this.rbPergunta2.UseVisualStyleBackColor = true;
            // 
            // rbPergunta1
            // 
            this.rbPergunta1.AutoSize = true;
            this.rbPergunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta1.Location = new System.Drawing.Point(18, 29);
            this.rbPergunta1.Name = "rbPergunta1";
            this.rbPergunta1.Size = new System.Drawing.Size(185, 21);
            this.rbPergunta1.TabIndex = 1;
            this.rbPergunta1.TabStop = true;
            this.rbPergunta1.Text = "A distância da rota A-B-C";
            this.rbPergunta1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(713, 399);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 28);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(826, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 440);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbPerguntas);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::  Calculo de Distância  ::..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.gbPerguntas.ResumeLayout(false);
            this.gbPerguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerguntas;
        private System.Windows.Forms.RadioButton rbPergunta10;
        private System.Windows.Forms.RadioButton rbPergunta9;
        private System.Windows.Forms.RadioButton rbPergunta8;
        private System.Windows.Forms.RadioButton rbPergunta7;
        private System.Windows.Forms.RadioButton rbPergunta6;
        private System.Windows.Forms.RadioButton rbPergunta5;
        private System.Windows.Forms.RadioButton rbPergunta4;
        private System.Windows.Forms.RadioButton rbPergunta3;
        private System.Windows.Forms.RadioButton rbPergunta2;
        private System.Windows.Forms.RadioButton rbPergunta1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

