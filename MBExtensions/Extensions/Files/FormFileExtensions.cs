using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MBExtensions.Extensions.Files
{
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
    }
}
