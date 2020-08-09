using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
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
			if (passwordTextBox.Text == "")
			{
				passwordTextBox.ForeColor = SystemColors.InactiveBorder;
				passwordTextBox.UseSystemPasswordChar = false;
				passwordTextBox.Text="Password";
			}
		}


		//Работа с полем "Имя пользователя"
		private void userTextBox_Click(object sender, EventArgs e)//Username
		{
			ReturnDefaultTextBox();
			if (userTextBox.Text == "Username")
			{
				userTextBox.Clear();
				userTextBox.ForeColor = Color.FromArgb(78, 184, 206);
			}
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


		//Выход при нажатии на крест
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Close();
		}


		//Всплывающие подсказки
		private void Form1_Load(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(Username_pictureBox, "Имя пользователя");
			toolTip.SetToolTip(Password_pictureBox, "Пароль");
			toolTip.SetToolTip(Email_pictureBox, "Адрес Электронной почты");
		}


		//==================================================================================  Вход
		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
