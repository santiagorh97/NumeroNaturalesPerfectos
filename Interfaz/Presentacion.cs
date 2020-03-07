using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {

            int NumeroInicial = Convert.ToInt32(TbNumeroInicial.Text);
            int NumeroFinal = Convert.ToInt32(TbNumeroFinal.Text);
            var Resultado = "Listado de números perfectos: ";

            if (NumeroInicial > NumeroFinal || NumeroInicial == 0)
            {
                TbResultado.Text = "El número inicial no puede ser mayor al final ó el número inicial no puede ser 0";
            }
            else
            {
                if (NumeroFinal < 6)
                {
                    TbResultado.Text = "No hay númeor perfecto";
                }
                else
                {
                    NumeroInicial = 6;
                    int Incrementador = 0;

                    for (int i = NumeroInicial; i <= NumeroFinal; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                Incrementador += j;
                            }
                        }

                        if (Incrementador == i)
                        {
                            Resultado += Incrementador + " ";
                        }
                        Incrementador = 0;
                    }
                    TbResultado.Text = Resultado;
                }
            }
        }
    }
}
