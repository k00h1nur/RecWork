namespace Domain.Models.Infrastructure.StoreModels.Response;

using System.Text.Json.Serialization;

public record OlchaResponse(
    [property: JsonPropertyName("message")] string Message,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("data")] Data Data
);

public record Data(
    [property: JsonPropertyName("products")] List<Product> Products
);

public record Product(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name_en")] string Name_En,
    [property: JsonPropertyName("short_description_ru")] string Short_Description_Ru,
    [property: JsonPropertyName("short_description_uz")] string Short_Description_Uz,
    [property: JsonPropertyName("alias")] string Alias,
    [property: JsonPropertyName("inStock")] bool InStock,
    [property: JsonPropertyName("in_stock")] bool In_Stock,
    [property: JsonPropertyName("category")] Category Category,
    [property: JsonPropertyName("quantity")] int Quantity,
    [property: JsonPropertyName("status")] int Status,
    [property: JsonPropertyName("discount")] int Discount,
    [property: JsonPropertyName("discount_value")] string Discount_Value,
    [property: JsonPropertyName("discount_type")] string Discount_Type,
    [property: JsonPropertyName("discount_price")] int Discount_Price,
    [property: JsonPropertyName("cashback")] int Cashback,
    [property: JsonPropertyName("cashback_percent")] int Cashback_Percent,
    [property: JsonPropertyName("weight")] int Weight,
    [property: JsonPropertyName("warranty_month")] int Warranty_Month,
    [property: JsonPropertyName("has_installment")] int Has_Installment,
    [property: JsonPropertyName("recommended")] int Recommended,
    [property: JsonPropertyName("popular")] int Popular,
    [property: JsonPropertyName("new")] int New,
    [property: JsonPropertyName("sale")] int Sale,
    [property: JsonPropertyName("main_image")] string Main_Image,
    [property: JsonPropertyName("images")] List<string> Images,
    [property: JsonPropertyName("plan")] Plan Plan,
    [property: JsonPropertyName("product_type")] string Product_Type,
    [property: JsonPropertyName("parent_product")] int Parent_Product,
    [property: JsonPropertyName("is_main")] int Is_Main,
    [property: JsonPropertyName("for_adults")] int For_Adults,
    [property: JsonPropertyName("max_price")] int Max_Price,
    [property: JsonPropertyName("is_like")] bool Is_Like,
    [property: JsonPropertyName("is_white")] bool Is_White,
    [property: JsonPropertyName("is_compared")] bool Is_Compared,
    [property: JsonPropertyName("total_price")] string Total_Price,
    [property: JsonPropertyName("monthly_repayment")] int Monthly_Repayment,
    [property: JsonPropertyName("initial_fee")] int Initial_Fee,
    [property: JsonPropertyName("video_url")] string Video_Url,
    [property: JsonPropertyName("cart_count")] int Cart_Count,
    [property: JsonPropertyName("store_id")] int Store_Id,
    [property: JsonPropertyName("out_of_stock")] bool Out_Of_Stock,
    [property: JsonPropertyName("is_parent")] int Is_Parent,
    [property: JsonPropertyName("comments_rating")] string Comments_Rating,
    [property: JsonPropertyName("comments_count")] int Comments_Count,
    [property: JsonPropertyName("image_ratio")] string Image_Ratio
);

public record Category(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("parent_id")] int? Parent_Id,
    [property: JsonPropertyName("name_ru")] string Name_Ru,
    [property: JsonPropertyName("name_uz")] string Name_Uz,
    [property: JsonPropertyName("name_oz")] string Name_Oz,
    [property: JsonPropertyName("name_en")] string Name_En,
    [property: JsonPropertyName("alias")] string Alias,
    [property: JsonPropertyName("link")] string Link,
    [property: JsonPropertyName("main_image")] string Main_Image,
    [property: JsonPropertyName("webp_image")] string Webp_Image
);

public record Plan(
    [property: JsonPropertyName("margin")] string Margin,
    [property: JsonPropertyName("initial_fee")] int Initial_Fee,
    [property: JsonPropertyName("min_period")] string Min_Period,
    [property: JsonPropertyName("max_period")] string Max_Period,
    [property: JsonPropertyName("max_scoring")] string Max_Scoring,
    [property: JsonPropertyName("min_scoring")] string Min_Scoring
);