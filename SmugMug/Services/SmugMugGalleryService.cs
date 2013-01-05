// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase Florell
// Created          : 12-14-2012
//
// Last Modified By : Chase Florell
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="SmugMugService.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>
// This code file is licensed under the MIT License.
// http://opensource.org/licenses/MIT
// </summary>
// ***********************************************************************
namespace Infinitas.FeedModlr.SmugMug.Services
{
    using Infinitas.FeedModlr.SmugMug.Models;
    using Infinitas.FeedModlr.Utilities;
    using System;

    /// <summary>
    /// Class SmugMugService
    /// </summary>
    public class SmugMugGalleryService
    {

        /// <summary>
        /// The smugmug feed URL
        /// </summary>
        /// <remarks>Even though the feed examples on the smugmug website state
        /// that you can use "Atom", "KML", and "Open Search RSS", We're using
        /// the standard RSS feed since it delivers the most amount of useful
        /// information.</remarks>
        private const string SmugMugGalleryFeedUrl = "http://api.smugmug.com/hack/feed.mg?Type=gallery&Data={0}_{1}&format=rss";

        /// <summary>
        /// The smug mug recent galleries feed URL
        /// </summary>
        private const string SmugMugRecentGalleriesFeedUrl = "http://api.smugmug.com/hack/feed.mg?Type=nickname&Data={0}&format=rss";

        /// <summary>
        /// Gets the smug mug gallery.
        /// </summary>
        /// <typeparam name="T">Can be either <see cref="OriginalSmugMugGallery"/> or <see cref="SmugMugGallery"/></typeparam>
        /// <param name="smugMugAlbumId">The smug mug album id.</param>
        /// <param name="smugMugAlbumKey">The smug mug album key.</param>
        /// <returns>A populated model of either <see cref="OriginalSmugMugGallery"/> or <see cref="SmugMugGallery"/></returns>
        /// <remarks>The albumID and albumKey can be located by looking in your gallery's url string.  `&Data=[albumID]_[albumKey]`</remarks>
        /// <exception cref="System.Exception">Invalid Type specified, nothing to return.</exception>
        public T GetSmugMugGallery<T> (string smugMugAlbumId, string smugMugAlbumKey)
        {
            // Format the SmugMugFeedUrl with the appropriate input information
            var url = string.Format (
                SmugMugGalleryFeedUrl,
                smugMugAlbumId,
                smugMugAlbumKey);

            // Deserialize the RSS feed into an OriginalSmugMugGallery Model
            var originalGallery = XmlRssReader.Deserialize<OriginalSmugMugGallery> (url);

            // returns an OriginalSmugMugGallery if requested
            if (typeof(T) == typeof(OriginalSmugMugGallery)) {
                return (T)(object)originalGallery;
            }

            // Returns a SmugMugGallery if requested
            if (typeof(T) == typeof(SmugMugGallery)) {
                return (T)(object)MapSmugMugGalleries (originalGallery);
            }

            // If the request was anything but the above Types, throw an error.
            throw new Exception ("Invalid Type specified, nothing to return.");
        }

        /// <summary>
        /// Gets the smug mug gallery (<see cref="SmugMugGallery"/>).
        /// </summary>
        /// <returns> The smug mug gallery. </returns>
        /// <param name='smugMugAlbumId'> mug mug album identifier. </param>
        /// <param name='smugMugAlbumKey'> Smug mug album key. </param>
        public SmugMugGallery GetSmugMugGallery (string smugMugAlbumId, string smugMugAlbumKey)
        {
            return GetSmugMugGallery<SmugMugGallery>(smugMugAlbumId, smugMugAlbumKey);
        }
        
        /// <summary>
        /// Gets the smug mug image by GUID.
        /// </summary>
        /// <param name="smugMugAlbumId">The smug mug album id.</param>
        /// <param name="smugMugAlbumKey">The smug mug album key.</param>
        /// <param name="smugMugImageGuid">The smug mug image GUID.</param>
        /// <returns><see cref="SmugMugGallery.Image"/>.</returns>
        /// <exception cref="System.Exception">Unable to find an image associated with the specified Guid within the specified SmugMug Gallery.</exception>
        public SmugMugGallery.Image GetSmugMugGalleryImageByGuid (string smugMugAlbumId, string smugMugAlbumKey, string smugMugImageGuid)
        {

            // Grab all Images from the specified gallery
            var smGalleryImages = GetSmugMugGallery<SmugMugGallery> (smugMugAlbumId, smugMugAlbumKey).Images;

            // Loop through the images to find the one specified by the smugMugImageGuid
            foreach (var image in smGalleryImages) {
                if (smugMugImageGuid == image.Guid.ToString ()) {
                    return image;
                }
            }

            // Throw an error if an invalid image was specified
            throw new Exception ("Unable to find an image associated with the specified Guid within the specified SmugMug Gallery.");
        }

        public OriginalSmugMugGallery GetSmugMugRecentGalleries (string smugMugNickname)
        {
            var url = string.Format (
                SmugMugRecentGalleriesFeedUrl,
                smugMugNickname);

            return XmlRssReader.Deserialize<OriginalSmugMugGallery> (url);
        }


        /// <summary>
        /// Maps the smug mug galleries.
        /// </summary>
        /// <param name="originalSmugMugGallery">The original smug mug gallery.</param>
        /// <returns>SmugMugGallery.</returns>
        private static SmugMugGallery MapSmugMugGalleries (OriginalSmugMugGallery originalSmugMugGallery)
        {
            // generate a new Gallery Model
            var gallery = new SmugMugGallery {
                Title = originalSmugMugGallery.Channel.Title,
                Link = originalSmugMugGallery.Channel.Link,
                Description = originalSmugMugGallery.Channel.Description,
                Icon = originalSmugMugGallery.Channel.Icon,
                Category = originalSmugMugGallery.Channel.Category,
                PubDate = originalSmugMugGallery.Channel.PubDate,
                LastBuildDate = originalSmugMugGallery.Channel.LastBuildDate,
                Generator = originalSmugMugGallery.Channel.Generator,
                Copyright = originalSmugMugGallery.Channel.Copyright,
                GalleryImage = {
                    Url = originalSmugMugGallery.Channel.Image.Url,
                    Title = originalSmugMugGallery.Channel.Image.Title,
                    Link = originalSmugMugGallery.Channel.Image.Link
                },
                AtomLinks = {
                    Rel = originalSmugMugGallery.Channel.AtomLink.Rel,
                    Href = originalSmugMugGallery.Channel.AtomLink.Href,
                    Type = originalSmugMugGallery.Channel.AtomLink.Type
                }
            };

            // Create a new list of images and add them to the
            // List<SmugMugGallery.Images>();
            {
                foreach (var img in originalSmugMugGallery.Channel.Items) {

                    var image = new SmugMugGallery.Image {
                        Title = img.Title,
                        Link = img.Link,
                        Description = img.Description,
                        Category = img.Category,
                        PubDate = img.PubDate,
                        Author = img.Author,
                        Guid = { value = img.Guid.ToString(), isPermaLink = img.Guid.isPermaLink },
                        DateTimeOriginal = img.DateTimeOriginal,
                        Thumbnail = {
                            Url = img.Thumbnail.Url,
                            Width = img.Thumbnail.Width,
                            Height = img.Thumbnail.Height
                        },
                        Copyright = { value = img.Copyright.ToString(), Url = img.Copyright.Url },
                        Credit = { value = img.Credit.ToString(), Role = img.Credit.Role },
                        HtmlTitle = img.HtmlTitle,
                        Text = img.Text,
                        Keywords = img.Keywords
                    };

                    // Each image size needs to be created within the array
                    var imgType = new[]
                        {
                            image.TinyImage, 
                            image.ThumbnailImage, 
                            image.SmallImage, 
                            image.MediumImage, 
                            image.LargeImage,
                            image.ExtraLargeImage, 
                            image.TwoExtraLargeImage, 
                            image.ThreeExtraLargeImage,
                            image.OriginalImage,
                        };

                    // loop through the original image list and add them to the
                    // new image list. If the original list stops early because
                    // it doesn't contain images after a certain size. The
                    // remaining sizes in the new list will simply be null.
                    var count = 0;
                    foreach (var i in img.Group.Contents) {
                        imgType [count].Url = i.Url;
                        imgType [count].FileSize = i.FileSize;
                        imgType [count].Type = i.Type;
                        imgType [count].Medium = i.Medium;
                        imgType [count].Width = i.Width;
                        imgType [count].Height = i.Height;
                        imgType [count].Hash = i.Hash;
                        count++;
                    }

                    gallery.Images.Add (image);
                }
            }

            // Send back the completed gallery
            return gallery;
        }
    }
}
