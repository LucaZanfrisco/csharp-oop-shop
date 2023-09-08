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
        // ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private int iva;

        //COSTRUTTORI
        public Prodotto(string nome, string descrizione, float prezzo, int iva)
        {
            SetCodice();
            SetNome(nome);
            SetDescrizione(descrizione);
            SetPrezzo(prezzo);
            SetIva(iva);
        }

        // SETTERS
        private void SetCodice()
        {
            Random random = new Random();
            this.codice = random.Next(1, 99999999);
        }

        public void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(float prezzo)
        {
            if (prezzo > 0)
                this.prezzo = prezzo;
            else
                this.prezzo = 0;
        }

        public void SetIva(int iva)
        {
            if(iva > 0)
                this.iva = iva;
            else
                this.iva = 0;
        }

        // GETTERS
        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public float GetPrezzo()
        {
            return this.prezzo;
        }

        public int GetIva() 
        {
            return this.iva;
        }

        public float GetPrezzoIva()
        {
            return MathF.Round(this.prezzo *(1 + ((float)iva / 100)) ,2);
        }

        public string GetNomeEsteso()
        {
            return $"{codice}{nome}";
        }
        
        public string GetCodicePadLeft()
        {
            string codicePaddato = this.codice.ToString().PadLeft(8,'0');
            return codicePaddato;
        }

    }
}
