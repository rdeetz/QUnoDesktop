// <copyright file="UpdateResult.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.Common.Updates
{
    using System;

    /// <summary>
    /// Represents the result of checking for updates with additional information.
    /// </summary>
    public class UpdateResult
    {
        private UpdateResultType resultType;
        private string address;
        private Exception exception;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult"/> class.
        /// </summary>
        public UpdateResult()
        {
            this.resultType = UpdateResultType.NoUpdateAvailable;
        }

        /// <summary>
        /// Gets or sets the result type.
        /// </summary>
        /// <value>
        /// The result type.
        /// </value>
        public UpdateResultType ResultType
        {
            get
            {
                return this.resultType;
            }

            set
            {
                this.resultType = value;
            }
        }

        /// <summary>
        /// Gets or sets the address where the updated version is located.
        /// </summary>
        /// <value>
        /// The address of the updated version.
        /// </value>
        /// <remarks>
        /// When <see cref="P:ResultType"/> is <see cref="E:UpdateResultType.UpdateAvailable"/>, 
        /// this property contains a URL with the location of the updated version. Otherwise, 
        /// this property is <see langword="null"/>.
        /// </remarks>
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets the exception encountered when checking for updates.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        /// <remarks>
        /// When <see cref="P:ResultType"/> is <see cref="E:UpdateResultType.Error"/>, 
        /// this property contains the exception thrown when checking for updates. Otherwise, 
        /// this property is <see langword="null"/>.
        /// </remarks>
        public Exception Exception
        {
            get
            {
                return this.exception;
            }

            set
            {
                this.exception = value;
            }
        }
    }
}
