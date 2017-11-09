namespace Biblioteka
{
    partial class ReturnForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReturnBook = new System.Windows.Forms.TextBox();
            this.txtReturnAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 172);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(205, 44);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = " Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Book";
            // 
            // txtReturnBook
            // 
            this.txtReturnBook.Location = new System.Drawing.Point(12, 30);
            this.txtReturnBook.Multiline = true;
            this.txtReturnBook.Name = "txtReturnBook";
            this.txtReturnBook.Size = new System.Drawing.Size(205, 29);
            this.txtReturnBook.TabIndex = 2;
            // 
            // txtReturnAuthor
            // 
            this.txtReturnAuthor.Location = new System.Drawing.Point(12, 103);
            this.txtReturnAuthor.Multiline = true;
            this.txtReturnAuthor.Name = "txtReturnAuthor";
            this.txtReturnAuthor.Size = new System.Drawing.Size(205, 29);
            this.txtReturnAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 228);
            this.Controls.Add(this.txtReturnAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReturnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReturnBook;
        private System.Windows.Forms.TextBox txtReturnAuthor;
        private System.Windows.Forms.Label label2;
    }
}