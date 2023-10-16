using System;

namespace testApp
{
    class Auto
    {
        #region " tipi "
        //tipi personalizzati
        public enum motore
        {
            benzina,
            diesel,
            elettrico
        }

        #endregion

        #region " proprietà "

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

        #endregion

        #region " metodi "
        /// <summary>
        /// stampa la descrizione del veicolo
        /// </summary>
        public void stampaDescrizione()
        {
            Console.WriteLine(GeneraDescrizione());
        }



        /// <summary>
        /// stampa lo stato attuale del veicolo
        /// </summary>
        public void stampaStato()
        {

        }


        public string generaStato()
        {
            string result;
            result = $"Carburante: {this.fuelLevel}";
            if (this.engine)
                result += " accesa";
            else
                result += "spenta";

            return result;
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


            #endregion

        }

    // end of class Auto
}

