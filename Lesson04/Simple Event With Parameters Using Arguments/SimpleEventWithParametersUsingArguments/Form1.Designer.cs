namespace SimpleEventWithParametersUsingArguments
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
            this.ctrlSum2 = new SimpleEventWithParametersUsingArguments.ctrlSum();
            this.SuspendLayout();
            // 
            // ctrlSum2
            // 
            this.ctrlSum2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlSum2.Location = new System.Drawing.Point(148, 29);
            this.ctrlSum2.Name = "ctrlSum2";
            this.ctrlSum2.Size = new System.Drawing.Size(353, 117);
            this.ctrlSum2.TabIndex = 0;
            this.ctrlSum2.OnCalculationComplete += new System.EventHandler<SimpleEventWithParametersUsingArguments.ctrlSum.CalculationCompleteEventArgs>(this.ctrlSum2_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 289);
            this.Controls.Add(this.ctrlSum2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSum ctrlSum1;
        private ctrlSum ctrlSum2;
    }
}

