using Schnellerfassung.Classes;
using SchnellerfassungShared.Classes;

namespace Schnellerfassung
{
    internal static class AreaExtension
    {
        public static AreaDTO ToDTO(Area area)
        {
            return new AreaDTO { Name = area.Name, Nummernkreis = area.Nummernkreis };
        }

        public static void ToViewObject(AreaDTO dto)
        {
            return new AreaViewObject { dto };
        }
    }
}
