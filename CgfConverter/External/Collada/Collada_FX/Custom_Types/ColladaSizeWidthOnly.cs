using System;
using System.Xml;
using System.Xml.Serialization;

namespace CgfConverter.Collada;

[Serializable]
[XmlType(AnonymousType = true)]
[XmlRootAttribute(ElementName = "size", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
public partial class ColladaSizeWidthOnly
{
    [XmlAttribute("width")]
    public int Width;
}

