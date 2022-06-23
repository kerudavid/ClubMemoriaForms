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
    public class ClientePruebaBO
    {
        /// <summary>
        /// Método para obtener el Id del Padre
        /// </summary>
        /// <param name="registerModel">modelo que contiene los datos del usuario Padre</param>
        /// <returns>Id del Padre</returns>
        public string GetParentId()
        {
            string cedula = string.Empty;

            string query = $"SELECT cedula FROM Cliente WHERE id_cliente = '{1}'";

            List<ClienteModelPrueba> registerModelList = this.ObtenerListaSQL<ClienteModelPrueba>(query).ToList();

            if (registerModelList.Count > 0)
            {
                cedula = registerModelList.FirstOrDefault().Cedula;
            }

            return cedula;
        }
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
