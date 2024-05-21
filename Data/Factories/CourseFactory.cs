using Data.Data.Entities;
using Data.Models;

namespace Data.Factories;

public class CourseFactory
{
    public static CourseEntity Create(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            Title = request.Title,
            Ingress = request.Ingress,
            StarRating = request.StarRating,
            Reviews = request.Reviews,
            Categories = request.Categories,
            LikesInNumber = request.LikesInNumber,
            LikesInPercent = request.LikesInPercent,
            HoursToComplete = request.HoursToComplete,
            ImageUri = request.ImageUri,
            ImageHeaderUri = request.ImageHeaderUri,
            IsDigital = request.IsDigital,
            IsBestSeller = request.IsBestSeller,

            Authors = request.Authors?.Select(x => new AuthorEntity
            {
                AuthorName = x.AuthorName,

            }).ToList(),

            Prices = request.Prices == null ? null : new PricesEntity
            {
                Price = request.Prices.Price,
                DiscountedPrice = request.Prices.DiscountedPrice,
                Currency = request.Prices.Currency,
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                Description = request.Content.Description,
                Includes = request.Content.Includes,
                LearnPoints = request.Content.LearnPoints,
                ProgramDetails = request.Content.ProgramDetails?.Select(x => new ProgramDetailsEntity
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                }).ToList(),
            },

        };
    }


    public static CourseEntity Create(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            Id = request.Id,
            Title = request.Title,
            Ingress = request.Ingress,
            StarRating = request.StarRating,
            Reviews = request.Reviews,
            Categories = request.Categories,
            LikesInNumber = request.LikesInNumber,
            LikesInPercent = request.LikesInPercent,
            HoursToComplete = request.HoursToComplete,
            ImageUri = request.ImageUri,
            ImageHeaderUri = request.ImageHeaderUri,
            IsDigital = request.IsDigital,
            IsBestSeller = request.IsBestSeller,

            Authors = request.Authors?.Select(x => new AuthorEntity
            {
                AuthorName = x.AuthorName,
            }).ToList(),

            Prices = request.Prices == null ? null : new PricesEntity
            {
                Price = request.Prices.Price,
                DiscountedPrice = request.Prices.DiscountedPrice,
                Currency = request.Prices.Currency,
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                Description = request.Content.Description,
                Includes = request.Content.Includes,
                LearnPoints = request.Content.LearnPoints,
                ProgramDetails = request.Content.ProgramDetails?.Select(x => new ProgramDetailsEntity
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                }).ToList(),
            },
        };
    }


    public static Course Create(CourseEntity entity)
    {
        return new Course
        {
            Id = entity.Id,
            Title = entity.Title,
            Ingress = entity.Ingress,
            StarRating = entity.StarRating,
            Reviews = entity.Reviews,
            Categories = entity.Categories,
            LikesInNumber = entity.LikesInNumber,
            LikesInPercent = entity.LikesInPercent,
            HoursToComplete = entity.HoursToComplete,
            ImageUri = entity.ImageUri,
            ImageHeaderUri = entity.ImageHeaderUri,
            IsDigital = entity.IsDigital,
            IsBestSeller = entity.IsBestSeller,

            Authors = entity.Authors?.Select(x => new Authors
            {
                AuthorName = x.AuthorName,
            }).ToList(),

            Prices = entity.Prices == null ? null : new Prices
            {
                Price = entity.Prices.Price,
                DiscountedPrice = entity.Prices.DiscountedPrice,
                Currency = entity.Prices.Currency,
            },
            Content = entity.Content == null ? null : new Content
            {
                Description = entity.Content.Description,
                Includes = entity.Content.Includes,
                LearnPoints = entity.Content.LearnPoints,
                ProgramDetails = entity.Content.ProgramDetails?.Select(x => new ProgramDetails
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                }).ToList(),
            },
        };
    }
}
