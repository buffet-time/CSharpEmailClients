namespace WindowsFormEmailClient
{
	partial class EmailClient
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(343, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "To";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(33, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(343, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "From";
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(33, 76);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(343, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "From Password";
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(33, 154);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(343, 53);
			this.textBox4.TabIndex = 5;
			this.textBox4.Text = "Subject";
			this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(33, 213);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(343, 222);
			this.textBox5.TabIndex = 6;
			this.textBox5.Tag = "asdfasdf";
			this.textBox5.Text = "Body";
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(170, 456);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Send Email";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(33, 102);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(343, 20);
			this.textBox6.TabIndex = 3;
			this.textBox6.Text = "SMTP Domain";
			this.textBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(33, 128);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(343, 20);
			this.textBox7.TabIndex = 4;
			this.textBox7.Text = "Port #";
			this.textBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
			// 
			// EmailClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 491);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "EmailClient";
			this.Text = "Email Client";
			this.Load += new System.EventHandler(this.EmailClient_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
	}
}