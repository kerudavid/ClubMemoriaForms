using ClubMemoriaForms.Data;
using ClubMemoriaForms.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemoriaForms.BusinessBO
{
    /// <summary>
    /// Clase para gestionar la tabla Asistencia
    /// </summary>
    public class AsistenciaBO
    {
        //recuperar información de asistencia por periodo de fechas
        public List<AsistenciaModel> ConsultarPeriodoAsis(string Pdesde, string Phasta)
        {
            DateTime fechadesde = DateTime.Now;
            if (string.IsNullOrEmpty(Pdesde))
            //cuando no viene una fecha desde, toma la fecha de hoy menos 30 días
            {
                fechadesde = fechadesde.AddDays(-30);
                Pdesde = fechadesde.ToString("dd/MM/yyyy");
            }
            // else
            // {
            // DateTime fechadesde = DateTime.ParseExact(Pdesde, "dd-MM-yyyy", null);
            // }
            
            //podria usar fechadesde
            string query = $"SELECT * FROM Asistencia WHERE CONVERT(date,fecha,103) >= '{Pdesde}'";           
            List<AsistenciaModel> asistenciaModelList = new List<AsistenciaModel>();
            //Las consultas siempre retornan el obtejo dentro de una lista.
            asistenciaModelList = this.ObtenerListaSQL<AsistenciaModel>(query).ToList();
            return asistenciaModelList;
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel(Modelo genérico)
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
