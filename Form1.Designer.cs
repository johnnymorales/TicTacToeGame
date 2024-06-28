namespace Tic_Tac_Toe_Game
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			button8 = new Button();
			button9 = new Button();
			button10 = new Button();
			CPUTimer = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.RoyalBlue;
			label1.Location = new Point(25, 27);
			label1.Name = "label1";
			label1.Size = new Size(171, 38);
			label1.TabIndex = 0;
			label1.Text = "Player Wins:";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.IndianRed;
			label2.Location = new Point(672, 27);
			label2.Name = "label2";
			label2.Size = new Size(147, 38);
			label2.TabIndex = 1;
			label2.Text = "CPU Wins:";
			label2.Click += label2_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Control;
			button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.Location = new Point(96, 117);
			button1.Name = "button1";
			button1.Size = new Size(190, 177);
			button1.TabIndex = 2;
			button1.UseVisualStyleBackColor = false;
			button1.Click += PlayerClickButton;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Control;
			button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.Location = new Point(337, 117);
			button2.Name = "button2";
			button2.Size = new Size(190, 177);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = false;
			button2.Click += PlayerClickButton;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.Control;
			button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button3.Location = new Point(574, 117);
			button3.Name = "button3";
			button3.Size = new Size(190, 177);
			button3.TabIndex = 4;
			button3.UseVisualStyleBackColor = false;
			button3.Click += PlayerClickButton;
			// 
			// button4
			// 
			button4.BackColor = SystemColors.Control;
			button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button4.Location = new Point(96, 314);
			button4.Name = "button4";
			button4.Size = new Size(190, 177);
			button4.TabIndex = 7;
			button4.UseVisualStyleBackColor = false;
			button4.Click += PlayerClickButton;
			// 
			// button5
			// 
			button5.BackColor = SystemColors.Control;
			button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button5.Location = new Point(337, 314);
			button5.Name = "button5";
			button5.Size = new Size(190, 177);
			button5.TabIndex = 6;
			button5.UseVisualStyleBackColor = false;
			button5.Click += PlayerClickButton;
			// 
			// button6
			// 
			button6.BackColor = SystemColors.Control;
			button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button6.Location = new Point(574, 314);
			button6.Name = "button6";
			button6.Size = new Size(190, 177);
			button6.TabIndex = 5;
			button6.UseVisualStyleBackColor = false;
			button6.Click += PlayerClickButton;
			// 
			// button7
			// 
			button7.BackColor = SystemColors.Control;
			button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button7.Location = new Point(96, 513);
			button7.Name = "button7";
			button7.Size = new Size(190, 177);
			button7.TabIndex = 10;
			button7.UseVisualStyleBackColor = false;
			button7.Click += PlayerClickButton;
			// 
			// button8
			// 
			button8.BackColor = SystemColors.Control;
			button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button8.Location = new Point(337, 513);
			button8.Name = "button8";
			button8.Size = new Size(190, 177);
			button8.TabIndex = 9;
			button8.UseVisualStyleBackColor = false;
			button8.Click += PlayerClickButton;
			// 
			// button9
			// 
			button9.BackColor = SystemColors.Control;
			button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button9.Location = new Point(574, 513);
			button9.Name = "button9";
			button9.Size = new Size(194, 177);
			button9.TabIndex = 8;
			button9.UseVisualStyleBackColor = false;
			button9.Click += PlayerClickButton;
			// 
			// button10
			// 
			button10.BackColor = Color.OliveDrab;
			button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button10.ForeColor = Color.Transparent;
			button10.Location = new Point(303, 732);
			button10.Name = "button10";
			button10.Size = new Size(250, 80);
			button10.TabIndex = 11;
			button10.Text = "Restart Game";
			button10.UseVisualStyleBackColor = false;
			button10.Click += RestartGame;
			// 
			// CPUTimer
			// 
			CPUTimer.Interval = 1000;
			CPUTimer.Tick += CPUmove;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(878, 844);
			Controls.Add(button10);
			Controls.Add(button7);
			Controls.Add(button8);
			Controls.Add(button9);
			Controls.Add(button4);
			Controls.Add(button5);
			Controls.Add(button6);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Tic Tac Toe Game (WinForms)";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
		private Button button10;
		private System.Windows.Forms.Timer CPUTimer;
	}
}
