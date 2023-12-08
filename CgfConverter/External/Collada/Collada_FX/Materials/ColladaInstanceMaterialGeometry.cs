using System;
using System.Xml;
using System.Xml.Serialization;
namespace CgfConverter.Collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "instance_material", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
    public partial class ColladaInstanceMaterialGeometry
    {
        [XmlAttribute("sid")]
        public string sID;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("target")]
        public string Target;

        [XmlAttribute("symbol")]
        public string Symbol;

        [XmlElement(ElementName = "bind")]
        public ColladaBindFX[] Bind;

        [XmlElement(ElementName = "bind_vertex_input")]
        public ColladaBindVertexInput[] Bind_Vertex_Input;

        [XmlElement(ElementName = "extra")]
        public ColladaExtra[] Extra;
    }
}

