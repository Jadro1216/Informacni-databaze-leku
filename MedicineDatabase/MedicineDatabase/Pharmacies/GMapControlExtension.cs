using GMap.NET.WindowsForms;

namespace MedicineDatabase.Pharmacies
{
    public static class GMapControlExtension
    {
        public static void RefreshMap(this GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
    }
}
