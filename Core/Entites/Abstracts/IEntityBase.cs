namespace Core.Entites.Abstracts
{
    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
