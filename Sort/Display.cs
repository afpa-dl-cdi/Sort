using System;
namespace Sort
{
    /// <summary>
    /// Classe permettant d'afficher des tableaux de tout type
    /// </summary>
    static class Dis
    {
        /// <summary>
        /// Affiche les données d'un tableau sur une ligne
        /// </summary>
        /// <remarks>La méthode prend tous les typages</remarks>
        /// <param name="t"></param>
        public static void Play<T>(T [] t)
        {
            foreach (T item in t)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
        }
    }
}