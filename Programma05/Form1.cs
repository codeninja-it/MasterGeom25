using Programma04.Strutture;
using System.Net;

namespace Programma05
{
    public partial class Form1 : Form
    {
        private Mappa mappa;

        public Form1()
        {
            mappa = new Mappa("principale");
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Prova di scrittura";
            txtX.Text = "prova 2";
            txtY.Text = "prova 3";
        }

        private void btnAggiungi_Click_1(object sender, EventArgs e)
        {
            // creo un nuovo punto in mappa
            mappa.nodi.Add(
                new Nodo(
                    int.Parse(txtId.Text),
                    txtNome.Text,
                    float.Parse(txtX.Text),
                    float.Parse(txtY.Text)
                )
            );
            // svuoto i campi in maschera per avvertire l'utente
            txtId.Text = "";
            txtNome.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            // e aggiorno la lista dei nodi a schermo
            lstNodi.Items.Clear();
            foreach(Nodo singolo in mappa.nodi)
            {
                lstNodi.Items.Add( singolo.Nome );
            }

            Form1 clone = new Form1();
            clone.Show();
        }

    }
}
