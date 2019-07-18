using System.Collections.Generic;

namespace classy_electronics
{

    public class Radionator : Speakanator
    {
        public double CurrFrequency { get; set; }

        public List<double> FavoriteStations { get; set; }

        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }

        // or
        /* public void AddFavorite()
        {
        FavoriteStations.Add(CurrFrequency);
        }*/

        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }

    }
}