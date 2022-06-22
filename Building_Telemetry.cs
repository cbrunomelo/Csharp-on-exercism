public static class RemoteControlCar
{
    public static Car Buy() => new();

    public class Car
    {
        public List<string> Sponsors = new List<string>();

        public void SetSponsors(string[] SponsorsSet)
        {
            foreach (var x in SponsorsSet)
            {
                if (!Sponsors.Contains(x))
                {
                    Sponsors.Add(x);

                }
            }
        }

        public string DisplaySponsor(int i)
        {
            if (!(Sponsors.Count() >= i))
            {
                return "Index nao existe";
            }


            return Sponsors[i];
        }

    }
}