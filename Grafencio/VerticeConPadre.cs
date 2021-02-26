using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafencio
{
    class VerticeConPadre
    {
        Vertice papa;
        Vertice hijo;
        
        public VerticeConPadre(Vertice papa, Vertice hijo)
        {
            this.papa = papa;
            this.hijo = hijo;
        }
        public VerticeConPadre(Vertice hijo)
        {
            
            this.hijo = hijo;
        }

        public Vertice Papa {
            get { return papa; }
            set { papa = value; }
        }

        public Vertice Hijo{
            get{ return hijo;}
            set { hijo = value; }
            }

        public override string ToString()
        {
            if (papa == null)
            {
                return hijo.Nombre;
            }
            return papa.Nombre + " <- " + hijo.Nombre ;
        }
    }
}
