using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private int iva;

        public Prodotto(string nome, string descrizione, float prezzo, int iva)
        {
            SetCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public void SetCodice()
        {
            Random random = new Random();
            this.codice = random.Next(1, 99999999);
        }

    }
}
