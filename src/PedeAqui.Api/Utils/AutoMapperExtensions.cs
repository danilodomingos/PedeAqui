namespace PedeAqui.Api.Utils
{
    public static class AutoMapperExtensions
    {
        public static bool IsNotNull(this object srcMember)
        {
            var nonNull = srcMember != null;
            return nonNull;
        }
    }
}