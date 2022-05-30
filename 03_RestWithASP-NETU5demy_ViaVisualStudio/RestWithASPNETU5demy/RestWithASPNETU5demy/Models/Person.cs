using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETU5demy.Models
{
    [Table("PERSON")]
    public class Person
    {
        [Column("PRS_ID")]
        public long Id { get; set; }
        [Column("PRS_FIRST_NAME")]
        public string FirstName { get; set; }
        [Column("PRS_LAST_NAME")]
        public string LastName { get; set; }
        [Column("PRS_ADDRESS")]
        public string Address { get; set; }
        [Column("PRS_GENDER")]
        public string Gender { get; set; }
    }
}
