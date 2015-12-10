namespace MVPDemo
{
    partial class DemoGuide
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
            this.buttonCustomerView = new System.Windows.Forms.Button();
            this.buttonVIPCustomerView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCustomerView
            // 
            this.buttonCustomerView.Location = new System.Drawing.Point(31, 12);
            this.buttonCustomerView.Name = "buttonCustomerView";
            this.buttonCustomerView.Size = new System.Drawing.Size(110, 70);
            this.buttonCustomerView.TabIndex = 0;
            this.buttonCustomerView.Text = "CustomerView";
            this.buttonCustomerView.UseVisualStyleBackColor = true;
            this.buttonCustomerView.Click += new System.EventHandler(this.buttonCustomerView_Click);
            // 
            // buttonVIPCustomerView
            // 
            this.buttonVIPCustomerView.Location = new System.Drawing.Point(147, 12);
            this.buttonVIPCustomerView.Name = "buttonVIPCustomerView";
            this.buttonVIPCustomerView.Size = new System.Drawing.Size(110, 70);
            this.buttonVIPCustomerView.TabIndex = 1;
            this.buttonVIPCustomerView.Text = "VIPCustomerView";
            this.buttonVIPCustomerView.UseVisualStyleBackColor = true;
            this.buttonVIPCustomerView.Click += new System.EventHandler(this.buttonVIPCustomerView_Click);
            // 
            // DemoGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.Controls.Add(this.buttonVIPCustomerView);
            this.Controls.Add(this.buttonCustomerView);
            this.Name = "DemoGuide";
            this.Text = "DemoGuide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DemoGuide_FormClosed);
            this.Load += new System.EventHandler(this.DemoGuide_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomerView;
        private System.Windows.Forms.Button buttonVIPCustomerView;
    }
}