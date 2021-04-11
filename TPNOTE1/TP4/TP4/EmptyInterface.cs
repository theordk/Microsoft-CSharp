using System;
namespace TP4
{
    public interface IEmploye
    {
        //Méthode Age() : retourne âge employé
        int Age();

        //Méthode Anciennete() : retourne ancienneté employé 
        int Anciennete();

        /// <summary>
        /// Méthode DateRetraite(ageRetraite) : renvoyer date de retraite
        /// </summary>
        /// <param name="ageRetraite"></param>
        /// <returns></returns>
        DateTime DateRetraite(int ageRetraite);
    }
}
