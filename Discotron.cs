namespace classy_electronics
{

    public class Discotron : Radionator
    {
        public int TotalTracks { get; set; }
        public int CurrTrack { get; set; }

        public void NextTrack()
        {
            CurrTrack += 1;
        }

        public void PreviousTrack()
        {
            CurrTrack -= 1;
        }

    }
}