namespace Servicio.Domain.Extensions
{
    public static class GenericExtensions
    {
        public static string GetTypeNameOfGeneric(this Type type)
        {
            var typeName = string.Empty;

            if (type.IsGenericType)
            {
                var genericTypes = string.Join(",", type.GetGenericArguments()
                    .Select(t => t.Name));
                typeName = $"{type.Name.Remove(type.Name.IndexOf('`'))}<{genericTypes}>";
            }
            else
            {
                typeName = type.Name;
            }

            return typeName;
        }

        public static string GetTypeNameOfGeneric(this object @object)
        {
            return @object.GetType().GetTypeNameOfGeneric();
        }
    }
}
