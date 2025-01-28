namespace API.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string GolfTournament { get; set; }
        public int Round1 { get; set; }
        public int Roun21 { get; set; }
        public int Round3 { get; set; }
        public int Round4 { get; set; }
        public int TotalPoints { get; set; }

        public int PlayerId { get; set; }

        public Result()
        {
        }

        public Result(string sor)
        {
            string[] adatok = sor.Split(';');
            GolfTournament = adatok[0];
            Round1 = Convert.ToInt32(adatok[2]);
            Roun21 = Convert.ToInt32(adatok[3]);
            Round3 = Convert.ToInt32(adatok[4]);
            Round4 = Convert.ToInt32(adatok[5]);
            TotalPoints = Round1 + Roun21 + Round3 + Round4;
            PlayerId = Convert.ToInt32(adatok[1]);
        }
    }
}
