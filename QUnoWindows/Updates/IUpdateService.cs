// <copyright file="IUpdateService.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.Common.Updates
{
    /// <summary>
    /// Defines a service used to check for updates to an application.
    /// </summary>
    public interface IUpdateService
    {
        /// <summary>
        /// Checks for an updated version of a product.
        /// </summary>
        /// <param name="product">
        /// A code representing a product.
        /// </param>
        /// <param name="version">
        /// The version number of the product.
        /// </param>
        /// <returns>
        /// An <see cref="UpdateResult"/> value indicating the result of 
        /// checking for updates, including the address of the updated version 
        /// and any exception encountered.
        /// </returns>
        UpdateResult CheckForUpdates(string product, string version);
    }
}
