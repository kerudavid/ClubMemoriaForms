using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemoriaForms.Models
{
    public class LoginModel
    {
        public string UserName { get; set; } 
        public string Password { get; set; }

        public string Validate(LoginModel loginModel)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(loginModel.UserName) || string.IsNullOrEmpty(loginModel.Password))
            {
                return "Por favor, debe ingresar usuario y contraseña";
            }


            return message;
        }
    }
}
