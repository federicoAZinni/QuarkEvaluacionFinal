using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
    class Camisa:Prenda
    {
        public Manga manga;
        public Cuello cuello;
    }

    public enum Manga { mangaCorta, mangaLarga }
    public enum Cuello { cuelloMao, cuelloComun }
}
