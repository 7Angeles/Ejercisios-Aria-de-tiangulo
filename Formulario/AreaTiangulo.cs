using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercisios.Formulario
{
    public partial class AreaTiangulo : Form
    {
        public AreaTiangulo()
        {
            InitializeComponent();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            try { 
            float Base = float.Parse(textoBase.Text);
            float Altura = float.Parse(textoAltura.Text);

            if(Base>= 0 && Altura>= 0)
            {
                float resultado = (Base * Altura) / 2;

                textoResultado.Text = "" + resultado;
            }else
            {
                MessageBox.Show(this, "datos incorectos", "Error");
            }
            }catch(Exception ex)
            {
                MessageBox.Show(this, "Datos no numericos", "Datos incorectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            






    }
    }
}
