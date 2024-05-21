using Data.Data.Entities;

namespace Data.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
    protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
    {
        descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();

        descriptor.Field(x => x.Title).Type<StringType>();
        descriptor.Field(x => x.Ingress).Type<StringType>();
        descriptor.Field(x => x.Reviews).Type<StringType>();
        descriptor.Field(x => x.ImageUri).Type<StringType>();
        descriptor.Field(x => x.ImageHeaderUri).Type<StringType>();
        descriptor.Field(x => x.Categories).Type<ListType<StringType>>();

        descriptor.Field(x => x.StarRating).Type<DecimalType>();
        descriptor.Field(x => x.LikesInNumber).Type<DecimalType>();
        descriptor.Field(x => x.LikesInPercent).Type<DecimalType>();
        descriptor.Field(x => x.HoursToComplete).Type<DecimalType>();

        descriptor.Field(x => x.IsDigital).Type<BooleanType>();
        descriptor.Field(x => x.IsBestSeller).Type<BooleanType>();

        descriptor.Field(x => x.Authors).Type<ListType<AuthorType>>();
        descriptor.Field(x => x.Prices).Type<PriceType>();
        descriptor.Field(x => x.Content).Type<ContentType>();

        //descriptor.Field(x => x.Categories).Type<ListType<CategoryType>>();
    }
}


public class AuthorType : ObjectType<AuthorEntity>
{
    protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
    {
        descriptor.Field(x => x.AuthorName).Type<StringType>();
        //descriptor.Field(x => x.Id).Type<IntType>();
        //descriptor.Field(x => x.AuthorTitle).Type<StringType>();
        //descriptor.Field(x => x.AuthorDescription).Type<StringType>();
        //descriptor.Field(x => x.AuthorImageUrl).Type<StringType>();
        //descriptor.Field(x => x.FacebookSubs).Type<DecimalType>();
        //descriptor.Field(x => x.YoutubeSubs).Type<DecimalType>();
    }
}

public class PriceType : ObjectType<PricesEntity>
{
    protected override void Configure(IObjectTypeDescriptor<PricesEntity> descriptor)
    {
        descriptor.Field(x => x.Price).Type<DecimalType>();
        descriptor.Field(x => x.DiscountedPrice).Type<DecimalType>();
        descriptor.Field(x => x.Currency).Type<StringType>();
    }
}

//public class CategoryType : ObjectType<CategoryEntity>
//{
//    protected override void Configure(IObjectTypeDescriptor<CategoryEntity> descriptor)
//    {
//        descriptor.Field(x => x.CategoryName).Type<StringType>();
//    }
//}

public class ContentType : ObjectType<ContentEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ContentEntity> descriptor)
    {
        descriptor.Field(x => x.Description).Type<StringType>();
        descriptor.Field(x => x.Includes).Type<ListType<StringType>>();
        descriptor.Field(x => x.ProgramDetails).Type<ListType<StringType>>();
        descriptor.Field(x => x.LearnPoints).Type<ListType<StringType>>();
    }
}

public class ProgramDetailsType : ObjectType<ProgramDetailsEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ProgramDetailsEntity> descriptor)
    {
        descriptor.Field(x => x.Id).Type<IntType>();
        descriptor.Field(x => x.Description).Type<StringType>();
        descriptor.Field(x => x.Title).Type<StringType>();
    }
}