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
    public partial class Home : Form
    {
        public Home()
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
