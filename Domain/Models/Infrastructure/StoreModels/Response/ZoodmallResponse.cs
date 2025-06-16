using System.Text.Json.Serialization;

namespace Domain.Models.Infrastructure.StoreModels.Response;

public class ZoodMallResponse
{
    [JsonPropertyName("marketList")]
    public List<ProductInnerZoodmall> MarketList { get; set; } = new();
}

public class ProductInnerZoodmall
{
   /* [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }  // Changed from string to int

    [JsonPropertyName("sponsorShopId")]
    public int SponsorShopId { get; set; }  // Changed from string to int   */

/*
    [JsonPropertyName("sponsorProductId")]
    public int SponsorProductId { get; set; }  // Changed from string to int
*/

/*
    [JsonPropertyName("categoryName")]
    public string CategoryName { get; set; } = string.Empty;
*/

    [JsonPropertyName("productId")]
    public int ProductId { get; set; }  // Changed from string to int

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /*[JsonPropertyName("localPrice")]
    public decimal LocalPrice { get; set; }*/

    [JsonPropertyName("imgUrl")]
    public string ImgUrl { get; set; } = string.Empty;

/*
    [JsonPropertyName("savePercentage")]
    public decimal SavePercentage { get; set; }
*/

    [JsonPropertyName("localCrossedPrice")]
    public decimal LocalCrossedPrice { get; set; }

/*
    [JsonPropertyName("isSecKill")]
    public int IsSecKill { get; set; }  // Changed from string to int
*/

  /*  [JsonPropertyName("sKillPrice")]
    public decimal SKillPrice { get; set; }

    [JsonPropertyName("sKillId")]
    public int SKillId { get; set; }  // Changed from string to int

    [JsonPropertyName("installment")]
    public Installment Installment { get; set; } = new();

    [JsonPropertyName("sellerCountry")]
    public string SellerCountry { get; set; } = string.Empty;

    [JsonPropertyName("sellerCnFlagImg")]
    public string SellerCnFlagImg { get; set; } = string.Empty;

    [JsonPropertyName("queryID")]
    public string QueryID { get; set; } = string.Empty;  */

    [JsonPropertyName("productPosition")]
    public int ProductPosition { get; set; }

    [JsonPropertyName("searchedIndex")]
    public string SearchedIndex { get; set; } = string.Empty;

    [JsonPropertyName("productIdentificationImg")]
    public string ProductIdentificationImg { get; set; } = string.Empty;

    [JsonPropertyName("totalLocalPrice")]
    public decimal TotalLocalPrice { get; set; }

    [JsonPropertyName("productTagLable")]
    public string ProductTagLable { get; set; } = string.Empty;

    [JsonPropertyName("productTagLableColor")]
    public string ProductTagLableColor { get; set; } = string.Empty;

    [JsonPropertyName("productTagBgColor")]
    public string ProductTagBgColor { get; set; } = string.Empty;

    // Note: Missing sellerId property from your original model - should match SellerId

   /* [JsonPropertyName("brandNameEn")]
    public string BrandNameEn { get; set; } = string.Empty;

    [JsonPropertyName("categoryNameEn")]
    public string CategoryNameEn { get; set; } = string.Empty;

    [JsonPropertyName("productNameEn")]
    public string ProductNameEn { get; set; } = string.Empty;

    [JsonPropertyName("sellerName")]
    public string SellerName { get; set; } = string.Empty;


    [JsonPropertyName("isVirtualProduct")]
    public bool IsVirtualProduct { get; set; }*/
}

/*public class VirtualProduct
{
    [JsonPropertyName("bgColor")]
    public string BgColor { get; set; } = string.Empty;

    [JsonPropertyName("bgBtnColor")]
    public string BgBtnColor { get; set; } = string.Empty;

    [JsonPropertyName("btnText")]
    public string BtnText { get; set; } = string.Empty;

    [JsonPropertyName("btnTextColor")]
    public string BtnTextColor { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("subTitle")]
    public string SubTitle { get; set; } = string.Empty;

    [JsonPropertyName("productImage")]
    public string ProductImage { get; set; } = string.Empty;

    [JsonPropertyName("deeplink")]
    public string Deeplink { get; set; } = string.Empty;
}

public class Installment
{
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("time")]
    public int Time { get; set; }

    [JsonPropertyName("installmentCountText")]
    public string InstallmentCountText { get; set; } = string.Empty;

    [JsonPropertyName("priceLayout")]
    public string PriceLayout { get; set; } = string.Empty;

    [JsonPropertyName("installmentAmountTxt")]
    public string InstallmentAmountTxt { get; set; } = string.Empty;

    [JsonPropertyName("installmentTimeTxt")]
    public string InstallmentTimeTxt { get; set; } = string.Empty;

    [JsonPropertyName("downPaymentAmountText")]
    public string DownPaymentAmountText { get; set; } = string.Empty;

    [JsonPropertyName("downPaymentAmount")]
    public decimal DownPaymentAmount { get; set; }

    [JsonPropertyName("payNowText")]
    public string PayNowText { get; set; } = string.Empty;

    [JsonPropertyName("payLaterText")]
    public string PayLaterText { get; set; } = string.Empty;

    [JsonPropertyName("downPaymentAmountTextNew")]
    public string DownPaymentAmountTextNew { get; set; } = string.Empty;

    [JsonPropertyName("noOfInstallmentText")]
    public string NoOfInstallmentText { get; set; } = string.Empty;
}*/