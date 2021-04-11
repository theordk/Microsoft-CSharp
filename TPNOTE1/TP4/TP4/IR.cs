using System;
namespace TP4
{
    abstract class IR
    {
        private static int[] _tranches = { 0, 28000, 40000, 50000, 60000, 150000 };
        private static double[] _tauxIR = { 0, 0.12, 0.24, 0.34, 0.38, 0.4 };

        /// <summary>
        /// Fonction qui retourne le taux IR en fonction du salaire
        /// </summary>
        /// <param name="salaire"></param>
        /// <returns></returns>
        public static double getIR(double salaire)
        {
            if (salaire <= _tranches[1]) return _tauxIR[0];
            else if (salaire <= _tranches[2] && salaire > _tranches[1]) return _tauxIR[1];
            else if (salaire <= _tranches[3] && salaire > _tranches[2]) return _tauxIR[2];
            else if (salaire <= _tranches[4] && salaire > _tranches[3]) return _tauxIR[3];
            else if (salaire <= _tranches[5] && salaire > _tranches[4]) return _tauxIR[4];
            else return _tauxIR[5];
        }
    }
}
