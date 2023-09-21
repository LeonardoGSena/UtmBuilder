namespace UtmBuilder.Core;

public class Campaign : ValueObject
{
    /// <summary>
    /// Generate a new campaign for a URL
    /// </summary>
    /// <param name="source">The Referrer (e.g. google, newsletters)</param>
    /// <param name="medium">Marketing medium (e.g. cpc, banner, email)</param>
    /// <param name="name">Product, promo code, or slogan(e.g. srpring_sale)</param>
    /// <param name="id">The ads campaign id</param>
    /// <param name="term">Identity the paid keywords ads</param>
    /// <param name="content">Use to differentiate</param>
    public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfNull(source, "Source is invalid");
        InvalidCampaignException.ThrowIfNull(medium, "Medium is invalid");
        InvalidCampaignException.ThrowIfNull(name, "Name is invalid");
    }
    /// <summary>
    /// The Referrer (e.g. google, newsletters)
    /// </summary>
    public string Source { get; }

    /// <summary>
    /// Marketing medium (e.g. cpc, banner, email)
    /// </summary>
    public string Medium { get; }

    /// <summary>
    /// Product, promo code, or slogan(e.g. srpring_sale)
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The ads campaign id.
    /// </summary>
    public string? Id { get; }

    /// <summary>
    /// Identity the paid keywords
    /// </summary>
    public string? Term { get; }

    /// <summary>
    /// Use to differentiate ads
    /// </summary>
    public string? Content { get; }
}
