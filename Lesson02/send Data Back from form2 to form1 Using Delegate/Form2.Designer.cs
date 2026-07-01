namespace send_Data_Back_from_form2_to_form1_Using_Delegate
{
    partial class Form2
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
            this.btnSendDataBack = new System.Windows.Forms.Button();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendDataBack
            // 
            this.btnSendDataBack.Location = new System.Drawing.Point(312, 113);
            this.btnSendDataBack.Name = "btnSendDataBack";
            this.btnSendDataBack.Size = new System.Drawing.Size(157, 44);
            this.btnSendDataBack.TabIndex = 0;
            this.btnSendDataBack.Text = "Send Data Back";
            this.btnSendDataBack.UseVisualStyleBackColor = true;
            this.btnSendDataBack.Click += new System.EventHandler(this.btnSendDataBack_Click);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(43, 113);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(210, 44);
            this.txtPersonID.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(518, 297);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.btnSendDataBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendDataBack;
        private System.Windows.Forms.TextBox txtPersonID;
    }
}