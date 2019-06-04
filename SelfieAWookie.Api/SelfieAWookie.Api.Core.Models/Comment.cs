using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Api.Core.Models
{
    public class Comment
    {
        #region Properties
        /// <summary>
        /// Gets / sets id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets / sets adding comment date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets / sets content of the comment
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///  Gets / sets wookie that creates the comment
        /// </summary>
        public Wookie Wookie { get; set; }
        #endregion
    }
}
