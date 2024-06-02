namespace Egitimproje.Models
{
    public static class Repositrory
    {
        private static List<Candidate> applications = new ();
        public static IEnumerable< Candidate> Applications => applications;

        public static void Add( Candidate candidate )
        {
            applications.Add( candidate );
        }
    }
}
