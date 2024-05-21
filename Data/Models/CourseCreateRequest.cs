namespace Data.Models;

public class CourseCreateRequest
{
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public string? Reviews { get; set; }
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public string[]? Categories { get; set; }
    public decimal? StarRating { get; set; }
    public decimal? LikesInNumber { get; set; }
    public decimal? LikesInPercent { get; set; }
    public decimal HoursToComplete { get; set; }
    public bool IsDigital { get; set; }
    public bool IsBestSeller { get; set; }


    public virtual PriceCreateRequest? Prices { get; set; }
    public virtual List<AuthorCreateRequest>? Authors { get; set; }
    public virtual ContentCreateRequest? Content { get; set; }

    //public virtual List<CategoryCreateRequest>? Categories { get; set; }
}

//public class CategoryCreateRequest
//{
//    public string? CategoryName { get; set; }
//}

public class AuthorCreateRequest
{
    public string? AuthorName { get; set; }

    //public string? AuthorTitle { get; set; }
    //public string? AuthorImageUrl { get; set; }
    //public string? AuthorDescription { get; set; }
    //public decimal? YoutubeSubs { get; set; }
    //public decimal? FacebookSubs { get; set; }
}

public class PriceCreateRequest
{
    public decimal Price { get; set; }
    public decimal DiscountedPrice { get; set; }
    public string? Currency { get; set; }
}

public class ContentCreateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailsCreateRequest>? ProgramDetails { get; set; }
    public string[]? LearnPoints { get; set; }
}

public class ProgramDetailsCreateRequest
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}