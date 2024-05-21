using System.ComponentModel.DataAnnotations;

namespace Data.Data.Entities;

public class CourseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public string? Reviews { get; set; }
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public string[]? Categories { get; set; }
    public decimal? StarRating { get; set; }
    public decimal? LikesInNumber { get; set; }
    public decimal? LikesInPercent { get; set; }
    public decimal? HoursToComplete { get; set; }
    public bool IsDigital { get; set; }
    public bool IsBestSeller { get; set; }


    public virtual PricesEntity? Prices { get; set; }
    public virtual List<AuthorEntity>? Authors { get; set; }
    public virtual ContentEntity? Content { get; set; }
    //public virtual List<CategoryEntity>? Categories { get; set; }
}

//public class CategoryEntity
//{
//    public int Id { get; set; }
//    public string? CategoryName { get; set; }
//}

public class AuthorEntity
{
    public string? AuthorName { get; set; }
    //public int Id { get; set; }
    //public string? AuthorTitle { get; set; }
    //public string? AuthorImageUrl { get; set; }
    //public string? AuthorDescription { get; set; }
    //public decimal? YoutubeSubs { get; set; }
    //public decimal? FacebookSubs { get; set; }
}

public class PricesEntity
{
    public decimal Price { get; set; }
    public decimal DiscountedPrice { get; set; }
    public string? Currency { get; set; }
}

public class ContentEntity
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailsEntity>? ProgramDetails { get; set; }
    public string[]? LearnPoints { get; set; }
}

public class ProgramDetailsEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}