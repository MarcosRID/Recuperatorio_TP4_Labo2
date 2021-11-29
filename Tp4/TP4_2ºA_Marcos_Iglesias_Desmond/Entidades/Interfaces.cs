using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public interface IProductosCongelados 
    {

        public ECarnes ParceCarne(string stg);
        public ELacteos ParceLacteo(string stg);

    }

    public interface IProductosNoCongelados
    { 
        public EFrutas ParceFrutas(string stg);
        public EVerduras ParceVerduras (string stg);
        public EHigiene ParceHigiene(string stg);
        public ELimpieza ParceLimpieza(string stg);
        public EGolocinas ParceGolocinas(string stg);
        public EOtros ParceOtros(string stg);
    }


}
