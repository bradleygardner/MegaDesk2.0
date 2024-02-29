namespace MegaDesk2._0___Team_Cumorah
{
    partial class SearchQuote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.materialSelectBox = new System.Windows.Forms.ComboBox();
            this.buttonCloseSearchQuotes = new System.Windows.Forms.Button();
            this.listAllQuotes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Surface Material:";
            // 
            // materialSelectBox
            // 
            this.materialSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSelectBox.FormattingEnabled = true;
            this.materialSelectBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialSelectBox.Location = new System.Drawing.Point(476, 254);
            this.materialSelectBox.Name = "materialSelectBox";
            this.materialSelectBox.Size = new System.Drawing.Size(455, 46);
            this.materialSelectBox.TabIndex = 1;
            this.materialSelectBox.SelectedIndexChanged += new System.EventHandler(this.materialSelectBox_SelectedIndexChanged);
            // 
            // buttonCloseSearchQuotes
            // 
            this.buttonCloseSearchQuotes.AutoSize = true;
            this.buttonCloseSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseSearchQuotes.Location = new System.Drawing.Point(623, 843);
            this.buttonCloseSearchQuotes.Name = "buttonCloseSearchQuotes";
            this.buttonCloseSearchQuotes.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCloseSearchQuotes.Size = new System.Drawing.Size(136, 64);
            this.buttonCloseSearchQuotes.TabIndex = 3;
            this.buttonCloseSearchQuotes.Text = "Close";
            this.buttonCloseSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonCloseSearchQuotes.Click += new System.EventHandler(this.buttonCloseSearchQuotes_Click);
            // 
            // listAllQuotes
            // 
            this.listAllQuotes.AllowUserToAddRows = false;
            this.listAllQuotes.AllowUserToDeleteRows = false;
            this.listAllQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listAllQuotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listAllQuotes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAllQuotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listAllQuotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.listAllQuotes.Location = new System.Drawing.Point(59, 337);
            this.listAllQuotes.Name = "listAllQuotes";
            this.listAllQuotes.RowHeadersVisible = false;
            this.listAllQuotes.RowHeadersWidth = 82;
            this.listAllQuotes.RowTemplate.Height = 33;
            this.listAllQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listAllQuotes.Size = new System.Drawing.Size(1294, 466);
            this.listAllQuotes.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nameColumn";
            this.Column1.HeaderText = "Customer Name";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 247;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dateColumn";
            this.Column2.HeaderText = "Quote Date";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 194;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "shipColumn";
            this.Column3.HeaderText = "Shipping";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 178;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "widthColumn";
            this.Column4.HeaderText = "Width";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 138;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "depthColumn";
            this.Column5.HeaderText = "Depth";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 141;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "drawersColumn";
            this.Column7.HeaderText = "Drawers";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 169;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "priceColumn";
            this.Column8.HeaderText = "Price";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.Width = 130;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1415, 110);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Quotes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCloseSearchQuotes;
            this.ClientSize = new System.Drawing.Size(1420, 955);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAllQuotes);
            this.Controls.Add(this.buttonCloseSearchQuotes);
            this.Controls.Add(this.materialSelectBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SearchQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For A Quote";
            ((System.ComponentModel.ISupportInitialize)(this.listAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialSelectBox;
        private System.Windows.Forms.Button buttonCloseSearchQuotes;
        private System.Windows.Forms.DataGridView listAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label2;
    }
}