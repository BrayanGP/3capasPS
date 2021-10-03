using GarPer._3CapasAzure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarPer._3CapasAzure.Datos
{
    public class AyudaDatos
    {
        pruebaExamenEntities prueba = new pruebaExamenEntities();
        public List<pruebas_Result> pruebas(string opcion,string nombre,string apellido,int edad)
        { 
            return prueba.pruebas(opcion, nombre, apellido, edad).ToList();
        }
    }
}
