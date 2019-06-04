using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Api.Core.Models
{
    public class Image
    {
        #region Properties
        /// <summary>
        /// Gets / sets id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets / sets url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets / sets title
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
