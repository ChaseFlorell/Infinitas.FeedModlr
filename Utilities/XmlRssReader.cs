// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase Florell
// Created          : 12-14-2012
//
// Last Modified By : Chase Florell
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="XmlRssReader.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>
// This code file is licensed under the MIT License.
// http://opensource.org/licenses/MIT
// </summary>
// ***********************************************************************
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
    public class XmlRssReader
    {
        /// <summary>
        /// Deserializes the specified XML URI.
        /// </summary>
        /// <typeparam name="T">Model object used for deserialization</typeparam>
        /// <param name="xmlUri">The XML URI.</param>
        /// <returns>``0.</returns>
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
