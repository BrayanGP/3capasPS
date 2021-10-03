using GarPer._3CapasAzure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarPer._3CapasAzure.Negocio
{
    public class AyudaNegocio
    {

        public List<pruebas_Result> pruebasNegocio(string opcion, string nombre, string apellido, int edad)
        {
            return new GarPer._3CapasAzure.Datos.AyudaDatos().pruebas(opcion, nombre, apellido, edad).ToList();
        }
    }
}
