using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.DataCriacao = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}