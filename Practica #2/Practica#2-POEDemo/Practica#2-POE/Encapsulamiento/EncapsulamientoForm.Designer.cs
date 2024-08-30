namespace Practica_2_POE.Encapsulamiento
{
	partial class EncapsulamientoForm
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
			label1 = new Label();
			MontoTextBox = new TextBox();
			DepositarButton = new Button();
			RetirarButton = new Button();
			SaldoButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(76, 26);
			label1.Name = "label1";
			label1.Size = new Size(204, 15);
			label1.TabIndex = 0;
			label1.Text = "Ingrese el monto a depositar o retirar:";
			// 
			// MontoTextBox
			// 
			MontoTextBox.Location = new Point(122, 62);
			MontoTextBox.Name = "MontoTextBox";
			MontoTextBox.Size = new Size(100, 23);
			MontoTextBox.TabIndex = 1;
			// 
			// DepositarButton
			// 
			DepositarButton.Location = new Point(23, 113);
			DepositarButton.Name = "DepositarButton";
			DepositarButton.Size = new Size(75, 23);
			DepositarButton.TabIndex = 2;
			DepositarButton.Text = "Depositar";
			DepositarButton.UseVisualStyleBackColor = true;
			DepositarButton.Click += DepositarButton_Click;
			// 
			// RetirarButton
			// 
			RetirarButton.Location = new Point(132, 113);
			RetirarButton.Name = "RetirarButton";
			RetirarButton.Size = new Size(75, 23);
			RetirarButton.TabIndex = 3;
			RetirarButton.Text = "Retirar";
			RetirarButton.UseVisualStyleBackColor = true;
			RetirarButton.Click += RetirarButton_Click;
			// 
			// SaldoButton
			// 
			SaldoButton.Location = new Point(236, 113);
			SaldoButton.Name = "SaldoButton";
			SaldoButton.Size = new Size(75, 23);
			SaldoButton.TabIndex = 4;
			SaldoButton.Text = "Saldo";
			SaldoButton.UseVisualStyleBackColor = true;
			SaldoButton.Click += SaldoButton_Click;
			// 
			// EncapsulamientoForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(338, 150);
			Controls.Add(SaldoButton);
			Controls.Add(RetirarButton);
			Controls.Add(DepositarButton);
			Controls.Add(MontoTextBox);
			Controls.Add(label1);
			Name = "EncapsulamientoForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EncapsulamientoForm";
			Load += EncapsulamientoForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox MontoTextBox;
		private Button DepositarButton;
		private Button RetirarButton;
		private Button SaldoButton;
	}
}