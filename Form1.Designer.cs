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
			this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
			this.userTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Username_pictureBox = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Email_pictureBox = new System.Windows.Forms.PictureBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Password_pictureBox = new System.Windows.Forms.PictureBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.buttonSign_In = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.buttonRegister = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Username_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Email_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Password_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// Lock_pictureBox
			// 
			this.Lock_pictureBox.Cursor = System.Windows.Forms.Cursors.Help;
			this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
			this.Lock_pictureBox.Location = new System.Drawing.Point(166, 53);
			this.Lock_pictureBox.Name = "Lock_pictureBox";
			this.Lock_pictureBox.Size = new System.Drawing.Size(64, 64);
			this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Lock_pictureBox.TabIndex = 0;
			this.Lock_pictureBox.TabStop = false;
			this.Lock_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
			// Username_pictureBox
			// 
			this.Username_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Username_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Username_pictureBox.Image")));
			this.Username_pictureBox.Location = new System.Drawing.Point(40, 157);
			this.Username_pictureBox.Name = "Username_pictureBox";
			this.Username_pictureBox.Size = new System.Drawing.Size(35, 35);
			this.Username_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Username_pictureBox.TabIndex = 5;
			this.Username_pictureBox.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(41, 243);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(322, 1);
			this.panel2.TabIndex = 11;
			// 
			// Email_pictureBox
			// 
			this.Email_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Email_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Email_pictureBox.Image")));
			this.Email_pictureBox.Location = new System.Drawing.Point(40, 206);
			this.Email_pictureBox.Name = "Email_pictureBox";
			this.Email_pictureBox.Size = new System.Drawing.Size(35, 35);
			this.Email_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Email_pictureBox.TabIndex = 10;
			this.Email_pictureBox.TabStop = false;
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
			// Password_pictureBox
			// 
			this.Password_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Password_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Password_pictureBox.Image")));
			this.Password_pictureBox.Location = new System.Drawing.Point(40, 250);
			this.Password_pictureBox.Name = "Password_pictureBox";
			this.Password_pictureBox.Size = new System.Drawing.Size(35, 35);
			this.Password_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Password_pictureBox.TabIndex = 13;
			this.Password_pictureBox.TabStop = false;
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
			// buttonRegister
			// 
			this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRegister.ForeColor = System.Drawing.Color.Aqua;
			this.buttonRegister.Location = new System.Drawing.Point(91, 370);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(216, 50);
			this.buttonRegister.TabIndex = 17;
			this.buttonRegister.Text = "Register";
			this.buttonRegister.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(396, 477);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.buttonSign_In);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.Password_pictureBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Email_pictureBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Username_pictureBox);
			this.Controls.Add(this.userTextBox);
			this.Controls.Add(this.Lock_pictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Username_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Email_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Password_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Lock_pictureBox;
		private System.Windows.Forms.TextBox userTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox Username_pictureBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox Email_pictureBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox Password_pictureBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button buttonSign_In;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button buttonRegister;
	}
}

