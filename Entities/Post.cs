using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstRelation.Entities
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

    }
}
