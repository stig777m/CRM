using Intra_App_Prj.DAL.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Intra_App_Prj.BLL.DTO
{
    public class DashBoardModel
    {
        public string Id { get; set; }
        public User? birthdays { get; set; }
        public News? news { get; set; }
        public Event? events { get; set; }
        public DateTime? created { get; set; }
    }

    public class TodayBirthdayDets
    {
        public string Emp_Name { get; set; }
        public string Eid { get; set; }
    }

}
