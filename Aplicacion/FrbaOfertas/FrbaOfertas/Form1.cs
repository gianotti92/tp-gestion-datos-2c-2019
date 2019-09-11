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
    public partial class Form1 : Form
    {
        private LoginService loginService;

        public Form1(LoginService _loginService)
        {
            this.loginService = _loginService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           //TODO: obtener los valores de los input, no tengo idea de como se hace
            //Discutir uso de dtos (probablemente sea al pepe)
            PersonLogin personLogin = new PersonLogin();
            personLogin.Usuario = "saraza";
            personLogin.Contrasena = "saraza";
            Boolean validLogin = loginService.validateLoginUser(personLogin);
        }
    }
}
