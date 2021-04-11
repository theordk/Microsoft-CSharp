using System;
namespace TP4
{
    public class Agent: Employe
    {
        private double _primeResponsabilite;

        //Accesseurs PrimeResponsabilité.
        public double PrimeResponsabilite
        {
            get { return _primeResponsabilite; }
            set { _primeResponsabilite = value; }
        }

        //Constructeur d’initialisation
        public Agent(DateTime dn, DateTime de, string n, double s, double pr): base(dn,de,n,s)
        {
            PrimeResponsabilite = pr;
        }

        /// <summary>
        /// La méthode SalaireAPayer() pour calculer le salaire net d’un agent 
        /// </summary>
        /// <returns>salaire_net</returns>
        public override double SalaireAPayer()
        {
            //Salaire net = (SalaireBase + PrimeResponsabilité) x (1 – taux IR)
            double salaire_net = (_salaireBase + _primeResponsabilite) * (1 - IR.getIR(_salaireBase));
            return salaire_net;
        }
    }
}
