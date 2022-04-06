using System.Windows.Forms;

namespace TermooHelper.UI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLetterOne = new System.Windows.Forms.TextBox();
            this.txtLetterTwo = new System.Windows.Forms.TextBox();
            this.txtLetterThree = new System.Windows.Forms.TextBox();
            this.txtLetterFour = new System.Windows.Forms.TextBox();
            this.txtLetterFive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.txtNotContain = new System.Windows.Forms.TextBox();
            this.dgWords = new System.Windows.Forms.DataGridView();
            this.palavras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlWrong = new System.Windows.Forms.Panel();
            this.txtWrongPosition1 = new System.Windows.Forms.TextBox();
            this.txtWrongPosition2 = new System.Windows.Forms.TextBox();
            this.txtWrongPosition3 = new System.Windows.Forms.TextBox();
            this.txtWrongPosition4 = new System.Windows.Forms.TextBox();
            this.txtWrongPosition5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPalavras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).BeginInit();
            this.pnlLetters.SuspendLayout();
            this.pnlWrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLetterOne
            // 
            this.txtLetterOne.Location = new System.Drawing.Point(19, 15);
            this.txtLetterOne.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetterOne.MaxLength = 1;
            this.txtLetterOne.Name = "txtLetterOne";
            this.txtLetterOne.Size = new System.Drawing.Size(35, 33);
            this.txtLetterOne.TabIndex = 1;
            this.txtLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetterOne.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtLetterTwo
            // 
            this.txtLetterTwo.Location = new System.Drawing.Point(64, 15);
            this.txtLetterTwo.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetterTwo.MaxLength = 1;
            this.txtLetterTwo.Name = "txtLetterTwo";
            this.txtLetterTwo.Size = new System.Drawing.Size(35, 33);
            this.txtLetterTwo.TabIndex = 2;
            this.txtLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetterTwo.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtLetterThree
            // 
            this.txtLetterThree.Location = new System.Drawing.Point(109, 15);
            this.txtLetterThree.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetterThree.MaxLength = 1;
            this.txtLetterThree.Name = "txtLetterThree";
            this.txtLetterThree.Size = new System.Drawing.Size(35, 33);
            this.txtLetterThree.TabIndex = 3;
            this.txtLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetterThree.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtLetterFour
            // 
            this.txtLetterFour.Location = new System.Drawing.Point(154, 15);
            this.txtLetterFour.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetterFour.MaxLength = 1;
            this.txtLetterFour.Name = "txtLetterFour";
            this.txtLetterFour.Size = new System.Drawing.Size(35, 33);
            this.txtLetterFour.TabIndex = 4;
            this.txtLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetterFour.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtLetterFive
            // 
            this.txtLetterFive.Location = new System.Drawing.Point(199, 15);
            this.txtLetterFive.Margin = new System.Windows.Forms.Padding(5);
            this.txtLetterFive.MaxLength = 1;
            this.txtLetterFive.Name = "txtLetterFive";
            this.txtLetterFive.Size = new System.Drawing.Size(35, 33);
            this.txtLetterFive.TabIndex = 5;
            this.txtLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetterFive.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 67);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Informe somente as letras que você sabe que estão na posição correta";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 60);
            this.label2.TabIndex = 7;
            this.label2.Text = "3. Informe as letras que ESTÃO na palavra";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 59);
            this.label3.TabIndex = 8;
            this.label3.Text = "4. Informe as letras que NÃO estão na palavra";
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(51, 399);
            this.txtContains.Margin = new System.Windows.Forms.Padding(5);
            this.txtContains.MaxLength = 26;
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(281, 33);
            this.txtContains.TabIndex = 9;
            // 
            // txtNotContain
            // 
            this.txtNotContain.Location = new System.Drawing.Point(51, 511);
            this.txtNotContain.Margin = new System.Windows.Forms.Padding(5);
            this.txtNotContain.MaxLength = 26;
            this.txtNotContain.Name = "txtNotContain";
            this.txtNotContain.Size = new System.Drawing.Size(281, 33);
            this.txtNotContain.TabIndex = 10;
            // 
            // dgWords
            // 
            this.dgWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palavras});
            this.dgWords.Location = new System.Drawing.Point(422, 56);
            this.dgWords.Name = "dgWords";
            this.dgWords.RowTemplate.Height = 25;
            this.dgWords.Size = new System.Drawing.Size(253, 441);
            this.dgWords.TabIndex = 11;
            // 
            // palavras
            // 
            this.palavras.HeaderText = "Palavras";
            this.palavras.Name = "palavras";
            this.palavras.ReadOnly = true;
            // 
            // pnlLetters
            // 
            this.pnlLetters.Controls.Add(this.txtLetterOne);
            this.pnlLetters.Controls.Add(this.txtLetterTwo);
            this.pnlLetters.Controls.Add(this.txtLetterThree);
            this.pnlLetters.Controls.Add(this.txtLetterFour);
            this.pnlLetters.Controls.Add(this.txtLetterFive);
            this.pnlLetters.Location = new System.Drawing.Point(51, 92);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(251, 67);
            this.pnlLetters.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(422, 504);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 38);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Buscar [F5]";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(555, 504);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 38);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlWrong
            // 
            this.pnlWrong.Controls.Add(this.txtWrongPosition1);
            this.pnlWrong.Controls.Add(this.txtWrongPosition2);
            this.pnlWrong.Controls.Add(this.txtWrongPosition3);
            this.pnlWrong.Controls.Add(this.txtWrongPosition4);
            this.pnlWrong.Controls.Add(this.txtWrongPosition5);
            this.pnlWrong.Location = new System.Drawing.Point(51, 244);
            this.pnlWrong.Name = "pnlWrong";
            this.pnlWrong.Size = new System.Drawing.Size(325, 67);
            this.pnlWrong.TabIndex = 13;
            // 
            // txtWrongPosition1
            // 
            this.txtWrongPosition1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWrongPosition1.Location = new System.Drawing.Point(13, 15);
            this.txtWrongPosition1.Margin = new System.Windows.Forms.Padding(5);
            this.txtWrongPosition1.MaxLength = 20;
            this.txtWrongPosition1.Name = "txtWrongPosition1";
            this.txtWrongPosition1.Size = new System.Drawing.Size(52, 27);
            this.txtWrongPosition1.TabIndex = 1;
            this.txtWrongPosition1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWrongPosition1.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtWrongPosition2
            // 
            this.txtWrongPosition2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWrongPosition2.Location = new System.Drawing.Point(75, 15);
            this.txtWrongPosition2.Margin = new System.Windows.Forms.Padding(5);
            this.txtWrongPosition2.MaxLength = 20;
            this.txtWrongPosition2.Name = "txtWrongPosition2";
            this.txtWrongPosition2.Size = new System.Drawing.Size(52, 27);
            this.txtWrongPosition2.TabIndex = 2;
            this.txtWrongPosition2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWrongPosition2.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtWrongPosition3
            // 
            this.txtWrongPosition3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWrongPosition3.Location = new System.Drawing.Point(137, 15);
            this.txtWrongPosition3.Margin = new System.Windows.Forms.Padding(5);
            this.txtWrongPosition3.MaxLength = 20;
            this.txtWrongPosition3.Name = "txtWrongPosition3";
            this.txtWrongPosition3.Size = new System.Drawing.Size(52, 27);
            this.txtWrongPosition3.TabIndex = 3;
            this.txtWrongPosition3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWrongPosition3.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtWrongPosition4
            // 
            this.txtWrongPosition4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWrongPosition4.Location = new System.Drawing.Point(199, 15);
            this.txtWrongPosition4.Margin = new System.Windows.Forms.Padding(5);
            this.txtWrongPosition4.MaxLength = 20;
            this.txtWrongPosition4.Name = "txtWrongPosition4";
            this.txtWrongPosition4.Size = new System.Drawing.Size(52, 27);
            this.txtWrongPosition4.TabIndex = 4;
            this.txtWrongPosition4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWrongPosition4.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // txtWrongPosition5
            // 
            this.txtWrongPosition5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWrongPosition5.Location = new System.Drawing.Point(261, 15);
            this.txtWrongPosition5.Margin = new System.Windows.Forms.Padding(5);
            this.txtWrongPosition5.MaxLength = 20;
            this.txtWrongPosition5.Name = "txtWrongPosition5";
            this.txtWrongPosition5.Size = new System.Drawing.Size(53, 27);
            this.txtWrongPosition5.TabIndex = 5;
            this.txtWrongPosition5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWrongPosition5.TextChanged += new System.EventHandler(this.txtLetterOne_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 67);
            this.label4.TabIndex = 15;
            this.label4.Text = "2. Informe as letras q existem, mas estão fora de posição";
            // 
            // lblPalavras
            // 
            this.lblPalavras.Location = new System.Drawing.Point(422, 9);
            this.lblPalavras.Name = "lblPalavras";
            this.lblPalavras.Size = new System.Drawing.Size(253, 29);
            this.lblPalavras.TabIndex = 16;
            this.lblPalavras.Text = " - ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 558);
            this.Controls.Add(this.lblPalavras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlWrong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlLetters);
            this.Controls.Add(this.dgWords);
            this.Controls.Add(this.txtNotContain);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Termooo Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).EndInit();
            this.pnlLetters.ResumeLayout(false);
            this.pnlLetters.PerformLayout();
            this.pnlWrong.ResumeLayout(false);
            this.pnlWrong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLetterOne;
        private TextBox txtLetterTwo;
        private TextBox txtLetterThree;
        private TextBox txtLetterFour;
        private TextBox txtLetterFive;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContains;
        private TextBox txtNotContain;
        private DataGridView dgWords;
        private Panel pnlLetters;
        private DataGridViewTextBoxColumn palavras;
        private Button btnSearch;
        private Button btnReset;
        private Panel pnlWrong;
        private TextBox txtWrongPosition1;
        private TextBox txtWrongPosition2;
        private TextBox txtWrongPosition3;
        private TextBox txtWrongPosition4;
        private TextBox txtWrongPosition5;
        private Label label4;
        private Label lblPalavras;
    }
}