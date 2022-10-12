namespace _Project._Scripts.DTO
{
    public class WithNameDto : IWithName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}
public interface IWithName
{
    int Id { get; set; }
    string Name { get; set; }
}