// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Swagger
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DotnetcoreApiv1.
    /// </summary>
    public static partial class DotnetcoreApiv1Extensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// </param>
            /// <param name='color'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            public static IList<Product> ApiAdminProductsGet(this IDotnetcoreApiv1 operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), int? pageNumber = default(int?), int? pageSize = default(int?))
            {
                return operations.ApiAdminProductsGetAsync(searchQuery, color, orderBy, pageNumber, pageSize).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// </param>
            /// <param name='color'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Product>> ApiAdminProductsGetAsync(this IDotnetcoreApiv1 operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), int? pageNumber = default(int?), int? pageSize = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAdminProductsGetWithHttpMessagesAsync(searchQuery, color, orderBy, pageNumber, pageSize, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// </param>
            public static object ApiAdminProductsPost(this IDotnetcoreApiv1 operations, CreateProduct product = default(CreateProduct))
            {
                return operations.ApiAdminProductsPostAsync(product).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiAdminProductsPostAsync(this IDotnetcoreApiv1 operations, CreateProduct product = default(CreateProduct), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAdminProductsPostWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static AdminProduct ApiAdminProductsByIdGet(this IDotnetcoreApiv1 operations, System.Guid id)
            {
                return operations.ApiAdminProductsByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdminProduct> ApiAdminProductsByIdGetAsync(this IDotnetcoreApiv1 operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAdminProductsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='product'>
            /// </param>
            public static IDictionary<string, ModelStateEntry> ApiAdminProductsByIdPut(this IDotnetcoreApiv1 operations, System.Guid id, UpdateProduct product = default(UpdateProduct))
            {
                return operations.ApiAdminProductsByIdPutAsync(id, product).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='product'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, ModelStateEntry>> ApiAdminProductsByIdPutAsync(this IDotnetcoreApiv1 operations, System.Guid id, UpdateProduct product = default(UpdateProduct), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAdminProductsByIdPutWithHttpMessagesAsync(id, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiAdminProductsByIdDelete(this IDotnetcoreApiv1 operations, System.Guid id)
            {
                operations.ApiAdminProductsByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiAdminProductsByIdDeleteAsync(this IDotnetcoreApiv1 operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiAdminProductsByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='patchProduct'>
            /// </param>
            public static IDictionary<string, ModelStateEntry> ApiAdminProductsByIdPatch(this IDotnetcoreApiv1 operations, System.Guid id, IList<Operation> patchProduct = default(IList<Operation>))
            {
                return operations.ApiAdminProductsByIdPatchAsync(id, patchProduct).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='patchProduct'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, ModelStateEntry>> ApiAdminProductsByIdPatchAsync(this IDotnetcoreApiv1 operations, System.Guid id, IList<Operation> patchProduct = default(IList<Operation>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAdminProductsByIdPatchWithHttpMessagesAsync(id, patchProduct, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Product ApiIntegrationCacheByIdGet(this IDotnetcoreApiv1 operations, string id)
            {
                return operations.ApiIntegrationCacheByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> ApiIntegrationCacheByIdGetAsync(this IDotnetcoreApiv1 operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiIntegrationCacheByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiIntegrationCacheByIdDelete(this IDotnetcoreApiv1 operations, string id)
            {
                operations.ApiIntegrationCacheByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiIntegrationCacheByIdDeleteAsync(this IDotnetcoreApiv1 operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiIntegrationCacheByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// </param>
            public static void ApiIntegrationCachePost(this IDotnetcoreApiv1 operations, Product product = default(Product))
            {
                operations.ApiIntegrationCachePostAsync(product).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiIntegrationCachePostAsync(this IDotnetcoreApiv1 operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiIntegrationCachePostWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Product ApiIntegrationErrorsGet(this IDotnetcoreApiv1 operations)
            {
                return operations.ApiIntegrationErrorsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> ApiIntegrationErrorsGetAsync(this IDotnetcoreApiv1 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiIntegrationErrorsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ApiIntegrationIdentityGet(this IDotnetcoreApiv1 operations)
            {
                operations.ApiIntegrationIdentityGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiIntegrationIdentityGetAsync(this IDotnetcoreApiv1 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiIntegrationIdentityGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// </param>
            /// <param name='color'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            public static IList<Product> ApiPublicProductsGet(this IDotnetcoreApiv1 operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), int? pageNumber = default(int?), int? pageSize = default(int?))
            {
                return operations.ApiPublicProductsGetAsync(searchQuery, color, orderBy, pageNumber, pageSize).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchQuery'>
            /// </param>
            /// <param name='color'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Product>> ApiPublicProductsGetAsync(this IDotnetcoreApiv1 operations, string searchQuery = default(string), string color = default(string), string orderBy = default(string), int? pageNumber = default(int?), int? pageSize = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsGetWithHttpMessagesAsync(searchQuery, color, orderBy, pageNumber, pageSize, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Product ApiPublicProductsByIdGet(this IDotnetcoreApiv1 operations, System.Guid id)
            {
                return operations.ApiPublicProductsByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> ApiPublicProductsByIdGetAsync(this IDotnetcoreApiv1 operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicProductsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiPublicValuesGet(this IDotnetcoreApiv1 operations)
            {
                return operations.ApiPublicValuesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiPublicValuesGetAsync(this IDotnetcoreApiv1 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiPublicValuesPost(this IDotnetcoreApiv1 operations, string value = default(string))
            {
                operations.ApiPublicValuesPostAsync(value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiPublicValuesPostAsync(this IDotnetcoreApiv1 operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiPublicValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiPublicValuesByIdGet(this IDotnetcoreApiv1 operations, int id)
            {
                return operations.ApiPublicValuesByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiPublicValuesByIdGetAsync(this IDotnetcoreApiv1 operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiPublicValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiPublicValuesByIdPut(this IDotnetcoreApiv1 operations, int id, string value = default(string))
            {
                operations.ApiPublicValuesByIdPutAsync(id, value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiPublicValuesByIdPutAsync(this IDotnetcoreApiv1 operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiPublicValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiPublicValuesByIdDelete(this IDotnetcoreApiv1 operations, int id)
            {
                operations.ApiPublicValuesByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiPublicValuesByIdDeleteAsync(this IDotnetcoreApiv1 operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiPublicValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
