using System.Reflection;

namespace Extension.Tool.Services;

public class TransfomerMapping : ITransformer
{
    public TDestination Transform<TSource, TDestination>(TSource source) where TDestination : new()
    {
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