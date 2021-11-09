
namespace HelloVisualWorld
{
    partial class HelloForm
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
            this.displayOutputButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.changeOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayOutputButton
            // 
            this.displayOutputButton.Location = new System.Drawing.Point(64, 39);
            this.displayOutputButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayOutputButton.Name = "displayOutputButton";
            this.displayOutputButton.Size = new System.Drawing.Size(51, 36);
            this.displayOutputButton.TabIndex = 0;
            this.displayOutputButton.Text = "Click here";
            this.displayOutputButton.UseVisualStyleBackColor = true;
            this.displayOutputButton.Click += new System.EventHandler(this.DisplayOutputButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(80, 140);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(99, 13);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Hello, Visual World!";
            this.helloLabel.Visible = false;
            // 
            // changeOutputButton
            // 
            this.changeOutputButton.Enabled = false;
            this.changeOutputButton.Location = new System.Drawing.Point(80, 195);
            this.changeOutputButton.Name = "changeOutputButton";
            this.changeOutputButton.Size = new System.Drawing.Size(75, 23);
            this.changeOutputButton.TabIndex = 2;
            this.changeOutputButton.Text = "Click me";
            this.changeOutputButton.UseVisualStyleBackColor = true;
            this.changeOutputButton.Click += new System.EventHandler(this.ChangeOutputButton_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 416);
            this.Controls.Add(this.changeOutputButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.displayOutputButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HelloForm";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayOutputButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button changeOutputButton;
    }
}

