using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Repository;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Service
{
    class LoginServiceImpl : LoginService
    {
        private LoginRepository loginRepository;
        
        public LoginServiceImpl(LoginRepository _loginRepository)
        {
            this.loginRepository = _loginRepository;
        }

        public Boolean validateLoginUser(PersonLogin personLogin)
        {
            return loginRepository.validateLoginUser(personLogin);
        }
    }
}
