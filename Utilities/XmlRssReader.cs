namespace Infinitas.FeedModlr.Utilities
{
    #region usings

    using System.IO;
    using System.Net;
    using System.Text;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    /// Utility used to manage XML deserialization
    /// </summary>
    /// <remarks></remarks>
    public class XmlRssReader
    {
        /// <summary>
        /// Deserializes the specified XML from a URI.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlUri">The XML URI.</param>
        /// <returns>An object deserialized as T</returns>
        /// <remarks></remarks>
        public static T Deserialize<T>(string xmlUri)
        {
            var wc = new WebClient();
            var result = wc.DownloadString(xmlUri);

            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                var obj = (T)xmlSerializer.Deserialize(memoryStream);
                return obj;
            }
        }
    }
}
