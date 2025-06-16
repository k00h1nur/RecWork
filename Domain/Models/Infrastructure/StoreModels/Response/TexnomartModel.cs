namespace Domain.Models.Infrastructure.StoreModels.Response;

using System.Text.Json.Serialization;

public class TexnomartResponse
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("data")]
    public TexnomartData Data { get; set; }
}

public class TexnomartData
{
    [JsonPropertyName("pagination")]
    public TexnomartPagination Pagination { get; set; }

    [JsonPropertyName("products")]
    public List<TexnomartProduct> Products { get; set; }
}

public class TexnomartPagination
{
    [JsonPropertyName("current_page")]
    public int Current_Page { get; set; }

    [JsonPropertyName("page_size")]
    public int Page_Size { get; set; }

    [JsonPropertyName("total_count")]
    public int Total_Count { get; set; }

    [JsonPropertyName("total_page")]
    public int Total_Page { get; set; }
}

public class TexnomartProduct
{
    [JsonPropertyName("all_count")]
    public int All_Count { get; set; }

    [JsonPropertyName("availability")]
    public string Availability { get; set; }

    [JsonPropertyName("axiom_monthly_price")]
    public string Axiom_Monthly_Price { get; set; }

    [JsonPropertyName("benefit")]
    public int Benefit { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("discount")]
    public int Discount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("is_can_loan_order")]
    public int Is_Can_Loan_Order { get; set; }

    [JsonPropertyName("main_characters")]
    public List<TexnomartMainCharacter> Main_Characters { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("old_price")]
    public int Old_Price { get; set; }

    [JsonPropertyName("reviews_average")]
    public double? Reviews_Average { get; set; }

    [JsonPropertyName("reviews_count")]
    public int Reviews_Count { get; set; }

    [JsonPropertyName("sale_months")]
    public List<object> Sale_Months { get; set; }

    [JsonPropertyName("sale_price")]
    public int Sale_Price { get; set; }

    [JsonPropertyName("stickers")]
    public List<TexnomartSticker> Stickers { get; set; }
}

public class TexnomartMainCharacter
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class TexnomartSticker
{
    [JsonPropertyName("background_color")]
    public string Background_Color { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("is_image")]
    public bool Is_Image { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("text_color")]
    public string Text_Color { get; set; }
}