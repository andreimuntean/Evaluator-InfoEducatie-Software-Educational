namespace InfoEducatie.Educational.Evaluator
{
    public enum Portabilitate { Minus30, Minus20, Minus10, Okay }

    public enum Securitate { Minus30, Minus15, Okay }

    public enum Originalitate { Minus30, Minus10, Okay }

    public enum Corectitudine { Minus30, Minus20, Minus10, Okay }

    public class Proiect    
    {
        // +x = Adauga pana in x puncte sectiunii respective.
        // -x% = Scade pana in x% din punctajul sectiunii respective.

        #region Arhitectura aplicatiei (20p)
        // Tehnologii folosite (10p).
        public int tehnologiiPotrivite; // +4p.
        public int formatOptimDeStocareADatelor; // +3p.
        public int librariiOpenSource; // +3p.
        public int tehnologiiModerne; // -30%.
        
        // Proiectarea arhitecturala (10p).
        public int folosireaParadigmelor; // +5p.
        public int creareUnorNoiServicii; // +5p.
        
        // Portabilitate.
        public Portabilitate portabilitate; // -30% / -20% / -10% / Okay.

        #endregion

        #region Implementarea aplicatiei (30p).
        // Eleganta implementarii (20p).
        public int usorDeExtins; // +5p.
        public int algoritmiiUtilizati; // +3p.
        public int variabileCuNumeSemnificative; // +3p.
        public int codConsecvent; // +3p.
        public int codDocumentat; // +3p.
        public int codEficient; // +3p.

        // Testarea aplicatiei (6p).
        public int automatizareaTestarii; // +6p.
        public int absentaErorilorBanale; // -10%.

        // Folosirea unui sistem de versionare (4p).
        public int folosireaUnuiSistemDeVersionare; // +4p.

        // Maturitatea aplicatiei.
        public int maturitate; // -30%.

        // Securitatea aplicatiei.
        public Securitate securitate; // -30% / -15% / Okay.

        // Distribuirea echilibrata a rolurilor in echipa.
        public int distribuireEchilibrata; // -20%.
        #endregion

        #region Interfata (20p).
        // Impresia generala (10p).
        public int aspectPlacut; // +6p.
        public int responsive; // +4p.

        // Usurinta in folosire (10p).
        public int usurintaInFolosire; // +10p.
        #endregion

        #region Continut (20p).
        // Functionalitate si utilitate (5p).
        public int multipleFunctionalitati; // +5p.
        public int utilitateaFunctionalitatilor; // -20%.

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
        #endregion
        
        #region Prezentarea proiectului (10p).
        // Impresia generala.
        public int impresieGenerala; // +10p.
        
        // Documentatia proiectului.
        public int oferaInformatiiGenerice; // -10%;
        public int prezintaTutoriale; // -20%;
        public int descrieArhitectura; // -20%;
        public int justificaTehnologiile; // -20%;
        #endregion
    }
}
