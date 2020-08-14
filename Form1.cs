using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
	public partial class Form1 : Form
	{
		//private string _Username;
		//private string _E_mail;
		//private string _Password;

		public Form1()
		{
			InitializeComponent();
		}


		//Всплывающие подсказки
		private void Form1_Load(object sender, EventArgs e)
		{
			ActiveControl = label1;
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(Username_pictureBox, "Имя пользователя");
			toolTip.SetToolTip(Password_pictureBox, "Пароль");
			toolTip.SetToolTip(Email_pictureBox, "Адрес Электронной почты");
		}


		//Вывод сообщения при нажатии на иконку
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Тут будет информация о программе!",
				"Сообщение",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}


		//Движение формы авторизации
		private void panelForm_MouseDown(object sender, EventArgs e)
		{
			ActiveControl = label1;
			ReturnDefaultTextBox();

			panelForm.Capture = false;
			Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
			WndProc(ref m);
		}


		//Выход при нажатии на крест
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Close();
		}


		//Запись действий с клавиатуры
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape: Close(); break;
				case Keys.Enter: buttonSign_In_Click(buttonSign_In, null); break;
			}
		}


		//Возврат стандартных параметров полей авторизации
		private void ReturnDefaultTextBox()
		{
			if (userTextBox.Text == "")
			{
				userTextBox.ForeColor = SystemColors.InactiveBorder;
				userTextBox.Text = "Username";
			}
			if (emailTextBox.Text == "")
			{
				emailTextBox.ForeColor = SystemColors.InactiveBorder;
				emailTextBox.Text = "E-mail";
			}
			if (passwordTextBox.Text=="")
			{
				passwordTextBox.ForeColor = SystemColors.InactiveBorder;
				passwordTextBox.UseSystemPasswordChar = false;
				passwordTextBox.Text="Password";
			}
		}


		//Работа с полем "Имя пользователя"======================================================================
		private void userTextBox_Click(object sender, EventArgs e)//Username
		{
			ReturnDefaultTextBox();
			if (userTextBox.Text == "Username")
			{
				userTextBox.Clear();
				userTextBox.ForeColor = Color.FromArgb(78, 184, 206);
			}
		}
		private void userTextBox_Enter(object sender, EventArgs e)
		{
			userTextBox_Click(sender, e);
		}


		//Работа с полем "Электронная почта"
		private void emailTextBox_Click(object sender, EventArgs e)//E-mail
		{
			ReturnDefaultTextBox();
			if (emailTextBox.Text == "E-mail")
			{
				emailTextBox.Clear();
				emailTextBox.ForeColor = Color.FromArgb(78, 184, 206);
			}
		}
		private void emailTextBox_Enter(object sender, EventArgs e)
		{
			emailTextBox_Click(sender, e);
		}


		//Работа с полем "Пароль"
		private void passwordTextBox_Click(object sender, EventArgs e)//Password
		{
			ReturnDefaultTextBox();
			if (passwordTextBox.Text == "Password")
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
				passwordTextBox.ForeColor = Color.FromArgb(78, 184, 206);
			}
		}
		private void passwordTextBox_Enter(object sender, EventArgs e)
		{
			passwordTextBox_Click(sender, e);
		}


		//==================================================================================  Вход
		private void buttonSign_In_Click(object sender, EventArgs e)
		{
			ReturnDefaultTextBox();

			MessageBox.Show("авторизация");
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			ReturnDefaultTextBox();

			MessageBox.Show("регистрация");
		}


		private void passwordTextBox_Leave(object sender, EventArgs e)
		{
			if(buttonSign_In.Focus())
			{
				ReturnDefaultTextBox();
			}
		}

	}
}
