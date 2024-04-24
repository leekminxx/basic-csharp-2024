namespace NewBookRentalShopApp
{
    partial class PopBook
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
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSelect = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvResult
            // 
            this.DgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(20, 60);
            this.DgvResult.MultiSelect = false;
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvResult.Size = new System.Drawing.Size(554, 278);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellContentClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(504, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(400, 347);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(70, 30);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "선택";
            this.BtnSelect.UseSelectable = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // PopBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DgvResult);
            this.Name = "PopBook";
            this.Resizable = false;
            this.Text = "책선택";
            this.Load += new System.EventHandler(this.PopMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvResult;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSelect;
    }
}