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

Console.WriteLine("On a scale from 0 to 100, how much fuel do you have in your tank?");
int bomber0 = Convert.ToInt32(Console.ReadLine());

miaAuto = new Auto("Bugatti", "Chiron Pur Sport", "Bronzo", Auto.motore.benzina, bomber0);

Console.WriteLine("Do you want to turn on your car (I'll turn it on only if the fuel level is not 0)?");
string bomber = Console.ReadLine();
if (miaAuto.fuelLevel != 0 && bomber == "yes")
    miaAuto.accendi();

miaAuto.stampaDescrizione();
if (miaAuto.fuelLevel == 0)
    Console.WriteLine("THe car couldn't turn on! Your tank is empty!");

string bomber1 = "";

if (miaAuto.getEngineStatus())
{
    Console.WriteLine("Do you want to turn off your car?");
    bomber1 = Console.ReadLine();
}

if (miaAuto.fuelLevel != 0 && bomber1 == "yes")
{
    miaAuto.spegni();
    Console.WriteLine("car is now turned off!");
}
    
else if (miaAuto.fuelLevel != 0 && bomber1 == "no")
    Console.WriteLine("Car is still running bro!");


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
    /// true if on - false if off
    /// </summary>
    private bool engine;
    public int fuelLevel;

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
        result += "engine: " + this.engine + "\n";
        result += "fuel level: " + this.fuelLevel + "\n";
        result += "\n_______________________________\n";

        // restituisco il risultato
        return result;
    }

    /// <summary>
    ///Costruttore con argomenti per la classe Auto che valorizza le proprietà utilizzando i valori passati come argomento
    /// </summary>
    public Auto(string marca, string modello, string colore, motore tipoMotore, int fuelLevel)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
        this.fuelLevel = fuelLevel;
    }


    public bool getEngineStatus()
    {
        return engine;
    }
    /// <summary>
    /// metodo che setta il valore di engine a true
    /// </summary>
    public void accendi()
    {
        this.engine = true;
    }
    /// <summary>
    /// metodo che setta il valore di engine a false
    /// </summary>
    public void spegni()
    {
        this.engine = false;
    }
}