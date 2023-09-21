namespace UtmBuilder.Core;

public class InvalidCampaignException : Exception
{
    public const string DefaultErrorMessage = "Invalid UTM Parameters";

    public InvalidCampaignException(string message = DefaultErrorMessage) : base(message) { }

    public static void ThrowIfNull(string? item, string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}
