using System.Reflection;

namespace Extension.Tool.Services;

public class Transfomer : ITransformer
{
    private TransformerConfig _transformerConfig; 
    public Transfomer(TransformerConfig transformerConfig)
    {
        _transformerConfig = transformerConfig;
    }
    public TDestination Transform<TSource, TDestination>(TSource source) where TDestination : new()
    {
        if (_transformerConfig._customTransformers
            .TryGetValue((typeof(TSource), typeof(TDestination)), out var mapFunc))
        {
            return ((Func<TSource,TDestination>)mapFunc)(source);
        }
        
        TDestination destination = new TDestination();

        PropertyInfo [] sourceProps = typeof(TSource)
            .GetProperties();

        PropertyInfo[] destProps = typeof(TDestination)
            .GetProperties();

        foreach (var sourceProp in sourceProps)
        {
            PropertyInfo? destProp = destProps.
                FirstOrDefault(x => x.Name == sourceProp.Name &&
                                    x.PropertyType == sourceProp.PropertyType);
            if (destProp != null)
            {
                destProp.SetValue(destination,sourceProp.GetValue(source));
            }
        }

        return destination;
    }
}