// <copyright file="UpdateService.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.Common.Updates
{
    /// <summary>
    /// Provides an implementation of <see cref="IUpdateService"/> that uses 
    /// the standard update web service.
    /// </summary>
    public class UpdateService : IUpdateService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateService"/> class.
        /// </summary>
        public UpdateService()
        {
        }

        #region IUpdateService Members

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
        public UpdateResult CheckForUpdates(string product, string version)
        {
            // TODO Make the web service call.
            UpdateResult result = new UpdateResult();
            System.Threading.Thread.Sleep(2000);

            return result;
        }

        #endregion
    }
}
