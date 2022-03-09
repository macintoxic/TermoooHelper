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
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).BeginInit();
            this.pnlLetters.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 67);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Informe as letras que ESTÃO na palavra";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 67);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. Informe as letras que NÃO estão na palavra";
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(51, 230);
            this.txtContains.Margin = new System.Windows.Forms.Padding(5);
            this.txtContains.MaxLength = 26;
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(281, 33);
            this.txtContains.TabIndex = 9;
            // 
            // txtNotContain
            // 
            this.txtNotContain.Location = new System.Drawing.Point(51, 342);
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
            this.dgWords.Location = new System.Drawing.Point(422, 33);
            this.dgWords.Name = "dgWords";
            this.dgWords.RowTemplate.Height = 25;
            this.dgWords.Size = new System.Drawing.Size(253, 297);
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
            this.btnSearch.Location = new System.Drawing.Point(422, 346);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 38);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Buscar [F5]";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(555, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 38);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 418);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).EndInit();
            this.pnlLetters.ResumeLayout(false);
            this.pnlLetters.PerformLayout();
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
    }
}