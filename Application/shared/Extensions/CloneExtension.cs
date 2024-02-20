using System.Text.Json;

namespace Application.shared.Extensions
{
    public static class CloneExtension
    {
        public static T? DeepClone<T>(this T source) where T : class
        {

            try
            {
                var jsonString = JsonSerializer.Serialize(source, typeof(T));

                var cloned = JsonSerializer.Deserialize<T>(jsonString);

                return cloned;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
