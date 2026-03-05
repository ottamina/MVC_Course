
// bu sınıf, başvuru yapan adayların bilgilerini saklamak için basit bir repository görevi görür.
namespace BTKAkademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
    
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}