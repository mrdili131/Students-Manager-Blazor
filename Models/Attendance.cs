using Microsoft.EntityFrameworkCore;
using Bogcha.Models;

namespace Bogcha.Models
{
    public class Attendance
    {
        public int Id {get;set;}
        public int? ClientId {get;set;}
        public int? GroupId {get;set;}
        public bool IsExist {get;set;} = false;
        public DateOnly CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public Attendance(){
            CreatedAt = DateOnly.FromDateTime(DateTime.Now);
        }

        public Client Client{get;set;}
        public Group Group{get;set;}
    }
}