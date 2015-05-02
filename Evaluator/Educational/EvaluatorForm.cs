using System.Windows.Forms;

namespace InfoEducatie.Educational.Evaluator
{
    public partial class EvaluatorForm : Form
    {
        private Proiect proiect = new Proiect();

        public EvaluatorForm()
        {
            InitializeComponent();
            ActualizeazaFormularul();
        }

        public void ActualizeazaPunctajele()
        {
            // Arhitectura aplicatiei.
            proiect.tehnologiiOptime = slider11.Value;
            proiect.faraTehnologiiModerne = slider12.Value;
            proiect.folosireaParadigmelor = slider13.Value;
            proiect.tehnologiiOpenSource = slider14.Value;
            proiect.portabilitate = (Portabilitate)slider15.Value;

            // Implementarea aplicatiei.
            proiect.poateFiExtinsUsor = slider21.Value;
            proiect.codEficient = slider22.Value;
            proiect.variabileCuNumeSemnificative = slider23.Value;
            proiect.codConsecvent = slider24.Value;
            proiect.codDocumentat = slider25.Value;
            proiect.maturitateaProiectului = (Maturitate)slider26.Value;
            proiect.testataRiguros = slider27.Value;
            proiect.securitate = (Securitate)slider28.Value;
            proiect.sistemDeVersionareNeutilizat = slider29.Value;
            proiect.distribuireNeechilibrata = slider210.Value;

            // Interfata.
            proiect.aspectPlacut = slider31.Value;
            proiect.responsive = slider32.Value;
            proiect.usurintaInFolosire = slider33.Value;

            // Continut.
            proiect.multipleFunctionalitati = slider41.Value;
            proiect.functionalitatiInutile = slider42.Value;
            proiect.evaluare = slider43.Value;
            proiect.feedback = slider44.Value;
            proiect.continutActualizabil = slider45.Value;
            proiect.continutGestionabil = slider46.Value;
            proiect.originalitate = (Originalitate)slider47.Value;
            proiect.corectitudine = (Corectitudine)slider48.Value;

            // Prezentarea proiectului.
            proiect.impresieGenerala = slider51.Value;
            proiect.faraInformatiiGenerice = slider52.Value;
            proiect.faraTutoriale = slider53.Value;
            proiect.faraDescriereaArhitecturii = slider54.Value;
            proiect.faraJustificareaTehnologiilor = slider55.Value;
        }
        
        public void ActualizeazaFormularul()
        {
            rezultat11.Text = string.Format("+{0}p", slider11.Value);
            rezultat12.Text = string.Format("{0}%", slider12.Value);
            rezultat13.Text = string.Format("+{0}p", slider13.Value);
            rezultat14.Text = string.Format("+{0}p", slider14.Value);

            switch (slider15.Value)
            {
                case 0:
                    rezultat15.Text = "0p. Rulează pe sub 50% din dispozitivele target audience-ului.";
                    break;
                case 1:
                    rezultat15.Text = "+1p. Rulează pe cel puțin 50% din dispozitivele target audience-ului.";
                    break;
                case 2:
                    rezultat15.Text = "+3p. Rulează pe cel puțin 75% din dispozitivele target audience-ului.";
                    break;
                case 3:
                    rezultat15.Text = "+5p. Rulează pe aproape toate dispozitivele target audience-ului.";
                    break;
            }

            rezultat21.Text = string.Format("+{0}p", slider21.Value);
            rezultat22.Text = string.Format("+{0}p", slider22.Value);
            rezultat23.Text = string.Format("+{0}p", slider23.Value);
            rezultat24.Text = string.Format("+{0}p", slider24.Value);
            rezultat25.Text = string.Format("+{0}p", slider25.Value);

            switch (slider26.Value)
            {
                case 0:
                    rezultat26.Text = "0p. Proiectului îi lipsesc mai multe componente majore.";
                    break;
                case 1:
                    rezultat26.Text = "+4p. Proiectului îi lipsește o componentă majoră.";
                    break;
                case 2:
                    rezultat26.Text = "+7p. Proiectului îi lipsesc unele componente minore.";
                    break;
                case 3:
                    rezultat26.Text = "+10p. Proiectul este într-un stadiu în care poate fi publicat.";
                    break;
            }

            rezultat27.Text = string.Format("+{0}p", slider27.Value);

            switch (slider28.Value)
            {
                case 0:
                    rezultat28.Text = "-30%. Aplicația este expusă la vulnerabilități banale.";
                    break;
                case 1:
                    rezultat28.Text = "-15%. Aplicația este expusă la unele vulnerabilități mai puțin banale.";
                    break;
                case 2:
                    rezultat28.Text = "Securitatea aplicației este rezonabilă.";
                    break;
            }

            rezultat29.Text = string.Format("{0}%", slider29.Value);
            rezultat210.Text = string.Format("{0}%", slider210.Value);
            rezultat31.Text = string.Format("+{0}p", slider31.Value);
            rezultat32.Text = string.Format("+{0}p", slider32.Value);
            rezultat33.Text = string.Format("+{0}p", slider33.Value);
            rezultat41.Text = string.Format("+{0}p", slider41.Value);
            rezultat42.Text = string.Format("{0}%", slider42.Value);
            rezultat43.Text = string.Format("+{0}p", slider43.Value);
            rezultat44.Text = string.Format("+{0}p", slider44.Value);
            rezultat45.Text = string.Format("+{0}p", slider45.Value);
            rezultat46.Text = string.Format("+{0}p", slider46.Value);

            switch (slider47.Value)
            {
                case 0:
                    rezultat47.Text = "-30%. Ideea este neoriginală și nu aduce nimic nou față de soluțiile deja existente.";
                    break;
                case 1:
                    rezultat47.Text = "-10%. Ideea este neoriginală dar puțin distinctă față de soluțiile deja existente.";
                    break;
                case 2:
                    rezultat47.Text = "Ideea este originală sau aduce inovații semnificative față de soluțiile deja existente.";
                    break;
            }

            switch (slider48.Value)
            {
                case 0:
                    rezultat48.Text = "-30%. Conținutul conține multiple greșeli majore de natură științifică.";
                    break;
                case 1:
                    rezultat48.Text = "-20%. Conținutul conține o greșeală majoră de natură științifică.";
                    break;
                case 2:
                    rezultat48.Text = "-10%. Conținutul conține o greșeală minoră de natură științifică.";
                    break;
                case 3:
                    rezultat48.Text = "Conținutul nu conține greșeli semnificative de natură științifică.";
                    break;
            }

            rezultat51.Text = string.Format("+{0}p", slider51.Value);
            rezultat52.Text = string.Format("{0}%", slider52.Value);
            rezultat53.Text = string.Format("{0}%", slider53.Value);
            rezultat54.Text = string.Format("{0}%", slider54.Value);
            rezultat55.Text = string.Format("{0}%", slider55.Value);

            // Rezultatele finale.
            rezultatArhitectura.Text = Evaluator.evalueazaArhitectura(proiect).ToString();
            rezultatImplementare.Text = Evaluator.evalueazaImplementarea(proiect).ToString();
            rezultatInterfata.Text = Evaluator.evalueazaInterfata(proiect).ToString();
            rezultatContinut.Text = Evaluator.evalueazaContinutul(proiect).ToString();
            rezultatPrezentare.Text = Evaluator.evalueazaPrezentarea(proiect).ToString();
            rezultatTotal.Text = Evaluator.evalueaza(proiect).ToString();
        }

        private void slider_Scroll(object sender, System.EventArgs e)
        {
            ActualizeazaPunctajele();
            ActualizeazaFormularul();
        }
    }
}
