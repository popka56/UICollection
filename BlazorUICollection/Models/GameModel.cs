namespace BlazorUICollection.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public string Type { get; set; }
        public string System { get; set; }
        public bool Completionist { get; set; }
        public DateTime? FirstPlayed { get; set; }
        public DateTime? FirstFinished { get; set; }
        public int TotalReplays { get; set; }
        public string Status { get; set; }
        public bool HallOfFame { get; set; }
    }
}
