namespace InfoEducatie.Educational.Evaluator
{
    public enum Portabilitate { Zero, Unu, Trei, Cinci }

    public enum Maturitate { Zero, Patru, Sapte, Zece }

    public enum Securitate { Minus30, Minus15, Okay }

    public enum Originalitate { Minus30, Minus10, Okay }

    public enum Corectitudine { Minus30, Minus20, Minus10, Okay }

    public class Proiect    
    {
        // +x = Adauga pana in x puncte sectiunii respective.
        // -x% = Scade pana in x% din punctajul sectiunii respective.


        /* Arhitectura aplicatiei (20p). */

        // Tehnologii folosite (10p).
        public int tehnologiiOptime; // +10p.
        public int faraTehnologiiModerne; // -30%.
        
        // Proiectarea arhitecturala (5p).
        public int folosireaParadigmelor; // +4p.
        public int tehnologiiOpenSource; // +1p.
        
        // Portabilitate (5p).
        public Portabilitate portabilitate; // 5p / 3p / 1p / 0p.


        /* Implementarea aplicatiei (30p). */

        // Eleganta implementarii (18p).
        public int poateFiExtinsUsor; // +6p.
        public int codEficient; // +3p.
        public int variabileCuNumeSemnificative; // +3p.
        public int codConsecvent; // +3p.
        public int codDocumentat; // +3p.

        // Maturitatea aplicatiei (10p).
        public Maturitate maturitateaProiectului; // 10p / 7p / 4p / 0p.

        // Testarea aplicatiei (2p).
        public int testataRiguros; // +2p.

        // Securitatea aplicatiei.
        public Securitate securitate; // -30% / -15% / Okay.

        // Folosirea unui sistem de versionare.
        public int sistemDeVersionareNeutilizat; // -10%.

        // Distribuirea echilibrata a rolurilor in echipa.
        public int distribuireNeechilibrata; // -20%.


        /* Interfata (20p). */

        // Impresia generala (10p).
        public int aspectPlacut; // +6p.
        public int responsive; // +4p.

        // Usurinta in folosire (10p).
        public int usurintaInFolosire; // +10p.


        /* Continut (20p). */
        
        // Functionalitate si utilitate (5p).
        public int multipleFunctionalitati; // +5p.
        public int functionalitatiInutile; // -20%.

        // Evaluare si feedback (10p).
        public int evaluare; // +5p.
        public int feedback; // +5p.

        // Posibilitatea de a actualiza si gestiona continutul (5p).
        public int continutActualizabil; // +3p.
        public int continutGestionabil; // +2p.

        // Originalitatea ideii si inovatii aduse fata de solutii existente.
        public Originalitate originalitate; // -30% / -10% / Okay.

        // Corectitudinea informatiilor din punct de vedere stiintific.
        public Corectitudine corectitudine; // -30% / -20% / -10% / Okay.


        /* Prezentarea proiectului (10p). */
        
        // Impresia generala.
        public int impresieGenerala; // +10p.
        
        // Documentatia proiectului.
        public int faraInformatiiGenerice; // -10%;
        public int faraTutoriale; // -20%;
        public int faraDescriereaArhitecturii; // -20%;
        public int faraJustificareaTehnologiilor; // -20%;
    }
}
