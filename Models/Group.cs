using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Bogcha.Models;

namespace Bogcha.Models
{
    public class Group
    {
        [Key]
        public int Id {get;set;}
        public string? Name {get;set;}
        public int? BogchaId {get;set;}
        public int? TeacherId {get;set;}
        public DateTime? UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public BogchaModel? Bogcha {get;set;}
    }
}