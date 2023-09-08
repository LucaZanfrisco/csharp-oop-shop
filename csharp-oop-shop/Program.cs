// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto("Margherita","Magnifico bouquet di margherite bianche", 22.0f, 24);

string nome = prodotto1.GetNome();
Console.WriteLine($"Nome: {nome}");

string descrizione = prodotto1.GetDescrizione();
Console.WriteLine($"Descrizione: {descrizione}");

float prezzo = prodotto1.GetPrezzo();
Console.WriteLine($"Prezzo pre-iva: {prezzo} euro");

float prezzoIva = prodotto1.GetPrezzoIva(); 
Console.WriteLine($"Prezzo {prezzoIva} euro");

