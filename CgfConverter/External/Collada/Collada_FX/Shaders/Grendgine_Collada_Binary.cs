using System;
using System.Xml;
using System.Xml.Serialization;
namespace CgfConverter.Collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "binary", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
    public partial class Grendgine_Collada_Binary
    {
        [XmlElement(ElementName = "ref")]
        public string Ref;

        [XmlElement(ElementName = "hex")]
        public ColladaHex Hex;
    }
}

