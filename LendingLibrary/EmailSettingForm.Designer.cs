namespace LendingLibrary
{
    partial class EmailSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailSettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_Body = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(105, 6);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(334, 22);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(105, 34);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(334, 22);
            this.textBox_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "@gmail.com";
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(105, 90);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(334, 22);
            this.textBox_Subject.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_Body
            // 
            this.richTextBox_Body.Location = new System.Drawing.Point(105, 118);
            this.richTextBox_Body.Name = "richTextBox_Body";
            this.richTextBox_Body.Size = new System.Drawing.Size(424, 146);
            this.richTextBox_Body.TabIndex = 7;
            this.richTextBox_Body.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Body";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(454, 370);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 274);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(517, 90);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "<1>: Name (First)\r\n<2>: Name (Last)\r\n<3>: Item Category\r\n<4>: Item Description\r\n<" +
    "5>: Due Date";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_From
            // 
            this.textBox_From.Location = new System.Drawing.Point(105, 62);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(334, 22);
            this.textBox_From.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "From";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 405);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Body);
            this.Controls.Add(this.textBox_Subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(557, 444);
            this.MinimumSize = new System.Drawing.Size(557, 444);
            this.Name = "EmailSettingForm";
            this.Text = "Email Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_Body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.Label label6;
    }
}