using System;
namespace Sort
{
    /// <summary>
    /// Le tri par insertion est un tri dit "naturel"
    /// qui peut être plus lent que d'autres algorithmes 
    /// mais peut s'avérer efficace sur des petits tableaux 
    /// </summary>
    static class InsertionSort
    {
        /// <summary>
        /// Classement du tableau donnée en paramètre en tri par insertion
        /// </summary>
        /// <param name="tab">Tableau à trier</param>
        public static void Sort(int [] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                temp = tab[i];
                int j = i;
                while (j >0 && tab[j-1] > temp)
                {
                    tab[j] = tab[j - 1];
                    j = j - 1;
                }
               tab[j] = temp;
            }
        }
    }
}