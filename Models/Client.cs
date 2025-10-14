using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bogcha.Models;

namespace Bogcha.Models 
{
    public class Client 
    {   
        [Key]
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string MiddleName {get;set;}
        public int Age {get;set;}
        public int? BogchaId {get;set;}
        public int? GroupId {get;set;}
        public int? ParentId {get;set;}
        public string ContactInfo {get;set;}
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public BogchaModel? Bogcha {get;set;}
        public Group? Group {get;set;}
        public User? Parent {get;set;}

        public ICollection<Attendance> Attendances {get;set;} = new List<Attendance>();
    }
}