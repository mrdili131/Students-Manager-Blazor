using Microsoft.EntityFrameworkCore;
using Bogcha.Models;

namespace Bogcha.Models
{
    public class Attendance
    {
        public int Id {get;set;}
        public int? ClientId {get;set;}
        public int? GroupId {get;set;}
        public bool IsExist {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public Client Client{get;set;}
        public Group Group{get;set;}
    }
}