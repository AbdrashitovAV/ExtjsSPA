using System;
using System.ComponentModel.DataAnnotations;

namespace Spa.Db
{
    /// <summary>
    /// Базовая сущность.
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}