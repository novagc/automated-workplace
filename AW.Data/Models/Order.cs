using System;
using System.ComponentModel.DataAnnotations;
using AW.Data.Models.Enums;

namespace AW.Data.Models
{
    public class Order: IValidable
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public int CreatorId { get; set; }
        public int? WorkerId { get; set; }

        public Status Status { get; set; }

        public Worker Creator { get; set; }
        public Worker Worker { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Title);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
