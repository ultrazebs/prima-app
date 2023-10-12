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

miaAuto.stampaDescrizione();



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

    /// <summary>
    /// 
    /// </summary>
    public void stampaDescrizione()
    {
        Console.WriteLine(GeneraDescrizione());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string GeneraDescrizione()
    {
        // dichiarazione variabili
        string result;

        // costruisco il risultato concatenando le descrizioni
        result = "marca: " + this.marca + "\n";
        result += $"modello:  {this.modello}\n";
        result += "colore: " + this.colore + " \n";
        result += "tipo motore: " + this.tipoMotore + "\n";
        result += "\n_______________________________\n";

        // restituisco il risultato
        return result;
    }

    /// <summary>
    ///Costruttore con argomenti per la classe Auto che valorizza le proprietà utilizzando i valori passati come argomento
    /// </summary>
    public Auto(string marca, string modello, string colore, motore tipoMotore)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
    }
}