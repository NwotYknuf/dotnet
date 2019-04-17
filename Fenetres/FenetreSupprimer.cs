using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres
{
    public partial class FenetreSupprimer : Form
    {
        private String _typeDeSuppression;

        private diplome _d;
        private annee _a;
        private periode _p;
        private ue _u;
        private ec _e;
        private cours _c;
        private personnel _per;
        private categorie _cat;
        private type_cours _typC;

        private FenetreRetrait _fen;

        public FenetreSupprimer()
        {
            InitializeComponent();
        }

        public FenetreSupprimer(String typeDeSuppression, diplome d)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _d = d;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, annee a)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _a = a;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, periode p)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _p = p;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, ue u)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _u = u;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, ec e)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _e = e;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, cours c)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _c = c;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, personnel per)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _per = per;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, categorie cat, FenetreRetrait fen)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _cat = cat;
            _fen = fen;
            initialisation();
        }

        public FenetreSupprimer(String typeDeSuppression, type_cours typC, FenetreRetrait fen)
        {
            InitializeComponent();
            _typeDeSuppression = typeDeSuppression;
            _typC = typC;
            _fen = fen;
            initialisation();
        }

        private void initialisation()
        {
            String NomElement;

            switch (_typeDeSuppression)
            {
                case "Diplome": { NomElement = _d.nom; break; }
                case "Annee": { NomElement = _a.nom; break; }
                case "Periode": { NomElement = _p.nom; break; }
                case "UE": { NomElement = _u.nom; break; }
                case "EC": { NomElement = _e.nom; break; }
                case "Cours": { NomElement = _c.nom; break; }
                case "Personnel": { NomElement = _per.nom; break; }
                case "Categorie": { NomElement = _cat.nom; break; }
                case "Type_Cours": { NomElement = _typC.nom; break; }
                default: { NomElement = " "; break; }
            }
            lNomElement.Text = _typeDeSuppression + " : " + NomElement;
            lNomElement.ForeColor = Color.FromArgb(83, 181, 0);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            // Supprimer l'élément
            switch(_typeDeSuppression)
            {
                case "Diplome":
                    {
                        // Supprimer le diplome
                        Requetes.retirerDiplome(_d);
                        break;
                    }
                case "Annee":
                    {
                        // Supprimer l'annee
                        Requetes.retirerAnnee(_a);
                        break;
                    }
                case "Periode":
                    {
                        // Supprimer la période
                        Requetes.retirerPeriode(_p);
                        break;
                    }
                case "UE":
                    {
                        // Supprimer l'ue
                        Requetes.retirerUE(_u);
                        break;
                    }
                case "EC":
                    {
                        // Supprimer l'ec
                        Requetes.retirerEC(_e);
                        break;
                    }
                case "Cours":
                    {
                        // Supprimer le cours
                        Requetes.retirerCours(_c);
                        break;
                    }
                case "Personnel":
                    {
                        // Supprimer le personnel
                        Requetes.retirerPersonnel(_per);
                        break;
                    }
                case "Categorie":
                    {
                        // Supprimer la catégorie

                        _fen.suppressionValidee();
                        break;
                    }
                case "Type_Cours":
                    {
                        // Supprimer le type de cours

                        _fen.suppressionValidee();
                        break;
                    }
                default : break;
            }

            Requetes.enregistreLaBDD();

            this.Dispose();
        }
    }
}
