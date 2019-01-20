namespace WebhookClientCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SubscriptionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.URLButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.CLSButton = new System.Windows.Forms.Button();
            this.unsubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubscriptionLabel
            // 
            this.SubscriptionLabel.AutoSize = true;
            this.SubscriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.SubscriptionLabel.Name = "SubscriptionLabel";
            this.SubscriptionLabel.Size = new System.Drawing.Size(115, 13);
            this.SubscriptionLabel.TabIndex = 0;
            this.SubscriptionLabel.Text = "Webhook Subscription";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // URLButton
            // 
            this.URLButton.Location = new System.Drawing.Point(267, 56);
            this.URLButton.Name = "URLButton";
            this.URLButton.Size = new System.Drawing.Size(75, 23);
            this.URLButton.TabIndex = 3;
            this.URLButton.Text = "Subscribe";
            this.URLButton.UseVisualStyleBackColor = true;
            this.URLButton.Click += new System.EventHandler(this.URLButton_Click);
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(16, 88);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(72, 13);
            this.subLabel.TabIndex = 4;
            this.subLabel.Text = "Unsubscribed";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(12, 104);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(330, 267);
            this.ConsoleBox.TabIndex = 5;
            this.ConsoleBox.Text = "";
            // 
            // CLSButton
            // 
            this.CLSButton.Location = new System.Drawing.Point(12, 377);
            this.CLSButton.Name = "CLSButton";
            this.CLSButton.Size = new System.Drawing.Size(167, 23);
            this.CLSButton.TabIndex = 6;
            this.CLSButton.Text = "Clear";
            this.CLSButton.UseVisualStyleBackColor = true;
            this.CLSButton.Click += new System.EventHandler(this.CLSButton_Click);
            // 
            // unsubButton
            // 
            this.unsubButton.Location = new System.Drawing.Point(185, 377);
            this.unsubButton.Name = "unsubButton";
            this.unsubButton.Size = new System.Drawing.Size(156, 23);
            this.unsubButton.TabIndex = 7;
            this.unsubButton.Text = "Unsubscribe";
            this.unsubButton.UseVisualStyleBackColor = true;
            this.unsubButton.Click += new System.EventHandler(this.unsubButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 403);
            this.Controls.Add(this.unsubButton);
            this.Controls.Add(this.CLSButton);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.URLButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SubscriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Webhook Subscription Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubscriptionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button URLButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.Button CLSButton;
        private System.Windows.Forms.Button unsubButton;
    }
}

