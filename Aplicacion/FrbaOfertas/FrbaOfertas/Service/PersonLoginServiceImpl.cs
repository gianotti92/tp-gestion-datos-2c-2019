using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service

{
    public class PersonLoginServiceImpl : PersonLoginService
    {
        private LoginService loginService;
        private RolService rolService;
        public PersonLoginServiceImpl(LoginService loginService, RolService rolService)
        {
            this.loginService = loginService;
            this.rolService = rolService;
        }

        public void loginUser(PersonLogin personLogin)
        {
            loginService.validateLoginUser(personLogin);
            rolService.getRolType(personLogin);
        }
    }
}
