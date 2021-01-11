// <copyright file="UpdateResultType.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.Common.Updates
{
    /// <summary>
    /// Represents the result of checking for updates.
    /// </summary>
    public enum UpdateResultType
    {
        /// <summary>
        /// There was an error checking for updates.
        /// </summary>
        Error,

        /// <summary>
        /// No update is available.
        /// </summary>
        NoUpdateAvailable,

        /// <summary>
        /// An update is available.
        /// </summary>
        UpdateAvailable
    }
}
