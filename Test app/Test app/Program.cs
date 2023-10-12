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

testApp.Auto miaAuto;

Console.WriteLine("On a scale from 0 to 100, how much fuel do you have in your tank?");
int bomber0 = Convert.ToInt32(Console.ReadLine());

miaAuto = new testApp.Auto("Bugatti", "Chiron Pur Sport", "Bronzo", testApp.Auto.motore.benzina, bomber0);

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


