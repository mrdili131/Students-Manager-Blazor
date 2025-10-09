using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bogcha.Models
{
    public class BogchaModel
    {
        [Key]
        public int Id {get;set;}
        public string? Name {get;set;}
        public string? Description {get;set;}
        public DateTime? UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}