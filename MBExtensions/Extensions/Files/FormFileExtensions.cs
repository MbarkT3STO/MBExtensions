using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MBXel_Core.Core.Units;
using MBXel_Core.Enums;
using Spire.Xls;
using Workbook = MBXel_Core.Core.Workbook;

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


        /// <summary>
        /// Get an <see cref="IFormFile"/> as an MBXelCore workbook
        /// </summary>
        /// <param name="file"><see cref="IFormFile"/> to be converted to MBXelCore <see cref="Workbook"/></param>
        /// <param name="extension">File extension</param>
        /// <param name="version">File version</param>
        /// <param name="password">Open password if the <see cref="IFormFile"/> workbook need</param>
        /// <returns></returns>
        public static Task<Workbook> ToMBXelCoreWorkbookAsync(this IFormFile file, XLExtension extension=XLExtension.Xlsx, ExcelVersion version= ExcelVersion.Version2016, string password=null)
        {
            return Task.Run( async () =>
                             {
                                 await using var ms = new MemoryStream();
                                 await file.CopyToAsync( ms );

                                 var workBookConfig = new WorkbookConfig()
                                                      {
                                                          Path      = file.Name ,
                                                          Password  = password ,
                                                          Extension = extension ,
                                                          Version   = version
                                                      };
                                 var workBook = new Workbook( workBookConfig );

                                 workBook.LoadFromStream( ms );

                                 return workBook;
                             } );
        }
        
        /// <summary>
        /// Get an <see cref="IFormFile"/> as an MBXelCore workbook
        /// </summary>
        /// <param name="file"><see cref="IFormFile"/> to be converted to MBXelCore <see cref="Workbook"/></param>
        /// <param name="config">The workbook configurations as an <see cref="WorkbookConfig"/> object</param>
        public static Task<Workbook> ToMBXelCoreWorkbookAsync(this IFormFile file, WorkbookConfig config)
        {
            return Task.Run( async () =>
                             {
                                 await using var ms = new MemoryStream();
                                 await file.CopyToAsync( ms );

                                 var workBook = new Workbook( config );
                                 workBook.LoadFromStream( ms );

                                 return workBook;
                             } );
        }
    }
}
