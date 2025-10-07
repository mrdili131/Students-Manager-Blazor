using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Models 
{
    public class Client 
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
    }
}