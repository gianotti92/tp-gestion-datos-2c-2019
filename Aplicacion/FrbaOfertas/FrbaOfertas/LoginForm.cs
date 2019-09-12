using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Service;
using FrbaOfertas.Entities;

namespace FrbaOfertas
{
    public partial class LoginForm : Form
    {
        private PersonLoginService personLoginService;

        public LoginForm(PersonLoginService personLoginService)
        {
            this.personLoginService = personLoginService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonLogin personLogin = new PersonLogin();
            personLogin.contrasena = contrasenaTxt.Text;
            personLogin.usuario = nameTxt.Text; 
            personLoginService.loginUser(personLogin);
        }
    }
}
