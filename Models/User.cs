using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Bogcha.Models;

namespace Bogcha.Models
{
    public class User
    {
        [Key]
        public int Id {get;set;}
        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        public string? MiddleName {get;set;}
        public int? BogchaId {get;set;}
        public int? GroupId {get;set;}
        public DateTime? UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public BogchaModel? Bogcha {get;set;}
        public Group? Group {get;set;}
    }
}