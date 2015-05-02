namespace InfoEducatie.Educational.Evaluator
{
    static public class Evaluator
    {
        static private double toPercentage(int percentage)
        {
            return (double)percentage / 100.0;
        }

        static public double evalueaza(Proiect proiect)
        {
            double arhitectura = evalueazaArhitectura(proiect);
            double implementarea = evalueazaImplementarea(proiect);
            double interfata = evalueazaInterfata(proiect);
            double continutul = evalueazaContinutul(proiect);
            double prezentarea = evalueazaPrezentarea(proiect);

            return arhitectura + implementarea + interfata + continutul + prezentarea;
        }

        static public double evalueazaArhitectura(Proiect proiect)
        {
            double rezultat = 0;
            double scalingFactor = 1.0;

            rezultat += proiect.tehnologiiOptime;
            rezultat += proiect.folosireaParadigmelor;
            rezultat += proiect.tehnologiiOpenSource;
            
            switch (proiect.portabilitate)
            {
                case Portabilitate.Cinci:
                    rezultat += 5;
                    break;
                case Portabilitate.Trei:
                    rezultat += 3;
                    break;
                case Portabilitate.Unu:
                    rezultat += 1;
                    break;
            }

            scalingFactor += toPercentage(proiect.faraTehnologiiModerne);

            return rezultat * scalingFactor;
        }

        static public double evalueazaImplementarea(Proiect proiect)
        {
            double rezultat = 0;
            double scalingFactor = 1.0;

            rezultat += proiect.poateFiExtinsUsor;
            rezultat += proiect.codEficient;
            rezultat += proiect.variabileCuNumeSemnificative;
            rezultat += proiect.codConsecvent;
            rezultat += proiect.codDocumentat;

            switch (proiect.maturitateaProiectului)
            {
                case Maturitate.Zece:
                    rezultat += 10;
                    break;
                case Maturitate.Sapte:
                    rezultat += 7;
                    break;
                case Maturitate.Patru:
                    rezultat += 4;
                    break;
            }

            rezultat += proiect.testataRiguros;
            
            switch (proiect.securitate)
            {
                case Securitate.Minus30:
                    scalingFactor -= 0.3;
                    break;
                case Securitate.Minus15:
                    scalingFactor -= 0.15;
                    break;
            }

            scalingFactor += toPercentage(proiect.sistemDeVersionareNeutilizat);
            scalingFactor += toPercentage(proiect.distribuireNeechilibrata);

            return rezultat * scalingFactor;
        }

        static public double evalueazaInterfata(Proiect proiect)
        {
            double rezultat = 0;

            rezultat += proiect.aspectPlacut;
            rezultat += proiect.responsive;
            rezultat += proiect.usurintaInFolosire;

            return rezultat;
        }

        static public double evalueazaContinutul(Proiect proiect)
        {
            double rezultat = 0;
            double scalingFactor = 1.0;

            rezultat += proiect.multipleFunctionalitati;
            scalingFactor += toPercentage(proiect.functionalitatiInutile);
            rezultat += proiect.evaluare;
            rezultat += proiect.feedback;
            rezultat += proiect.continutActualizabil;
            rezultat += proiect.continutGestionabil;

            switch (proiect.originalitate)
            {
                case Originalitate.Minus30:
                    scalingFactor -= 0.3;
                    break;
                case Originalitate.Minus10:
                    scalingFactor -= 0.1;
                    break;
            }

            switch (proiect.corectitudine)
            {
                case Corectitudine.Minus30:
                    scalingFactor -= 0.3;
                    break;
                case Corectitudine.Minus20:
                    scalingFactor -= 0.2;
                    break;
                case Corectitudine.Minus10:
                    scalingFactor -= 0.1;
                    break;
            }

            return rezultat * scalingFactor;
        }

        static public double evalueazaPrezentarea(Proiect proiect)
        {
            double rezultat = 0;
            double scalingFactor = 1.0;

            rezultat += proiect.impresieGenerala;
            scalingFactor += toPercentage(proiect.faraInformatiiGenerice);
            scalingFactor += toPercentage(proiect.faraTutoriale);
            scalingFactor += toPercentage(proiect.faraDescriereaArhitecturii);
            scalingFactor += toPercentage(proiect.faraJustificareaTehnologiilor);

            return rezultat * scalingFactor;
        }
    }
}
