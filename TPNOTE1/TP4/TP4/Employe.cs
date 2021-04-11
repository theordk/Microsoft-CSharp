using System;
namespace TP4
{
    //Classe abstraite car contient méthode abstraite SalaireAPayer()
    public abstract class Employe
    {
        //Attributs
        protected DateTime _dateEmbauche, _dateNaissance;
        protected int _mtle;
        protected string _nom;
        protected double _salaireBase;
        private static int compteur;

        //Accesseur DateNaissance
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        //Accesseur DateEmbauche (avec exception pour l'âge à l'embauche)
        public DateTime DateEmbauche
        {
            get { return _dateEmbauche; }
            set
            {
                //TimeSpan objet qui représente la différence entre deux dates.
                TimeSpan tps = value - _dateNaissance;
                if((tps.TotalDays/365) < 16)
                {
                    throw new Exception("l’âge de l’employé à la date de recrutement ne doit pas être inférieur à 16 ans");
                }
                _dateEmbauche = value;
            }
        }

        //Accesseur Matricule
        public int Mtle
        {
            get { return _mtle; }
            set { _mtle = value; }
        }

        //Accesseur Nom
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        //Accesseur SalaireBase
        public double SalaireBase
        {
            get { return _salaireBase; }
            set { _salaireBase = value; }
        }

        //Constructeur par défaut
        public Employe()
        {
            //On incrémente le compteur automatiquement
            compteur++;
            _mtle = compteur;
            //On initialise les attributs avec des valeurs par défault
            _dateEmbauche = DateTime.Now;
            _dateNaissance = new DateTime(1990, 01, 01);
            _nom = "Bob";
            _salaireBase = 100;
        }

        //Constructeur d'initialisation
        public Employe(DateTime dn, DateTime de, string n, double s)
        {
            //On incrémente le compteur automatiquement
            compteur++;
            _mtle = compteur;
            //On initialise les attributs avec des valeurs entrées
            DateEmbauche = de;
            DateNaissance = dn;
            Nom = n;
            SalaireBase = s;
        }

        /// <summary>
        /// Méthode abstraite pour retourner le salaire net d’un employé
        /// </summary>
        /// <returns></returns>
        public abstract double SalaireAPayer();

        /// <summary>
        /// méthode Age() qui retournera l’âge d’un employé
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>age</returns>
        public int Age(Employe emp)
        {
            TimeSpan tps = DateTime.Now - _dateNaissance;
            int age = (int)tps.TotalDays / 365;
            return age;
        }

        /// <summary>
        /// méthode Ancienneté() qui retournera l’ancienneté d’un employé (le nombre d’années qu’il a travaillé)
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>anciennete</returns>
        public int Anciennete(Employe emp)
        {
            TimeSpan tps = DateTime.Now - _dateEmbauche;
            int anciennete = (int)tps.TotalDays / 365;
            return anciennete;
        }

        /// <summary>
        /// Méthode DateRetraite(ageRetraite) pour renvoyer la date de retraite de l’employé
        /// </summary>
        /// <param name="ageRetraite"></param>
        /// <returns>date_retraite</returns>
        public DateTime DateRetraite(int ageRetraite)
        {
            //Date de retraite = date de naissance + âge de retraite
            DateTime date_retraite = new DateTime(_dateNaissance.Year,_dateNaissance.Month,_dateNaissance.Day).AddYears(ageRetraite);
            return date_retraite;
        }

        /// <summary>
        /// Méthode ToString() pour retourner les informations d'un emploe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _mtle + " - " + _nom + " - " + _dateNaissance + " - " + _dateEmbauche + " - " + _salaireBase; 
        }

    }
}
