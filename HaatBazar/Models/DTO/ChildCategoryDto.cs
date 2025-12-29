namespace HaatBazar.Models.DTO
{
    public class ChildCategoryDto
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string imageName { get; set; } = string.Empty;
        public int ChildCategoryId { get; set; }
        public string ChildCategoryName { get; set; } = string.Empty;
    }

}
