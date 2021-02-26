using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafencio
{
    public class Vertice : IComparable
    {
        private string nombre;
        private Dictionary<Vertice, int> listuki;

        public Vertice(string nombre)
        {
            this.nombre = nombre;
            listuki = new Dictionary<Vertice, int>();
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Dictionary<Vertice, int>Listuki{
            get { return listuki; }
        }
        public void AgregarArco(Vertice destino, int peso)
        {
           
           
                listuki.Add(destino, peso);
            
        }

        public override string ToString()
        {
            string aux = "";
            if (listuki.Count==0)
            {
                aux +=nombre+ " Sin nodos hijos";
            }
            else
            {
                foreach(var element in listuki)
                {
                    aux += nombre+ " -->" + element.Key.nombre + "(" + element.Value + ")\n";
                }
            }
            return aux;
        }
        public Vertice[] obtenerHijos()
        {
            Vertice[] aux = new Vertice[listuki.Count];
            int i = 0;
            foreach (var element in listuki)
            {
                aux[i] = element.Key;
                i++;
            }

            return aux;
        }

        public int getPositionOf(string nombre)
        {
            int i = 0;
            foreach(var v in listuki)
            {
                if (v.Key.nombre.Equals(nombre))
                {
                    return i;
                }
                i++;
            }
            throw new Exception("El elemento no existe");
        }
        public KeyValuePair<Vertice, int>[] obtenerArray()
        {
            return listuki.ToArray();
        }
        public override bool Equals(object obj)
        {
            var x = (Vertice)obj;

            return x.nombre.Equals(nombre);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Vertice x = (Vertice)obj;
            if (this.Nombre.Equals(x.nombre)) return 1;
            return 0;
        }
    }
}
