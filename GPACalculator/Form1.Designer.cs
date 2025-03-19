namespace GPACalculator
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSemesterCount = new System.Windows.Forms.Label();
            this.numSemesters = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateSemesters = new System.Windows.Forms.Button();
            this.pnlSemesters = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSemesters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CGPA Calculator";
            // 
            // lblSemesterCount
            // 
            this.lblSemesterCount.AutoSize = true;
            this.lblSemesterCount.Location = new System.Drawing.Point(14, 55);
            this.lblSemesterCount.Name = "lblSemesterCount";
            this.lblSemesterCount.Size = new System.Drawing.Size(116, 13);
            this.lblSemesterCount.TabIndex = 1;
            this.lblSemesterCount.Text = "Number of Semesters:";
            // 
            // numSemesters
            // 
            this.numSemesters.Location = new System.Drawing.Point(136, 53);
            this.numSemesters.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSemesters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemesters.Name = "numSemesters";
            this.numSemesters.Size = new System.Drawing.Size(62, 20);
            this.numSemesters.TabIndex = 2;
            this.numSemesters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerateSemesters
            // 
            this.btnGenerateSemesters.Location = new System.Drawing.Point(204, 52);
            this.btnGenerateSemesters.Name = "btnGenerateSemesters";
            this.btnGenerateSemesters.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSemesters.TabIndex = 3;
            this.btnGenerateSemesters.Text = "Generate";
            this.btnGenerateSemesters.UseVisualStyleBackColor = true;
            this.btnGenerateSemesters.Click += new System.EventHandler(this.btnGenerateSemesters_Click);
            // 
            // pnlSemesters
            // 
            this.pnlSemesters.AutoScroll = true;
            this.pnlSemesters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSemesters.Location = new System.Drawing.Point(17, 129);
            this.pnlSemesters.Name = "pnlSemesters";
            this.pnlSemesters.Size = new System.Drawing.Size(350, 200);
            this.pnlSemesters.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(17, 345);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate CGPA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(17, 388);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(139, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Your CGPA: 0.00";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(247, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(14, 89);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(328, 26);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Enter your GPA for each semester (between 0.00 and 4.00).\r\nAlso enter the number of credit hours for each semester (between 1 and 30).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlSemesters);
            this.Controls.Add(this.btnGenerateSemesters);
            this.Controls.Add(this.numSemesters);
            this.Controls.Add(this.lblSemesterCount);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGPA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSemesters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSemesterCount;
        private System.Windows.Forms.NumericUpDown numSemesters;
        private System.Windows.Forms.Button btnGenerateSemesters;
        private System.Windows.Forms.Panel pnlSemesters;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblInstructions;
    }
}