namespace LendingLibrary
{
	partial class MessageBoxText
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxText));
			this.label_TopMsg = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label_BottomMsg = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_TopMsg
			// 
			this.label_TopMsg.Location = new System.Drawing.Point(12, 9);
			this.label_TopMsg.Name = "label_TopMsg";
			this.label_TopMsg.Size = new System.Drawing.Size(344, 123);
			this.label_TopMsg.TabIndex = 0;
			this.label_TopMsg.Text = "Item Info";
			this.label_TopMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 159);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(341, 23);
			this.textBox1.TabIndex = 1;
			// 
			// label_BottomMsg
			// 
			this.label_BottomMsg.Location = new System.Drawing.Point(12, 132);
			this.label_BottomMsg.Name = "label_BottomMsg";
			this.label_BottomMsg.Size = new System.Drawing.Size(344, 24);
			this.label_BottomMsg.TabIndex = 2;
			this.label_BottomMsg.Text = "Checked In By:";
			this.label_BottomMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(261, 188);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(95, 27);
			this.button_OK.TabIndex = 3;
			this.button_OK.Text = "Check-In";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// MessageBoxText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(379, 218);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.label_BottomMsg);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label_TopMsg);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MessageBoxText";
			this.Text = "Check-In Item";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_TopMsg;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label_BottomMsg;
		private System.Windows.Forms.Button button_OK;
	}
}