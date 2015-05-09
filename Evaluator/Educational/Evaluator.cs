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

            rezultat += proiect.tehnologiiPotrivite;
            rezultat += proiect.formatOptimDeStocareADatelor;
            rezultat += proiect.librariiOpenSource;
            scalingFactor += toPercentage(proiect.tehnologiiModerne);
            rezultat += proiect.folosireaParadigmelor;
            rezultat += proiect.creareUnorNoiServicii;
            
            switch (proiect.portabilitate)
            {
                case Portabilitate.Minus30:
                    scalingFactor -= 0.3;
                    break;
                case Portabilitate.Minus20:
                    scalingFactor -= 0.2;
                    break;
                case Portabilitate.Minus10:
                    scalingFactor -= 0.1;
                    break;
            }

            return rezultat * scalingFactor;
        }

        static public double evalueazaImplementarea(Proiect proiect)
        {
            double rezultat = 0;
            double scalingFactor = 1.0;

            rezultat += proiect.usorDeExtins;
            rezultat += proiect.algoritmiiUtilizati;
            rezultat += proiect.variabileCuNumeSemnificative;
            rezultat += proiect.codConsecvent;
            rezultat += proiect.codDocumentat;
            rezultat += proiect.codEficient;
            rezultat += proiect.automatizareaTestarii;
            scalingFactor += toPercentage(proiect.absentaErorilorBanale);
            rezultat += proiect.folosireaUnuiSistemDeVersionare;
            scalingFactor += toPercentage(proiect.maturitate);
            
            switch (proiect.securitate)
            {
                case Securitate.Minus30:
                    scalingFactor -= 0.3;
                    break;
                case Securitate.Minus15:
                    scalingFactor -= 0.15;
                    break;
            }

            scalingFactor += toPercentage(proiect.distribuireEchilibrata);

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
            scalingFactor += toPercentage(proiect.utilitateaFunctionalitatilor);
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
            scalingFactor += toPercentage(proiect.oferaInformatiiGenerice);
            scalingFactor += toPercentage(proiect.prezintaTutoriale);
            scalingFactor += toPercentage(proiect.descrieArhitectura);
            scalingFactor += toPercentage(proiect.justificaTehnologiile);

            return rezultat * scalingFactor;
        }
    }
}
