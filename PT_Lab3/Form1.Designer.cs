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
            this.processButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleNumsMode = new System.Windows.Forms.RadioButton();
            this.task16Mode = new System.Windows.Forms.RadioButton();
            this.arraySortMode = new System.Windows.Forms.RadioButton();
            this.calculateSumMode = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deserializeArrayButton = new System.Windows.Forms.Button();
            this.openResultsButton = new System.Windows.Forms.Button();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.serializeArrayButton.Enabled = false;
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
            this.arrSizeSelect.Location = new System.Drawing.Point(58, 27);
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
            this.maxValueSelect.Location = new System.Drawing.Point(398, 25);
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
            this.minValueSelect.Location = new System.Drawing.Point(228, 25);
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
            this.serializeResultsButton.Enabled = false;
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
            this.generateArrayButton.Location = new System.Drawing.Point(12, 22);
            this.generateArrayButton.Name = "generateArrayButton";
            this.generateArrayButton.Size = new System.Drawing.Size(139, 23);
            this.generateArrayButton.TabIndex = 6;
            this.generateArrayButton.Text = "Generate Array";
            this.generateArrayButton.UseVisualStyleBackColor = true;
            this.generateArrayButton.Click += new System.EventHandler(this.generateArrayButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.generateArrayButton);
            this.groupBox1.Location = new System.Drawing.Point(399, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 247);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Enabled = false;
            this.processButton.Location = new System.Drawing.Point(12, 192);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(268, 38);
            this.processButton.TabIndex = 10;
            this.processButton.Text = "Process operating";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(157, 139);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 47);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleNumsMode);
            this.groupBox3.Controls.Add(this.task16Mode);
            this.groupBox3.Controls.Add(this.arraySortMode);
            this.groupBox3.Controls.Add(this.calculateSumMode);
            this.groupBox3.Location = new System.Drawing.Point(157, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // simpleNumsMode
            // 
            this.simpleNumsMode.AutoSize = true;
            this.simpleNumsMode.Location = new System.Drawing.Point(6, 84);
            this.simpleNumsMode.Name = "simpleNumsMode";
            this.simpleNumsMode.Size = new System.Drawing.Size(96, 19);
            this.simpleNumsMode.TabIndex = 3;
            this.simpleNumsMode.Text = "Simple Nums";
            this.simpleNumsMode.UseVisualStyleBackColor = true;
            // 
            // task16Mode
            // 
            this.task16Mode.AutoSize = true;
            this.task16Mode.Location = new System.Drawing.Point(6, 59);
            this.task16Mode.Name = "task16Mode";
            this.task16Mode.Size = new System.Drawing.Size(62, 19);
            this.task16Mode.TabIndex = 2;
            this.task16Mode.Text = "Task 16";
            this.task16Mode.UseVisualStyleBackColor = true;
            // 
            // arraySortMode
            // 
            this.arraySortMode.AutoSize = true;
            this.arraySortMode.Location = new System.Drawing.Point(6, 37);
            this.arraySortMode.Name = "arraySortMode";
            this.arraySortMode.Size = new System.Drawing.Size(77, 19);
            this.arraySortMode.TabIndex = 1;
            this.arraySortMode.Text = "Sort Array";
            this.arraySortMode.UseVisualStyleBackColor = true;
            // 
            // calculateSumMode
            // 
            this.calculateSumMode.AutoSize = true;
            this.calculateSumMode.Checked = true;
            this.calculateSumMode.Location = new System.Drawing.Point(6, 12);
            this.calculateSumMode.Name = "calculateSumMode";
            this.calculateSumMode.Size = new System.Drawing.Size(101, 19);
            this.calculateSumMode.TabIndex = 0;
            this.calculateSumMode.TabStop = true;
            this.calculateSumMode.Text = "Calculate Sum";
            this.calculateSumMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deserializeArrayButton);
            this.groupBox2.Controls.Add(this.openResultsButton);
            this.groupBox2.Controls.Add(this.serializeArrayButton);
            this.groupBox2.Controls.Add(this.serializeResultsButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
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
            this.arrayBox.Size = new System.Drawing.Size(656, 23);
            this.arrayBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "N = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "B =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private RadioButton simpleNumsMode;
        private RadioButton task16Mode;
        private RadioButton arraySortMode;
        private RadioButton calculateSumMode;
        private Button processButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}