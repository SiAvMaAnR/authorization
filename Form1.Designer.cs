namespace authorization
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.buttonSign_In = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(166, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// userTextBox
			// 
			this.userTextBox.AcceptsReturn = true;
			this.userTextBox.AllowDrop = true;
			this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.userTextBox.HideSelection = false;
			this.userTextBox.Location = new System.Drawing.Point(91, 169);
			this.userTextBox.Name = "userTextBox";
			this.userTextBox.Size = new System.Drawing.Size(284, 23);
			this.userTextBox.TabIndex = 2;
			this.userTextBox.TabStop = false;
			this.userTextBox.Text = "Username";
			this.userTextBox.Click += new System.EventHandler(this.userTextBox_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(41, 198);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 1);
			this.panel1.TabIndex = 8;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(40, 157);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 35);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(41, 243);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(322, 1);
			this.panel2.TabIndex = 11;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(40, 206);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(35, 35);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.emailTextBox.HideSelection = false;
			this.emailTextBox.Location = new System.Drawing.Point(91, 214);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(284, 23);
			this.emailTextBox.TabIndex = 9;
			this.emailTextBox.TabStop = false;
			this.emailTextBox.Text = "E-mail";
			this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(40, 291);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(323, 1);
			this.panel3.TabIndex = 14;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(40, 250);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 35);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.passwordTextBox.HideSelection = false;
			this.passwordTextBox.Location = new System.Drawing.Point(91, 258);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(284, 23);
			this.passwordTextBox.TabIndex = 12;
			this.passwordTextBox.TabStop = false;
			this.passwordTextBox.Text = "Password";
			this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
			// 
			// buttonSign_In
			// 
			this.buttonSign_In.BackColor = System.Drawing.Color.Aqua;
			this.buttonSign_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSign_In.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSign_In.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSign_In.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.buttonSign_In.Location = new System.Drawing.Point(91, 314);
			this.buttonSign_In.Name = "buttonSign_In";
			this.buttonSign_In.Size = new System.Drawing.Size(216, 50);
			this.buttonSign_In.TabIndex = 15;
			this.buttonSign_In.Text = "Sign In";
			this.buttonSign_In.UseVisualStyleBackColor = false;
			this.buttonSign_In.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(354, 12);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(30, 27);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 16;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.Aqua;
			this.button2.Location = new System.Drawing.Point(91, 370);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(216, 50);
			this.button2.TabIndex = 17;
			this.button2.Text = "Register";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(396, 512);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.buttonSign_In);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.userTextBox);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox userTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button buttonSign_In;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button2;
	}
}

