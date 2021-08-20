using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MBExtensions.Extensions.Files
{
    /// <summary>
    /// Responsible on <see cref="IFormFile"/>
    /// </summary>
    public static class FormFileExtensions
    {
        /// <summary>
        /// Transfer an <see cref="IFormFile"/> to an array of bytes
        /// </summary>
        /// <param name="file">The <see cref="IFormFile"/> to be transferred</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        public static async Task<byte[]> ToBytesAsync( this IFormFile file )
        {
            var stream = new MemoryStream();
            await file.CopyToAsync( stream );

            return stream.ToArray();
        }

        /// <summary>
        /// Check if an <see cref="IFormFile"/> has no content
        /// </summary>
        /// <param name="file">File to be checked</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNull( this IFormFile file ) => file == null;

        /// <summary>
        /// Check if an <see cref="IFormFile"/> has a content
        /// </summary>
        /// <param name="file">File to be checked</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNotNull( this IFormFile file ) => file != null;

        /// <summary>
        /// Asynchronously save an <see cref="IFormFile"/> object as a physical file
        /// </summary>
        /// <param name="file"><see cref="IFormFile"/> object to be saved</param>
        /// <param name="pathToSaveTo">Path to save to</param>
        /// <returns><see cref="Task"/></returns>
        public static Task SaveToAsync(this IFormFile file, string pathToSaveTo)
        {
            return Task.Factory.StartNew(() =>
            {
                using (Stream fileStream = File.Open(pathToSaveTo, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                {
                    file.CopyTo(fileStream);
                }

                //using (Stream fileStream = new FileStream(pathToSaveTo, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                //{
                //    file.CopyTo(fileStream);
                //}
            });
        }

        /// <summary>
        /// Get the extension of the current <see cref="IFormFile"/>
        /// </summary>
        /// <param name="file"><see cref="IFormFile"/> object to get the extension from</param>
        /// <returns><see cref="string"/></returns>
        public static string GetExtension(this IFormFile file)
        {
            return Path.GetExtension( file.FileName );
        }
    }
}
