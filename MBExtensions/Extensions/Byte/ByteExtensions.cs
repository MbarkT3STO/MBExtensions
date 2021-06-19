using System;
using System.Threading.Tasks;

namespace MBExtensions.Extensions.Byte
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Convrt a <see cref="byte"/> array to <b>base64</b> as <see cref="string"/> format
        /// </summary>
        /// <param name="bytes">Bytes to be converted</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        public static Task<string> ToBase64Async( this byte[] bytes ) => Task.Factory.StartNew( () => Convert.ToBase64String( bytes ) );

        /// <summary>
        /// Check if a <see cref="byte"/> array if null or empty
        /// </summary>
        /// <param name="bytes">Bytes array to be checked</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        public static Task<bool> IsNullOrEmptyAsync( this byte[] bytes ) => Task.Factory.StartNew( () => bytes == null || bytes.Length == 0 );

        /// <summary>
        /// Check if a <see cref="byte"/> array if not null or empty
        /// </summary>
        /// <param name="bytes">Bytes array to be checked</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        public static Task<bool> IsNotNullOrEmptyAsync( this byte[] bytes ) => Task.Factory.StartNew( () => bytes != null && bytes.Length > 0 );
    }
}