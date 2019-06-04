using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Api.Core.Models
{
    public abstract class BaseResult<T> where T: class
    {
        #region Properties
        /// <summary>
        /// Current status of the result
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets status success
        /// </summary>
        public bool IsSuccess { get => this.Status.ToLower() == "ok"; }

        /// <summary>
        /// Gets / sets current item of the result
        /// </summary>
        public T Item { get; set; }
        #endregion
    }
}
