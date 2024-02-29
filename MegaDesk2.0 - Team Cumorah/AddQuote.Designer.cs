namespace MegaDesk2._0___Team_Cumorah
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelRushOrder = new System.Windows.Forms.Label();
            this.submitQuoteInputButton = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.NoRushOrder = new System.Windows.Forms.RadioButton();
            this.SurfaceMaterialSelection = new System.Windows.Forms.ListBox();
            this.Day3Rush = new System.Windows.Forms.RadioButton();
            this.Day5Rush = new System.Windows.Forms.RadioButton();
            this.Day7Rush = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.orderRadioBox = new System.Windows.Forms.GroupBox();
            this.rushOrderMessage = new System.Windows.Forms.Label();
            this.materialSelectionMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.orderRadioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please complete all fields:";
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(18, 64);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Padding = new System.Windows.Forms.Padding(2);
            this.labelFullName.Size = new System.Drawing.Size(212, 32);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Enter your full name:";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWidth
            // 
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(18, 106);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Padding = new System.Windows.Forms.Padding(2);
            this.labelWidth.Size = new System.Drawing.Size(399, 32);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Enter a Width from 24 to 96 inches:";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDepth
            // 
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(18, 147);
            this.labelDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Padding = new System.Windows.Forms.Padding(2);
            this.labelDepth.Size = new System.Drawing.Size(399, 32);
            this.labelDepth.TabIndex = 3;
            this.labelDepth.Text = "Enter a Depth from 12 to 48 inches:";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDrawers
            // 
            this.labelDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawers.Location = new System.Drawing.Point(17, 190);
            this.labelDrawers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Padding = new System.Windows.Forms.Padding(2);
            this.labelDrawers.Size = new System.Drawing.Size(348, 32);
            this.labelDrawers.TabIndex = 4;
            this.labelDrawers.Text = "Enter the number of Drawers:";
            this.labelDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaterial
            // 
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(18, 231);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.labelMaterial.Size = new System.Drawing.Size(329, 32);
            this.labelMaterial.TabIndex = 5;
            this.labelMaterial.Text = "Select Surface Material:";
            this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRushOrder
            // 
            this.labelRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRushOrder.Location = new System.Drawing.Point(19, 422);
            this.labelRushOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRushOrder.Name = "labelRushOrder";
            this.labelRushOrder.Padding = new System.Windows.Forms.Padding(2);
            this.labelRushOrder.Size = new System.Drawing.Size(250, 32);
            this.labelRushOrder.TabIndex = 6;
            this.labelRushOrder.Text = "Shipping:";
            this.labelRushOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submitQuoteInputButton
            // 
            this.submitQuoteInputButton.AutoSize = true;
            this.submitQuoteInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitQuoteInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuoteInputButton.ForeColor = System.Drawing.Color.White;
            this.submitQuoteInputButton.Location = new System.Drawing.Point(284, 624);
            this.submitQuoteInputButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitQuoteInputButton.Name = "submitQuoteInputButton";
            this.submitQuoteInputButton.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.submitQuoteInputButton.Size = new System.Drawing.Size(133, 45);
            this.submitQuoteInputButton.TabIndex = 10;
            this.submitQuoteInputButton.Text = "Submit";
            this.submitQuoteInputButton.UseVisualStyleBackColor = false;
            this.submitQuoteInputButton.Click += new System.EventHandler(this.SubmitQuoteInputButton_Click);
            // 
            // FullName
            // 
            this.FullName.AcceptsTab = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(234, 66);
            this.FullName.Margin = new System.Windows.Forms.Padding(2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(422, 30);
            this.FullName.TabIndex = 1;
            this.FullName.Validating += new System.ComponentModel.CancelEventHandler(this.FullName_Validating);
            this.FullName.Validated += new System.EventHandler(this.FullName_Validated_1);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.AcceptsTab = true;
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(439, 106);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(216, 30);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            this.WidthTextBox.Validated += new System.EventHandler(this.WidthTextBox_Validated);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.AcceptsTab = true;
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(439, 150);
            this.DepthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(216, 30);
            this.DepthTextBox.TabIndex = 3;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            this.DepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthTextBox_Validating);
            this.DepthTextBox.Validated += new System.EventHandler(this.DepthTextBox_Validated);
            // 
            // NumberOfDrawersInput
            // 
            this.NumberOfDrawersInput.AllowDrop = true;
            this.NumberOfDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersInput.Location = new System.Drawing.Point(439, 190);
            this.NumberOfDrawersInput.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfDrawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawersInput.Name = "NumberOfDrawersInput";
            this.NumberOfDrawersInput.Size = new System.Drawing.Size(215, 30);
            this.NumberOfDrawersInput.TabIndex = 4;
            this.NumberOfDrawersInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfDrawersInput.ValueChanged += new System.EventHandler(this.NumberOfDrawersInput_ValueChanged);
            // 
            // NoRushOrder
            // 
            this.NoRushOrder.AutoSize = true;
            this.NoRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRushOrder.Location = new System.Drawing.Point(20, 112);
            this.NoRushOrder.Margin = new System.Windows.Forms.Padding(2);
            this.NoRushOrder.Name = "NoRushOrder";
            this.NoRushOrder.Size = new System.Drawing.Size(170, 29);
            this.NoRushOrder.TabIndex = 9;
            this.NoRushOrder.TabStop = true;
            this.NoRushOrder.Text = "None (14-days)";
            this.NoRushOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoRushOrder.UseVisualStyleBackColor = true;
            this.NoRushOrder.CheckedChanged += new System.EventHandler(this.NoRushOrder_CheckedChanged);
            // 
            // SurfaceMaterialSelection
            // 
            this.SurfaceMaterialSelection.AccessibleDescription = "Surface Material Options";
            this.SurfaceMaterialSelection.AllowDrop = true;
            this.SurfaceMaterialSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialSelection.FormattingEnabled = true;
            this.SurfaceMaterialSelection.ItemHeight = 25;
            this.SurfaceMaterialSelection.Location = new System.Drawing.Point(24, 270);
            this.SurfaceMaterialSelection.Margin = new System.Windows.Forms.Padding(2);
            this.SurfaceMaterialSelection.Name = "SurfaceMaterialSelection";
            this.SurfaceMaterialSelection.Size = new System.Drawing.Size(224, 104);
            this.SurfaceMaterialSelection.TabIndex = 5;
            this.SurfaceMaterialSelection.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterialSelection_SelectedIndexChanged);
            // 
            // Day3Rush
            // 
            this.Day3Rush.AutoSize = true;
            this.Day3Rush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3Rush.Location = new System.Drawing.Point(20, 22);
            this.Day3Rush.Margin = new System.Windows.Forms.Padding(2);
            this.Day3Rush.Name = "Day3Rush";
            this.Day3Rush.Size = new System.Drawing.Size(176, 29);
            this.Day3Rush.TabIndex = 6;
            this.Day3Rush.TabStop = true;
            this.Day3Rush.Text = "3 Days Shipping";
            this.Day3Rush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Day3Rush.UseVisualStyleBackColor = true;
            this.Day3Rush.CheckedChanged += new System.EventHandler(this.Day3Rush_CheckedChanged);
            // 
            // Day5Rush
            // 
            this.Day5Rush.AutoSize = true;
            this.Day5Rush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5Rush.Location = new System.Drawing.Point(20, 52);
            this.Day5Rush.Margin = new System.Windows.Forms.Padding(2);
            this.Day5Rush.Name = "Day5Rush";
            this.Day5Rush.Size = new System.Drawing.Size(176, 29);
            this.Day5Rush.TabIndex = 7;
            this.Day5Rush.TabStop = true;
            this.Day5Rush.Text = "5 Days Shipping";
            this.Day5Rush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Day5Rush.UseVisualStyleBackColor = true;
            this.Day5Rush.CheckedChanged += new System.EventHandler(this.Day5Rush_CheckedChanged);
            // 
            // Day7Rush
            // 
            this.Day7Rush.AutoSize = true;
            this.Day7Rush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7Rush.Location = new System.Drawing.Point(20, 82);
            this.Day7Rush.Margin = new System.Windows.Forms.Padding(2);
            this.Day7Rush.Name = "Day7Rush";
            this.Day7Rush.Size = new System.Drawing.Size(176, 29);
            this.Day7Rush.TabIndex = 8;
            this.Day7Rush.TabStop = true;
            this.Day7Rush.Text = "7 Days Shipping";
            this.Day7Rush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Day7Rush.UseVisualStyleBackColor = true;
            this.Day7Rush.CheckedChanged += new System.EventHandler(this.Day7Rush_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // orderRadioBox
            // 
            this.orderRadioBox.Controls.Add(this.Day7Rush);
            this.orderRadioBox.Controls.Add(this.NoRushOrder);
            this.orderRadioBox.Controls.Add(this.Day5Rush);
            this.orderRadioBox.Controls.Add(this.Day3Rush);
            this.orderRadioBox.Location = new System.Drawing.Point(23, 453);
            this.orderRadioBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderRadioBox.Name = "orderRadioBox";
            this.orderRadioBox.Padding = new System.Windows.Forms.Padding(2);
            this.orderRadioBox.Size = new System.Drawing.Size(223, 146);
            this.orderRadioBox.TabIndex = 11;
            this.orderRadioBox.TabStop = false;
            // 
            // rushOrderMessage
            // 
            this.rushOrderMessage.AutoSize = true;
            this.rushOrderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderMessage.Location = new System.Drawing.Point(300, 427);
            this.rushOrderMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rushOrderMessage.Name = "rushOrderMessage";
            this.rushOrderMessage.Size = new System.Drawing.Size(327, 25);
            this.rushOrderMessage.TabIndex = 12;
            this.rushOrderMessage.Text = "Please select an option for Shipping.";
            // 
            // materialSelectionMessage
            // 
            this.materialSelectionMessage.AutoSize = true;
            this.materialSelectionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSelectionMessage.Location = new System.Drawing.Point(300, 270);
            this.materialSelectionMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialSelectionMessage.Name = "materialSelectionMessage";
            this.materialSelectionMessage.Size = new System.Drawing.Size(222, 25);
            this.materialSelectionMessage.TabIndex = 13;
            this.materialSelectionMessage.Text = "Please select a material.";
            // 
            // AddQuote
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(685, 695);
            this.Controls.Add(this.materialSelectionMessage);
            this.Controls.Add(this.rushOrderMessage);
            this.Controls.Add(this.orderRadioBox);
            this.Controls.Add(this.SurfaceMaterialSelection);
            this.Controls.Add(this.NumberOfDrawersInput);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.submitQuoteInputButton);
            this.Controls.Add(this.labelRushOrder);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuoteForm_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.orderRadioBox.ResumeLayout(false);
            this.orderRadioBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelRushOrder;
        private System.Windows.Forms.Button submitQuoteInputButton;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.NumericUpDown NumberOfDrawersInput;
        private System.Windows.Forms.RadioButton NoRushOrder;
        private System.Windows.Forms.ListBox SurfaceMaterialSelection;
        private System.Windows.Forms.RadioButton Day3Rush;
        private System.Windows.Forms.RadioButton Day5Rush;
        private System.Windows.Forms.RadioButton Day7Rush;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox orderRadioBox;
        private System.Windows.Forms.Label materialSelectionMessage;
        private System.Windows.Forms.Label rushOrderMessage;
    }
}