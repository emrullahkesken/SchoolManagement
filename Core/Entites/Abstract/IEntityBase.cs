namespace Core.Entites.Abstract
{
    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
        DateTime DeletedDate { get; set; }
    }
}
