using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETU5demy.Models
{
    [Table("BOOKS")]
    public class Book
    {
        [Column("BKS_ID")]
        public long Id { get; set; }
        [Column("BKS_TITLE")]
        public string Title { get; set; }
        [Column("BKS_AUTHOR")]
        public string Author { get; set; }
        [Column("BKS_PRICE")]
        public decimal Price { get; set; }
        [Column("BKS_LAUCHDATE")]
        public DateTime LauchDate { get; set; }
    }
}
