using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WPCSharp.DesignPatterns.Structural.Facade.III
{
    public class ConverterFacade : IJsonConverter, IXmlConverter, IByteArrayConverter
    {
        private IJsonConverter _jsonCoverter;
        private IXmlConverter _xmlConverter;
        private IByteArrayConverter _byteArrayConveter;

        public ConverterFacade(IJsonConverter jsonCoverter, IXmlConverter xmlConverter, IByteArrayConverter byteArrayConverter)
        {
            _jsonCoverter = jsonCoverter;
            _xmlConverter = xmlConverter;
            _byteArrayConveter = byteArrayConverter;
        }

        public byte[] ToByteArray()
        {
            return _byteArrayConveter.ToByteArray();
        }

        public string ToJson()
        {
            return _jsonCoverter.ToJson();
        }

        public XDocument ToXml()
        {
            return _xmlConverter.ToXml();
        }
    }
}
