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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadInformation();
        }
        public void loadInformation()
        {
            label1.Text= VariablesGlobales.usuario.ToString();
        }
    }
}
