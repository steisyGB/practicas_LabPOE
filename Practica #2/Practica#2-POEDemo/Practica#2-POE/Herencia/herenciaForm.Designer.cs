namespace Practica_2_POE.Herencia
{
	partial class herenciaForm
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
			label2 = new Label();
			EdadTextBox = new TextBox();
			NombreTextBox = new TextBox();
			comerButton = new Button();
			LadrarButton = new Button();
			CrearButton = new Button();
			ColorTextBox = new TextBox();
			label3 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 32);
			label1.Name = "label1";
			label1.Size = new Size(104, 15);
			label1.TabIndex = 0;
			label1.Text = "Nombre del Perro:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(30, 63);
			label2.Name = "label2";
			label2.Size = new Size(86, 15);
			label2.TabIndex = 1;
			label2.Text = "Edad del Perro:";
			// 
			// EdadTextBox
			// 
			EdadTextBox.Location = new Point(170, 60);
			EdadTextBox.Name = "EdadTextBox";
			EdadTextBox.Size = new Size(134, 23);
			EdadTextBox.TabIndex = 2;
			// 
			// NombreTextBox
			// 
			NombreTextBox.Location = new Point(170, 29);
			NombreTextBox.Name = "NombreTextBox";
			NombreTextBox.Size = new Size(134, 23);
			NombreTextBox.TabIndex = 3;
			// 
			// comerButton
			// 
			comerButton.Enabled = false;
			comerButton.Location = new Point(79, 215);
			comerButton.Name = "comerButton";
			comerButton.Size = new Size(75, 23);
			comerButton.TabIndex = 4;
			comerButton.Text = "Comer";
			comerButton.UseVisualStyleBackColor = true;
			comerButton.Click += comerButton_Click;
			// 
			// LadrarButton
			// 
			LadrarButton.Enabled = false;
			LadrarButton.Location = new Point(194, 215);
			LadrarButton.Name = "LadrarButton";
			LadrarButton.Size = new Size(75, 23);
			LadrarButton.TabIndex = 5;
			LadrarButton.Text = "Ladrar";
			LadrarButton.UseVisualStyleBackColor = true;
			LadrarButton.Click += LadrarButton_Click;
			// 
			// CrearButton
			// 
			CrearButton.Location = new Point(136, 170);
			CrearButton.Name = "CrearButton";
			CrearButton.Size = new Size(75, 23);
			CrearButton.TabIndex = 6;
			CrearButton.Text = "Crear Perro";
			CrearButton.UseVisualStyleBackColor = true;
			CrearButton.Click += CrearButton_Click;
			// 
			// ColorTextBox
			// 
			ColorTextBox.Location = new Point(170, 92);
			ColorTextBox.Name = "ColorTextBox";
			ColorTextBox.Size = new Size(134, 23);
			ColorTextBox.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(30, 95);
			label3.Name = "label3";
			label3.Size = new Size(89, 15);
			label3.TabIndex = 7;
			label3.Text = "Color del Perro:";
			// 
			// herenciaForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(352, 254);
			Controls.Add(ColorTextBox);
			Controls.Add(label3);
			Controls.Add(CrearButton);
			Controls.Add(LadrarButton);
			Controls.Add(comerButton);
			Controls.Add(NombreTextBox);
			Controls.Add(EdadTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "herenciaForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Mascota";
			Load += herenciaForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox EdadTextBox;
		private TextBox NombreTextBox;
		private Button comerButton;
		private Button LadrarButton;
		private Button CrearButton;
		private TextBox ColorTextBox;
		private Label label3;
	}
}