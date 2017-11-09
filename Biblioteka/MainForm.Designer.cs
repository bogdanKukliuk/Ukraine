namespace Biblioteka
{
    partial class MainForm
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
            this.tabContUser = new System.Windows.Forms.TabControl();
            this.tabPageUserInfo = new System.Windows.Forms.TabPage();
            this.tabPageLibreryInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabContUser.SuspendLayout();
            this.tabPageLibreryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContUser
            // 
            this.tabContUser.Controls.Add(this.tabPageUserInfo);
            this.tabContUser.Controls.Add(this.tabPageLibreryInfo);
            this.tabContUser.Location = new System.Drawing.Point(0, 0);
            this.tabContUser.Name = "tabContUser";
            this.tabContUser.SelectedIndex = 0;
            this.tabContUser.Size = new System.Drawing.Size(618, 276);
            this.tabContUser.TabIndex = 0;
            // 
            // tabPageUserInfo
            // 
            this.tabPageUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserInfo.Name = "tabPageUserInfo";
            this.tabPageUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserInfo.Size = new System.Drawing.Size(528, 250);
            this.tabPageUserInfo.TabIndex = 0;
            this.tabPageUserInfo.Text = "My info";
            this.tabPageUserInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageLibreryInfo
            // 
            this.tabPageLibreryInfo.Controls.Add(this.btnSearch);
            this.tabPageLibreryInfo.Controls.Add(this.txtNameBook);
            this.tabPageLibreryInfo.Controls.Add(this.label1);
            this.tabPageLibreryInfo.Controls.Add(this.btnReturn);
            this.tabPageLibreryInfo.Controls.Add(this.btnBuy);
            this.tabPageLibreryInfo.Controls.Add(this.dataGridView1);
            this.tabPageLibreryInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageLibreryInfo.Name = "tabPageLibreryInfo";
            this.tabPageLibreryInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLibreryInfo.Size = new System.Drawing.Size(610, 250);
            this.tabPageLibreryInfo.TabIndex = 1;
            this.tabPageLibreryInfo.Text = "Librery";
            this.tabPageLibreryInfo.UseVisualStyleBackColor = true;
            this.tabPageLibreryInfo.Click += new System.EventHandler(this.tabPageLibreryInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameBook,
            this.PriceBook,
            this.Author});
            this.dataGridView1.Location = new System.Drawing.Point(9, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "NameBook";
            this.NameBook.Name = "NameBook";
            this.NameBook.Width = 154;
            // 
            // PriceBook
            // 
            this.PriceBook.HeaderText = "PriceBook";
            this.PriceBook.Name = "PriceBook";
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(446, 6);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(142, 38);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(446, 205);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 38);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(447, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name Book";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(446, 72);
            this.txtNameBook.Multiline = true;
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(161, 29);
            this.txtNameBook.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(446, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 277);
            this.Controls.Add(this.tabContUser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabContUser.ResumeLayout(false);
            this.tabPageLibreryInfo.ResumeLayout(false);
            this.tabPageLibreryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContUser;
        private System.Windows.Forms.TabPage tabPageUserInfo;
        private System.Windows.Forms.TabPage tabPageLibreryInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label1;
    }
}