namespace classy_electronics
{

    public class Speakanator : Turntable
    {
        public int Volume { get; set; }

        public void VolumeUp()
        {
            Volume += 1;
        }

        public void VolumeDown()
        {
            Volume -= 1;
        }

    }
}