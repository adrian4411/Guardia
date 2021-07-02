using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class valores
    {
        public string DevolverString() { return "Devolucion string "; }
        public List<string> DevolverListaString() { List<string> lista = new List<string>();
            lista.Add("valor 1");
            lista.Add("valor 2");
            lista.Add("valor 3");
            lista.Add("valor 4");
            lista.Add("valor 5");
            return lista;
        }
        public Objeto1 DevolverObjeto()
        {
            Objeto1 obj = new Objeto1(1, "nombre 11", "datos varios");
            return obj;
        }


    }
}
