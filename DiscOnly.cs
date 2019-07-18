namespace classy_electronics
{

    // Instructions: disc player with speakers but nothing else
    public class DiscOnly : Speakanator
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

        // public override turntable stuff?
        // not easily, lesson is to highlight why inheritance sucks

    }
}