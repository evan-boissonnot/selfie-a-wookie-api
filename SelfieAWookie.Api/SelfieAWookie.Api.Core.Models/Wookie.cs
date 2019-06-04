using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Api.Core.Models
{
    public class Wookie
    {
        #region Properties
        /// <summary>
        /// Gets / sets id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets / sets surname of the wookie
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets / sets size of the wookie
        /// </summary>
        public decimal Size { get; set; }
        #endregion
    }
}
