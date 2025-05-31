namespace FloatingPointMysteries
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
			ConversionErrors_button1 = new Button();
			ConversionErrors_Value_textBox = new TextBox();
			CE_Res_tb = new TextBox();
			SuspendLayout();
			// 
			// ConversionErrors_button1
			// 
			ConversionErrors_button1.Location = new Point(101, 12);
			ConversionErrors_button1.Name = "ConversionErrors_button1";
			ConversionErrors_button1.Size = new Size(120, 23);
			ConversionErrors_button1.TabIndex = 0;
			ConversionErrors_button1.Text = "ConversionErrors";
			ConversionErrors_button1.UseVisualStyleBackColor = true;
			ConversionErrors_button1.Click += ConversionErrors_button1_Click;
			// 
			// ConversionErrors_Value_textBox
			// 
			ConversionErrors_Value_textBox.Location = new Point(12, 12);
			ConversionErrors_Value_textBox.Name = "ConversionErrors_Value_textBox";
			ConversionErrors_Value_textBox.Size = new Size(83, 23);
			ConversionErrors_Value_textBox.TabIndex = 1;
			ConversionErrors_Value_textBox.Text = "0,6";
			// 
			// CE_Res_tb
			// 
			CE_Res_tb.Location = new Point(275, 12);
			CE_Res_tb.Multiline = true;
			CE_Res_tb.Name = "CE_Res_tb";
			CE_Res_tb.Size = new Size(513, 308);
			CE_Res_tb.TabIndex = 2;
			CE_Res_tb.Text = "RES";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(CE_Res_tb);
			Controls.Add(ConversionErrors_Value_textBox);
			Controls.Add(ConversionErrors_button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ConversionErrors_button1;
		private TextBox ConversionErrors_Value_textBox;
		private TextBox CE_Res_tb;
	}
}
