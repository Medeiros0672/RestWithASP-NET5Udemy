using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETU5demy.Models.Base
{
    public class BaseEntity
    {
        [Column("BKS_ID")]
        public long Id { get; set; }
    }
}
