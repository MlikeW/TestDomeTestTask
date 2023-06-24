namespace AmazonOrderPrice
{
    partial class OrderDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resultLabel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.categoryTextBoxError = new System.Windows.Forms.Label();
            this.countryTextBoxError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter details of your order to get a calculated price from Amazon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Enter the details of your order in the input fields";
            this.groupBox1.Controls.Add(this.countryTextBoxError);
            this.groupBox1.Controls.Add(this.categoryTextBoxError);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(109, 73);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(166, 20);
            this.countryTextBox.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(109, 30);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(166, 20);
            this.categoryTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Delivery country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product category";
            // 
            // sendButton
            // 
            this.sendButton.AccessibleDescription = "Click button to get a calculated price based on entered attributes";
            this.sendButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendButton.Location = new System.Drawing.Point(401, 92);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(173, 56);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultLabel.Location = new System.Drawing.Point(344, 196);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(227, 196);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(53, 24);
            this.Price.TabIndex = 6;
            this.Price.Text = "Price";
            // 
            // categoryTextBoxError
            // 
            this.categoryTextBoxError.AutoSize = true;
            this.categoryTextBoxError.ForeColor = System.Drawing.Color.Red;
            this.categoryTextBoxError.Location = new System.Drawing.Point(106, 53);
            this.categoryTextBoxError.Name = "categoryTextBoxError";
            this.categoryTextBoxError.Size = new System.Drawing.Size(0, 13);
            this.categoryTextBoxError.TabIndex = 4;
            // 
            // countryTextBoxError
            // 
            this.countryTextBoxError.AutoSize = true;
            this.countryTextBoxError.ForeColor = System.Drawing.Color.Red;
            this.countryTextBoxError.Location = new System.Drawing.Point(106, 96);
            this.countryTextBoxError.Name = "countryTextBoxError";
            this.countryTextBoxError.Size = new System.Drawing.Size(0, 13);
            this.countryTextBoxError.TabIndex = 5;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 293);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "OrderDetailsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label countryTextBoxError;
        private System.Windows.Forms.Label categoryTextBoxError;
    }
}

