using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickCV
{
    [XmlRoot("QuickCV")]
    public class QuickCVConfig
    {
        /// <summary>
        /// 詳細設定ファイル
        /// </summary>
        [XmlElement("SettingsFile")]
        public String SettingsFile { get; set; }
        /// <summary>
        /// OpenCVインストールパス
        /// </summary>
        [XmlElement("InstallPath")]
        public String InstallPath { get; set; }
        /// <summary>
        /// OpenCV Exeファイル名
        /// </summary>
        [XmlElement("ExeFile")]
        public ExeFileConfig ExeFile { get; set; }
    }

    public class ExeFileConfig
    {
        /// <summary>
        /// Annotation
        /// </summary>
        [XmlElement("Annotation")]
        public String Annotation { get; set; }
        /// <summary>
        /// Createsamples
        /// </summary>
        [XmlElement("Createsamples")]
        public String Createsamples { get; set; }
        /// <summary>
        /// Interactive
        /// </summary>
        [XmlElement("Interactive")]
        public String Interactive { get; set; }
        /// <summary>
        /// Traincascade
        /// </summary>
        [XmlElement("Traincascade")]
        public String Traincascade { get; set; }
        /// <summary>
        /// Visualisation
        /// </summary>
        [XmlElement("Visualisation")]
        public String Visualisation { get; set; }
    }
}
