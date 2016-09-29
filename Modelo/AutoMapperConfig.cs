using AutoMapper;
using System.Xml.Linq;
using CapaInterfaces.Modelo;

namespace Modelo
{
    internal class AutoMapperConfig
    {
        public static void ObtenerProtocoloDeXml(XElement pXml)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<XElement, IProtocoloDTO>());

            Mapper.Map<XElement, IProtocoloDTO>(pXml);
        }
    }
}
