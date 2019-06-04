using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Api.Core.Models
{
    public class Selfy
    {
        #region Properties
        /// <summary>
        /// Gets / sets id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets / sets creation date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets / sets image
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Gets / sets wookie
        /// </summary>
        public Wookie Wookie { get; set; }

        /// <summary>
        /// Gets / sets comments of the selfy
        /// </summary>
        public List<Comment> Comments { get; set; }
        #endregion
    }
}
