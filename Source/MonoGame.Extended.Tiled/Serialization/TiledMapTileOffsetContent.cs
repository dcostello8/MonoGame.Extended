using System.Xml.Serialization;

namespace MonoGame.Extended.Tiled.Serialization
{
    [XmlRoot(ElementName = "tileoffset")]
    public class TiledMapTileOffsetContent
    {
        [XmlAttribute(AttributeName = "x")] public int X;

        [XmlAttribute(AttributeName = "y")] public int Y;

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}