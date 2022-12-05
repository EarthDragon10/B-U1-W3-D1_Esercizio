using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D1_Esercizio
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                ListItem SalaNord = new ListItem("SALA NORD", "1");
                ListItem SalaEst = new ListItem("SALA EST", "2");
                ListItem SalaSud = new ListItem("SALA SUD", "3");
                ddilTipoSala.Items.Add(SalaNord);
                ddilTipoSala.Items.Add(SalaEst);
                ddilTipoSala.Items.Add(SalaSud);
            }

        }
        protected void Prenota_Click(object sender, EventArgs e)
        {
            int salaSelected = Convert.ToInt32(ddilTipoSala.SelectedValue);       

            switch (salaSelected)
            {
                case 1:
                    ArchiviaPrenotazione("SALA NORD");
                    break;

                case 2:
                    ArchiviaPrenotazione("SALA EST");
                    break;

                case 3:
                    ArchiviaPrenotazione("SALA SUD");
                    break;
                default:
                    break;
            }

            //if(salaSelected == 1)
            //{
            //    ArchiviaPrenotazione("SALA NORD");
            //} else if (salaSelected == 2) {
            //    ArchiviaPrenotazione("SALA EST");
            //} else if (salaSelected == 3)
            //{
            //    ArchiviaPrenotazione("SALA SUD");
            //}

        }

        
        private void ArchiviaPrenotazione(string NomeSala)
        {
 
            Prenotazione prenotazione = new Prenotazione();

            prenotazione.Nome = txtNome.Text;
            prenotazione.Cognome = txtCognome.Text;
            prenotazione.BigliettoRidotto = CK_BBigliettoRidotto.Checked;
            prenotazione.TipoSala = NomeSala;

            Prenotazione.listaPrenotazioni.Add(prenotazione);

            AggiornaBigliettiVenduti();
        }

        private void AggiornaBigliettiVenduti() {

            // SALA NORD
            int bigliettiSalaNord = 0;
            int ridottiSalaNord = 0;

            // SALA EST
            int bigliettiSalaEst = 0;
            int ridottiSalaEst = 0;

            // SALA SUD
            int bigliettiSalaSud = 0;
            int ridottiSalaSud = 0;
       

            foreach (var biglietto in Prenotazione.listaPrenotazioni) {
                if (biglietto.TipoSala == "SALA NORD") {
                    bigliettiSalaNord++;

                        if (biglietto.BigliettoRidotto)
                        {
                        ridottiSalaNord++;
                        }

                    txtSalaNord.InnerHtml = $"Biglietti venduti SALA NORD: {bigliettiSalaNord}, di cui ridotti: {ridottiSalaNord}";
                }
                
                if(biglietto.TipoSala == "SALA EST")
                {
                    bigliettiSalaEst++;

                    if (biglietto.BigliettoRidotto) {
                        ridottiSalaEst++;
                    }

                    txtSalaEst.InnerHtml = $"Biglietti venduti SALA EST: {bigliettiSalaEst}, di cui ridotti: {ridottiSalaEst}";
                }

                if (biglietto.TipoSala == "SALA SUD")
                {
                    bigliettiSalaSud++;

                    if (biglietto.BigliettoRidotto)
                    {
                        ridottiSalaSud++;
                    }

                    txtSalaSud.InnerHtml = $"Biglietti venduti SALA SUD: {bigliettiSalaSud}, di cui ridotti: {ridottiSalaSud}";
                }
            }
        }
    }

    public class Prenotazione
    {
        public string TipoSala { get; set; }
        public bool BigliettoRidotto { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public static List<Prenotazione> listaPrenotazioni = new List<Prenotazione>();
    }
}