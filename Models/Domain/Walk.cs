namespace webApi.Api.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifFicultyId { get; set; }

        public Region Region { get; set; }
        public WalkDifFiculty WalkDifFiculty { get; set; }
    }
}