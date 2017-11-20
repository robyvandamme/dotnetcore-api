// <auto-generated>

namespace Swagger.Public
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublicAdventureAPI.
    /// </summary>
    public static partial class PublicAdventureAPIExtensions
    {
            /// <summary>
            /// Get a list of products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// Search for values within the product name, for instance &lt;b&gt;bike
            /// stand&lt;/b&gt; or &lt;b&gt;mountain&lt;/b&gt;
            /// </param>
            /// <param name='color'>
            /// One or more colors to filter on, for instance &lt;b&gt;black&lt;/b&gt; or
            /// &lt;b&gt;black, blue&lt;/b&gt;
            /// </param>
            /// <param name='orderBy'>
            /// By default the results are ordered by &lt;b&gt;name (ascending)&lt;/b&gt;
            /// You can order by &lt;b&gt;color, color desc, color asc, name, name asc,
            /// name desc&lt;/b&gt; or a combination.
            /// </param>
            /// <param name='fields'>
            /// The fields you want to see in the results. For instance &lt;b&gt;id, name,
            /// color&lt;/b&gt;
            /// </param>
            /// <param name='pageNumber'>
            /// Default = 1.
            /// </param>
            /// <param name='pageSize'>
            /// Default = 10. Maximum = 20.
            /// </param>
            public static IList<Product> ApiPublicProductsGet(this IPublicAdventureAPI operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), string fields = default(string), int? pageNumber = default(int?), int? pageSize = default(int?))
            {
                return operations.ApiPublicProductsGetAsync(searchQuery, color, orderBy, fields, pageNumber, pageSize).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// Search for values within the product name, for instance &lt;b&gt;bike
            /// stand&lt;/b&gt; or &lt;b&gt;mountain&lt;/b&gt;
            /// </param>
            /// <param name='color'>
            /// One or more colors to filter on, for instance &lt;b&gt;black&lt;/b&gt; or
            /// &lt;b&gt;black, blue&lt;/b&gt;
            /// </param>
            /// <param name='orderBy'>
            /// By default the results are ordered by &lt;b&gt;name (ascending)&lt;/b&gt;
            /// You can order by &lt;b&gt;color, color desc, color asc, name, name asc,
            /// name desc&lt;/b&gt; or a combination.
            /// </param>
            /// <param name='fields'>
            /// The fields you want to see in the results. For instance &lt;b&gt;id, name,
            /// color&lt;/b&gt;
            /// </param>
            /// <param name='pageNumber'>
            /// Default = 1.
            /// </param>
            /// <param name='pageSize'>
            /// Default = 10. Maximum = 20.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Product>> ApiPublicProductsGetAsync(this IPublicAdventureAPI operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), string fields = default(string), int? pageNumber = default(int?), int? pageSize = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsGetWithHttpMessagesAsync(searchQuery, color, orderBy, fields, pageNumber, pageSize, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a single product
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// A Guid
            /// </param>
            public static Product ApiPublicProductsByIdGet(this IPublicAdventureAPI operations, System.Guid id)
            {
                return operations.ApiPublicProductsByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single product
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// A Guid
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> ApiPublicProductsByIdGetAsync(this IPublicAdventureAPI operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of product models
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiPublicProductsModelsGet(this IPublicAdventureAPI operations)
            {
                return operations.ApiPublicProductsModelsGetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of product models
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiPublicProductsModelsGetAsync(this IPublicAdventureAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsModelsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of product colors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiPublicProductsColorsGet(this IPublicAdventureAPI operations)
            {
                return operations.ApiPublicProductsColorsGetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of product colors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiPublicProductsColorsGetAsync(this IPublicAdventureAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsColorsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of product categories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiPublicProductsCategoriesGet(this IPublicAdventureAPI operations)
            {
                return operations.ApiPublicProductsCategoriesGetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of product categories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiPublicProductsCategoriesGetAsync(this IPublicAdventureAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsCategoriesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}