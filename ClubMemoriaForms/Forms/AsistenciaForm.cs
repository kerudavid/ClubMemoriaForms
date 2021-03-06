using ClubMemoriaForms.Models;
using ClubMemoriaForms.BusinessBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMemoriaForms.Forms
{
    public partial class AsistenciaForm : Form
    {
        public string fechaini;
        public string fechafin;

        public AsistenciaForm()
        {
            InitializeComponent();
        }

        //llena los datos de la lista en el datagridview
        private void AsistenciaForm_Load(object sender, EventArgs e)
        {
            AsistenciaBO asistenciaBO = new AsistenciaBO();
            List<AsistenciaModel> asistenciaList = asistenciaBO.ConsultarPeriodoAsis(this.fechaini, this.fechafin);

            if (asistenciaList.Count > 0)
            {
                foreach (var asistencia in asistenciaList)
                {
                    grdAsistencia.Rows.Add(asistencia.Id_asistencia, asistencia.Fk_id_cliente, asistencia.Fecha, asistencia.Hora, asistencia.Observacion, asistencia.Sucursal, asistencia.Usuario, asistencia.Fecha_mod);
                }
            }
        }
    }
}
