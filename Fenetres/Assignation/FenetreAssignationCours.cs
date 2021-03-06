﻿using dotnet.UserControler.Affichage.Assignation;
using dotnet.UserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres.Assignation
{
    public partial class FenetreAssignationCours : FenetreAssignation
    {
        private UC_OngletPersonnels _cadre;
        private personnel _personnel;

        public FenetreAssignationCours()
        {
            InitializeComponent();
        }

        public FenetreAssignationCours(UC_OngletPersonnels cadre, personnel personnel)
        {
            InitializeComponent();
            _cadre = cadre;
            _personnel = personnel;

            initialisation();
        }

        private void initialisation()
        {
            lTitre.Text = "Sélectionnez le cours que vous souhaitez assigner en appuyant sur le bouton correspondant : ";

            uC_AffichageFenAssign1.setGroupBoxTiTre("Liste des cours non assignés à un personnel : ");

            var cours = Database.instance.cours;
            foreach (cours c in cours.ToList())
            {
                if ((c.id_personnel == null) && (Requetes.obtientECduCours(c).actif == true))
                    uC_AffichageFenAssign1.addElement(new UC_ElementFenCours(this, c));
            }
            uC_AffichageFenAssign1.updateAffichage();
        }

        private void FenetreAssignationCours_Load(object sender, EventArgs e)
        {
            
        }

        public void AssigneCours(cours c)
        {
            if ((Requetes.nbrHeureManquantes(_personnel) - c.volume_horraire) >= 0)
            {
                _personnel.cours.Add(c);
                Requetes.enregistreLaBDD();
            }
            else
            {
                MessageBox.Show("Le volume horraire disponible est insuffisant");
            }

            _cadre.Actualiser();
        }
    }
}
