namespace StringSplit_StringJoin;

public static class StringsTransformator
{
    public static string TransformSeparator(string input, string originalSeparator, string targetSeparator)
    {
        var splitInput = input.Split(originalSeparator);
        return string.Join(targetSeparator, splitInput);
    }
}