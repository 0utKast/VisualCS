using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsYEstructs
{
    class Fecha
    {
        private int an;
        private Mes mes;
        private int dia;

        public Fecha(int ssaa, Mes mm, int dd)
        {
            this.an = ssaa - 2000;
            this.mes = mm;
            this.dia = dd - 1;
        }
        public override string ToString()
        {
            string fecha = String.Format("{0} {1} {2}", this.dia + 1, this.mes, this.an + 2000);
            return fecha;
        }

        public void AvanzaMes()
        {
            this.mes++;
            if (this.mes == Mes.Diciembre + 1)
            {
                this.mes = Mes.Enero;
                this.an++;
            }
        }
    }
}
