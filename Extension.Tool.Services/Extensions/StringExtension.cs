namespace Extension.Tool.Services.Extensions;

public static class StringExtension
{
    extension(string value)
    {
        public string? ToRemoveWhiteSpace()
            => new (value?.Where(c => !char.IsWhiteSpace(c)) != null ? value.Where(c => !char.IsWhiteSpace(c)).ToArray() : null);
    }
}