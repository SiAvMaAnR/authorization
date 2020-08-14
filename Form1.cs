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
		public Form1()
		{
			InitializeComponent();
		}


		//Поля авторизации
		private string _Username;//Имя пользователя
		private string _E_mail;//Почтовый адрес
		private string _Password;//Пароль


		//Всплывающие подсказки
		private void Form1_Load(object sender, EventArgs e)
		{
			//Активировать фокус на label1
			ActiveControl = label1;
			//Подсказки при наведении на иконки полей ввода данных
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(Username_pictureBox, "Имя пользователя");
			toolTip.SetToolTip(Password_pictureBox, "Пароль");
			toolTip.SetToolTip(Email_pictureBox, "Адрес Электронной почты");
		}


		//Вывод информации при нажатии на иконку
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
			//Активировать фокус на label1
			ActiveControl = label1;
			//Возврат предустановок при пустых полях данных
			ReturnDefaultTextBox();
			//Движение формы за панель
			panelForm.Capture = false;
			Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
			WndProc(ref m);
		}


		//Выход при нажатии на иконку "крест"
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Close();
		}


		//Запись действий с клавиатуры
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape: Close(); break;//Выход на "Escape"
				case Keys.Enter: buttonSign_In_Click(buttonSign_In, null); break;//Вход на "Enter"
			}
		}


		//Возврат стандартных параметров полей авторизации
		private void ReturnDefaultTextBox()
		{
			//Имя пользователя
			if (userTextBox.Text == "")
			{
				Username_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_user_male3_172627.png");
				userTextBox.ForeColor = SystemColors.InactiveBorder;
				userTextBox.Text = "Username";
			}
			//Почтовый адрес
			if (emailTextBox.Text == "")
			{
				Email_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_ic_email_48px_3669350.png");
				emailTextBox.ForeColor = SystemColors.InactiveBorder;
				emailTextBox.Text = "E-mail";
			}
			//Пароль
			if (passwordTextBox.Text=="")
			{
				Password_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_unlocked_4918947.png");
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
				Username_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_user_male3_172627_1.png");
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
				Email_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_ic_email_48px_3669350_1.png");
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
				Password_pictureBox.Image = Image.FromFile(@"D:\source\repos\authorization\Images\iconfinder_unlocked_4918947_1.png");
				passwordTextBox.UseSystemPasswordChar = true;
				passwordTextBox.ForeColor = Color.FromArgb(78, 184, 206);
			}
		}
		private void passwordTextBox_Enter(object sender, EventArgs e)
		{
			passwordTextBox_Click(sender, e);
		}
		//==================================================================================


		private void passwordTextBox_Leave(object sender, EventArgs e)
		{
			if (buttonSign_In.Focus())
			{
				ReturnDefaultTextBox();
			}
		}


		//Клик на кнопку авторизации
		private void buttonSign_In_Click(object sender, EventArgs e)
		{
			ReturnDefaultTextBox();
			_Username = userTextBox.Text;
			_E_mail = emailTextBox.Text;
			_Password = passwordTextBox.Text;

			Sign_In anketa = new Sign_In(_Username, _E_mail, _Password);
		}


		//Клик на кнопку регистрации
		private void buttonRegister_Click(object sender, EventArgs e)
		{
			ReturnDefaultTextBox();
			MessageBox.Show("регистрация");
		}
	}
}
