namespace Extension.Tool.Services;

public interface ITransformer
{
    TDestination Transform<TSource, TDestination>(TSource source) where TDestination : new();
}