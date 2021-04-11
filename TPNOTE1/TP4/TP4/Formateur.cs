using System;
namespace TP4
{
    public class Formateur: Employe
    {
        private int _heureSup;
        private double _remunerationHSup;

        //Accesseur de l'attribut _heureSup
        public int HeureSup
        {
            get => _heureSup;
            set => _heureSup = value;
        }

        //Accesseur de l'attribut _remunerationHSup
        public double RemunerationHSup
        {
            get => _remunerationHSup;
            set => _remunerationHSup = value;
        } 

        /// <summary>
        /// Constructeur par défaut de Formateur
        /// </summary>
        public Formateur(): base()
        {
            HeureSup = 0;
            RemunerationHSup = 70;
        }

        /// <summary>
        /// Cosntructeur d'inatialisation de Formateur
        /// </summary>
        /// <param name="hSup"></param>
        /// <param name="remHSup"></param>
        public Formateur(DateTime dn, DateTime de, string n, double s, int hSup, double remHSup) : base(dn, de, n, s)
        {
            HeureSup = hSup;
            RemunerationHSup = remHSup;
        }

        /// <summary>
        /// Redéfinition de la méthode SalaireAPayer() pour calculer le salaire net d’un formateur
        /// </summary>
        /// <returns>salaireNet</returns>
        public override double SalaireAPayer()
        {
            double salaireNet = (_salaireBase + (HeureSup * RemunerationHSup)) * (1 - IR.getIR(_salaireBase));
            return salaireNet;
        }

        /// <summary>
        /// Redéfinition de la méthode ToString() pour renvoyer les propriétés d'un Formateur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " - " + _heureSup + " - " + _remunerationHSup;
        }
    }
}
