using ClubMemoriaForms.Data;
using ClubMemoriaForms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemoriaForms.BusinessBO
{
    /// <summary>
    /// Clase que gestiona el Login de los usuarios del sistema
    /// </summary>
    public class LoginBO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsLoggedIn(LoginModel loginModel)
        {
            string query = $"SELECT * FROM Usuario WHERE usuario = '{loginModel.UserName}'"
                +$"AND clave ='{loginModel.Password}'";

            List<LoginModel> loginModelList = new List<LoginModel>();

            //Las consultas siempre retornan el obtejo dentro de una lista.
            loginModelList = this.ObtenerListaSQL<LoginModel>(query).ToList();

            //Valida que la lista contenga informacion

            //En este caso si retorna, quiere decir que si encontró al usuario y
            //puede proceder al sistema
            if (loginModelList.Count>0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel (Modelo genérico)
        /// </summary>
        /// <returns>IList<TModel></returns>
        private IList<TModel> ObtenerListaSQL<TModel>(string query)
        {
            try
            {
                DataTable dataTableInformacion = SQLConexionDataBase.Query(query);
                var listaResultante = dataTableInformacion.MapDataTableToList<TModel>();

                return listaResultante;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    
}
