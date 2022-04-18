namespace PT_Lab3
{
    partial class Form1
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
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.serializeArrayButton = new System.Windows.Forms.Button();
            this.arrayGridView = new System.Windows.Forms.DataGridView();
            this.iColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrSizeSelect = new System.Windows.Forms.NumericUpDown();
            this.maxValueSelect = new System.Windows.Forms.NumericUpDown();
            this.minValueSelect = new System.Windows.Forms.NumericUpDown();
            this.serializeResultsButton = new System.Windows.Forms.Button();
            this.generateArrayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deserializeArrayButton = new System.Windows.Forms.Button();
            this.openResultsButton = new System.Windows.Forms.Button();
            this.arrayBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrSizeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueSelect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDialog
            // 
            this.openDialog.Filter = "XML-files|*.xml";
            this.openDialog.InitialDirectory = "\"D:\\Универ\\Программы свои\\PT_Lab3\\PT_Lab3\\source files\"";
            this.openDialog.RestoreDirectory = true;
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "XML files (*.xml)|*.xml";
            this.saveDialog.InitialDirectory = "..";
            this.saveDialog.RestoreDirectory = true;
            // 
            // serializeArrayButton
            // 
            this.serializeArrayButton.Location = new System.Drawing.Point(6, 22);
            this.serializeArrayButton.Name = "serializeArrayButton";
            this.serializeArrayButton.Size = new System.Drawing.Size(133, 23);
            this.serializeArrayButton.TabIndex = 0;
            this.serializeArrayButton.Text = "Save Array";
            this.serializeArrayButton.UseVisualStyleBackColor = true;
            this.serializeArrayButton.Click += new System.EventHandler(this.serializeArrayButton_Click);
            // 
            // arrayGridView
            // 
            this.arrayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iColumn,
            this.ContentColumn});
            this.arrayGridView.Location = new System.Drawing.Point(39, 88);
            this.arrayGridView.Name = "arrayGridView";
            this.arrayGridView.RowTemplate.Height = 25;
            this.arrayGridView.Size = new System.Drawing.Size(240, 322);
            this.arrayGridView.TabIndex = 1;
            // 
            // iColumn
            // 
            this.iColumn.HeaderText = "i";
            this.iColumn.Name = "iColumn";
            this.iColumn.ReadOnly = true;
            // 
            // ContentColumn
            // 
            this.ContentColumn.HeaderText = "Data";
            this.ContentColumn.Name = "ContentColumn";
            this.ContentColumn.ReadOnly = true;
            // 
            // arrSizeSelect
            // 
            this.arrSizeSelect.Location = new System.Drawing.Point(39, 24);
            this.arrSizeSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrSizeSelect.Name = "arrSizeSelect";
            this.arrSizeSelect.Size = new System.Drawing.Size(120, 23);
            this.arrSizeSelect.TabIndex = 2;
            this.arrSizeSelect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // maxValueSelect
            // 
            this.maxValueSelect.Location = new System.Drawing.Point(316, 24);
            this.maxValueSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxValueSelect.Name = "maxValueSelect";
            this.maxValueSelect.Size = new System.Drawing.Size(120, 23);
            this.maxValueSelect.TabIndex = 3;
            this.maxValueSelect.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // minValueSelect
            // 
            this.minValueSelect.Location = new System.Drawing.Point(180, 24);
            this.minValueSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minValueSelect.Name = "minValueSelect";
            this.minValueSelect.Size = new System.Drawing.Size(120, 23);
            this.minValueSelect.TabIndex = 4;
            // 
            // serializeResultsButton
            // 
            this.serializeResultsButton.Location = new System.Drawing.Point(6, 51);
            this.serializeResultsButton.Name = "serializeResultsButton";
            this.serializeResultsButton.Size = new System.Drawing.Size(133, 23);
            this.serializeResultsButton.TabIndex = 5;
            this.serializeResultsButton.Text = "Save Results";
            this.serializeResultsButton.UseVisualStyleBackColor = true;
            this.serializeResultsButton.Click += new System.EventHandler(this.serializeResultsButton_Click);
            // 
            // generateArrayButton
            // 
            this.generateArrayButton.Location = new System.Drawing.Point(6, 42);
            this.generateArrayButton.Name = "generateArrayButton";
            this.generateArrayButton.Size = new System.Drawing.Size(139, 23);
            this.generateArrayButton.TabIndex = 6;
            this.generateArrayButton.Text = "Generate Array";
            this.generateArrayButton.UseVisualStyleBackColor = true;
            this.generateArrayButton.Click += new System.EventHandler(this.generateArrayButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.generateArrayButton);
            this.groupBox1.Location = new System.Drawing.Point(409, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(157, 185);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(157, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 137);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deserializeArrayButton);
            this.groupBox2.Controls.Add(this.openResultsButton);
            this.groupBox2.Controls.Add(this.serializeArrayButton);
            this.groupBox2.Controls.Add(this.serializeResultsButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // deserializeArrayButton
            // 
            this.deserializeArrayButton.Location = new System.Drawing.Point(6, 77);
            this.deserializeArrayButton.Name = "deserializeArrayButton";
            this.deserializeArrayButton.Size = new System.Drawing.Size(133, 23);
            this.deserializeArrayButton.TabIndex = 7;
            this.deserializeArrayButton.Text = "Open Array";
            this.deserializeArrayButton.UseVisualStyleBackColor = true;
            this.deserializeArrayButton.Click += new System.EventHandler(this.deserializeArrayButton_Click);
            // 
            // openResultsButton
            // 
            this.openResultsButton.Location = new System.Drawing.Point(6, 106);
            this.openResultsButton.Name = "openResultsButton";
            this.openResultsButton.Size = new System.Drawing.Size(133, 23);
            this.openResultsButton.TabIndex = 6;
            this.openResultsButton.Text = "Open Results";
            this.openResultsButton.UseVisualStyleBackColor = true;
            this.openResultsButton.Click += new System.EventHandler(this.openResultsButton_Click);
            // 
            // arrayBox
            // 
            this.arrayBox.Location = new System.Drawing.Point(39, 59);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.ReadOnly = true;
            this.arrayBox.Size = new System.Drawing.Size(338, 23);
            this.arrayBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minValueSelect);
            this.Controls.Add(this.maxValueSelect);
            this.Controls.Add(this.arrSizeSelect);
            this.Controls.Add(this.arrayGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrayGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrSizeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueSelect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openDialog;
        private SaveFileDialog saveDialog;
        private Button serializeArrayButton;
        private DataGridView arrayGridView;
        private NumericUpDown arrSizeSelect;
        private NumericUpDown maxValueSelect;
        private NumericUpDown minValueSelect;
        private DataGridViewTextBoxColumn iColumn;
        private DataGridViewTextBoxColumn ContentColumn;
        private Button serializeResultsButton;
        private Button generateArrayButton;
        private GroupBox groupBox1;
        private TextBox arrayBox;
        private Button ClearButton;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button deserializeArrayButton;
        private Button openResultsButton;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}