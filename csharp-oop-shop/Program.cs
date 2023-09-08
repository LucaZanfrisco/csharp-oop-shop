// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;
// MAIN 
{
    Prodotto prodotto1 = new Prodotto("Margherita", "Magnifico bouquet di margherite bianche", 22.0f, 24);

    prodotto1.StampaProdotto();

    //int codice = prodotto1.GetCodice();
    //Console.WriteLine($"Codice prodotto: {codice}");

    //string nomeEsteso = prodotto1.GetNomeEsteso();
    //Console.WriteLine($"Nome esteso del prodotto: {nomeEsteso}");

    //string nome = prodotto1.GetNome();
    //Console.WriteLine($"Nome: {nome}");

    //string descrizione = prodotto1.GetDescrizione();
    //Console.WriteLine($"Descrizione: {descrizione}");

    //float prezzo = prodotto1.GetPrezzo();
    //Console.WriteLine($"Prezzo pre-iva: {prezzo} euro");

    //float prezzoIva = prodotto1.GetPrezzoIva();
    //Console.WriteLine($"Prezzo {prezzoIva} euro");

    //string codicePadLeft = prodotto1.GetCodicePadLeft();
    //Console.WriteLine($"Codice con il pad left: {codicePadLeft}");
}

{
    Console.WriteLine("\nInserire nella lista 5 prodotti");
    Console.WriteLine("---------------------------");

    Prodotto[] listaProdotti = new Prodotto[5];

    for (int i = 0; i < listaProdotti.Length; i++)
    {
        Console.WriteLine($"Prodotto {i + 1}");

        Console.Write("Inserire il nome: ");
        string nome = Console.ReadLine();

        Console.Write("Inserire la descrizione: ");
        string descrizione = Console.ReadLine();

        Console.Write("Inserire il prezzo: ");
        float prezzo = float.Parse( Console.ReadLine() );

        Console.Write("Inserire iva: ");
        int iva = int.Parse( Console.ReadLine() );

        listaProdotti[i] = new Prodotto(nome, descrizione, prezzo, iva);

        Console.WriteLine(i < listaProdotti.Length - 1 ? "--------------------------" : "");
    }


    for (int i = 0;i < listaProdotti.Length;i++)
    {
        listaProdotti[i].StampaProdotto();
    }


}
