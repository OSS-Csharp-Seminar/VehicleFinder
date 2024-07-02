namespace VehicleFinder.Entities.BaseEntity
{
    public abstract class BEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
