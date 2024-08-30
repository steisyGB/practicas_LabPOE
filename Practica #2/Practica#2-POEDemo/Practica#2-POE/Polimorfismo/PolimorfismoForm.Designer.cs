namespace Practica_2_POE.Polimorfismo
{
	partial class PolimorfismoForm
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
			EncenderButton = new Button();
			SuspendLayout();
			// 
			// EncenderButton
			// 
			EncenderButton.Location = new Point(72, 58);
			EncenderButton.Name = "EncenderButton";
			EncenderButton.Size = new Size(172, 75);
			EncenderButton.TabIndex = 0;
			EncenderButton.Text = "Encender computadoras";
			EncenderButton.UseVisualStyleBackColor = true;
			EncenderButton.Click += EncenderButton_Click;
			// 
			// PolimorfismoForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 198);
			Controls.Add(EncenderButton);
			Name = "PolimorfismoForm";
			Text = "PolimorfismoForm";
			ResumeLayout(false);
		}

		#endregion

		private Button EncenderButton;
	}
}