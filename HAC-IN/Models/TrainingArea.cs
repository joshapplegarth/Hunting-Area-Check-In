namespace HAC_IN.Models
{
    public class TrainingArea
    {
        public int TAid { get; set; }
        public string TA { get; set; }
        public string region { get; set; }
        public int hunters { get; set; }
        public bool guided { get; set; }
        public int buckQuota { get; set; }
        public int doeQuota { get; set; }
        public bool rifle { get; set; }
        public bool shotgun { get; set; }
        public bool archery { get; set; }
    }
}
