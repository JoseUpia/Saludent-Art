using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Saludent_Art.Modelos;

namespace Saludent_Art.Controladores
{
    public class ConsultaController
    {
        ConsultaModelo consultaModelo = new ConsultaModelo();
        DataTable consultaSelecionada = new DataTable();

        public DataTable MostrarConsultas()
        {
            DataTable tabla = new DataTable();
            tabla = consultaModelo.MostrarConsultas();

            return tabla;
        }

        public void AgregarConsulta(string IdPaciente, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            consultaModelo.AgregarConsulta(Convert.ToInt32(IdPaciente), p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 ,p11, p12, p13, p14);
        }
        public void ActualizarConsulta(string IdDatos, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            consultaModelo.ActualizarConsulta(Convert.ToInt16(IdDatos), p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }
        public void EliminarConsulta(string IdDatos)
        {
            consultaModelo.EliminarConsulta(Convert.ToInt16(IdDatos));
        }

        public string[] Respuestas(bool[] CamposSelecionados)
        {
            string[] Datos = new string[13];
            int j=0;

            for(int i = 0; i < 27; i+=2)
            {
                //MessageBox.Show(""+j);
                if (CamposSelecionados[i])
                {
                    if (j < 13)
                    {
                        Datos[j] = "Si";
                    }
                }
                else if (CamposSelecionados[i+1])
                {
                    if (j < 13)
                    {
                        Datos[j] = "No";
                    }
                }
                else
                {
                    if(j < 13)
                    {
                        Datos[j] = "";
                    }
                    
                }

                j++;
            }


            return Datos;
        }

        public DataTable Filtrar(string buscar)
        {
            consultaSelecionada = consultaModelo.Filtrar(buscar);

            return consultaSelecionada;
        }


    }
}
