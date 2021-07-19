// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.ContentTypeHeader
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Text.
    /// </summary>
    public static partial class TextExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='text'>
            /// A text stream.
            /// </param>
            /// <param name='contentType'>
            /// The content type of the image. Possible values include: 'text/plain',
            /// 'text/json'
            /// </param>
            public static void A(this IText operations, Stream text, string contentType)
            {
                operations.AAsync(text, contentType).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='text'>
            /// A text stream.
            /// </param>
            /// <param name='contentType'>
            /// The content type of the image. Possible values include: 'text/plain',
            /// 'text/json'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AAsync(this IText operations, Stream text, string contentType, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AWithHttpMessagesAsync(text, contentType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='text'>
            /// A text stream.
            /// </param>
            /// <param name='contentType'>
            /// The content type of the image. Possible values include: 'text/plain',
            /// 'text/json'
            /// </param>
            public static void B(this IText operations, Stream text, string contentType = default(string))
            {
                operations.BAsync(text, contentType).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='text'>
            /// A text stream.
            /// </param>
            /// <param name='contentType'>
            /// The content type of the image. Possible values include: 'text/plain',
            /// 'text/json'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BAsync(this IText operations, Stream text, string contentType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BWithHttpMessagesAsync(text, contentType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}