using GeometryLibrary.Enums;

namespace GeometryLibrary.Models
{
    public class Shape
    {
        public ShapeType Type { get; set; }
        public required object Data { get; set; }
    }
}
