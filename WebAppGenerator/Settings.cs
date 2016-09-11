using System.Collections.Generic;
using System.Xml;

namespace WebAppGenerator
{
    public class Settings
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        public void LoadSettings( string xmlFileName )
        {
            string sCurrentSettingElement = "";
            string sCurrentSettingValue = "";

            XmlTextReader xmlReader = new XmlTextReader( xmlFileName );
            while ( xmlReader.Read() )
            {
                switch ( xmlReader.NodeType )
                {
                    case XmlNodeType.Element:
                        sCurrentSettingElement = xmlReader.Name;
                        break;
                    case XmlNodeType.Text:
                        sCurrentSettingValue = xmlReader.Value;
                        break;
                    case XmlNodeType.EndElement:
                        // Only load leaf nodes.
                        if ( !string.IsNullOrWhiteSpace( sCurrentSettingElement ) )
                        {
                            settings.Add( sCurrentSettingElement, sCurrentSettingValue );
                        }
                        sCurrentSettingElement = "";
                        sCurrentSettingValue = "";
                        break;
                }
            }
        }

        public string GetSettingValue( string settingKey )
        {
            string settingValue;
            bool keyFound = settings.TryGetValue( settingKey, out settingValue );
            if ( keyFound )
            {
                return settingValue;
            }

            return null;
        }

    }
}
