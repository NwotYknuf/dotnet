﻿using dotnet.UserControler.Affichage.Assignation;
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
    public partial class FenetreAssignationPersonnel : FenetreAssignation
    {
        private UC_OngletDiplomes _cadre;
        private cours _cours;

        public FenetreAssignationPersonnel()
        {
            InitializeComponent();
        }

        public FenetreAssignationPersonnel(UC_OngletDiplomes cadre, cours cours)
        {
            InitializeComponent();
            _cadre = cadre;
            _cours = cours;

            initialisation();
        }

        private void initialisation()
        {
            lTitre.Text = "Sélectionnez le personnel que vous souhaitez assigner en appuyant sur le bouton correspondant : ";

            uC_AffichageFenAssign1.setGroupBoxTiTre("Liste des personnels n'ayant pas toutes leurs heures de cours assignées : ");

            var personnels = Database.instance.personnel;
            foreach (personnel p in personnels)
            {
               //if (Requetes.nbrHeureManquantes(p) > 0)
                    uC_AffichageFenAssign1.addElement(new UC_ElementFenPersonnel(this, p));
            }
            uC_AffichageFenAssign1.updateAffichage();
        }

        public void AssignePersonnel(personnel p)
        {
            _cours.personnel = p;

            Database.instance.SaveChanges();

            ec e = Database.instance.ec.Where(x => x.id == _cours.ec.id).FirstOrDefault<ec>();

            _cadre.afficheECSelectionnee(e);
        }
    }
}