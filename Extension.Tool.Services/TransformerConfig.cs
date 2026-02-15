namespace Extension.Tool.Services;

public class TransformerConfig
{
    public readonly Dictionary<(Type,Type),Delegate> _customTransformers 
        = new Dictionary<(Type, Type),Delegate>();

    public void CreateTransformer<TSource, TDestination>(Func<TSource, TDestination> transformer)
    {
        _customTransformers[(typeof(TSource), typeof(TDestination))] = transformer;
    }
}