﻿using NuGet.Versioning;

namespace BaGet.Core
{
    /// <summary>
    /// Used to create URLs to resources in the NuGet protocol.
    /// </summary>
    public interface IUrlGenerator
    {
        /// <summary>
        /// Get the URL for the root of the package content resource.
        /// See: https://docs.microsoft.com/en-us/nuget/api/package-base-address-resource
        /// </summary>
        string GetPackageContentResourceUrl();

        /// <summary>
        /// Get the URL for the root of the package metadata resource.
        /// See: https://docs.microsoft.com/en-us/nuget/api/registration-base-url-resource
        /// </summary>
        string GetPackageMetadataResourceUrl();

        /// <summary>
        /// Get the URL to publish packages.
        /// See: https://docs.microsoft.com/en-us/nuget/api/package-publish-resource
        /// </summary>
        string GetPackagePublishResourceUrl();

        /// <summary>
        /// Get the URL to search for packages.
        /// See: https://docs.microsoft.com/en-us/nuget/api/search-query-service-resource
        /// </summary>
        string GetSearchResourceUrl();

        /// <summary>
        /// Get the URL for the entry point of a package's metadata.
        /// See: https://docs.microsoft.com/en-us/nuget/api/registration-base-url-resource#registration-index
        /// </summary>
        /// <param name="id">The package's ID.</param>
        string GetRegistrationIndexUrl(string id);

        /// <summary>
        /// Get the URL for the metadata of a specific package ID and version.
        /// See: https://docs.microsoft.com/en-us/nuget/api/registration-base-url-resource#registration-leaf
        /// </summary>
        /// <param name="id">The package's ID</param>
        /// <param name="version">The package's version</param>
        string GetRegistrationLeafUrl(string id, NuGetVersion version);

        /// <summary>
        /// Get the URL to download a package (.nupkg).
        /// See: https://docs.microsoft.com/en-us/nuget/api/package-base-address-resource#download-package-content-nupkg
        /// </summary>
        /// <param name="id">The package's ID</param>
        /// <param name="version">The package's version</param>
        string GetPackageDownloadUrl(string id, NuGetVersion version);

        /// <summary>
        /// Get the URL to download a package icon.
        /// </summary>
        /// <param name="id">The package's ID</param>
        /// <param name="version">The package's version</param>
        string GetPackageIconDownloadUrl(string id, NuGetVersion version);
    }
}
