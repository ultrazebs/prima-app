// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * L'app deve modellare un'automobile, per falo deve registrare le informazioni relative a:
 * - marca;
 * - modello;
 * - tipo di motore (benzina, diesel, elettrico);
 * - colore.
 * All'avvio l'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore.
 * 
 * Per modellare l'automobile implementiamo una classe chiamata Auto.
 * 
 * 
 */
Auto miaAuto;

miaAuto = new Auto("Bugatti", "Chiron Pur Sport", "Bronzo", Auto.motore.benzina);

miaAuto.stampa();



Console.ReadLine();

class Auto
{
    //tipi personalizzati
    public enum motore
    {
        benzina,
        diesel,
        elettrico
    }
    //proprietà
    public string marca;
    public string modello;
    public string colore;
    public motore tipoMotore;

    public void stampa()
    {
        // stampo le caratteristiche dell'auto:
        Console.WriteLine("marca: " + this.marca);
        Console.WriteLine("modello: " + this.modello);
        Console.WriteLine("colore: " + this.colore);
        Console.WriteLine("tipoMotore: " + this.tipoMotore);
        Console.WriteLine("\n_______________________________\n");
    }

    public Auto(string marca, string modello, string colore, motore tipoMotore)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
    }
}