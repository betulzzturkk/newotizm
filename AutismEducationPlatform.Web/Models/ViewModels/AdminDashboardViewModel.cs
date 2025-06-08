using System;
using System.Collections.Generic;

namespace AutismEducationPlatform.Web.Models.ViewModels
{
    public class AdminDashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalCourses { get; set; }
        public int ActiveUsers { get; set; }
        public List<CourseViewModel> Courses { get; set; } = new();
        public SystemStatistics Statistics { get; set; } = new();
        public List<ActivityLog> RecentActivities { get; set; } = new();
    }

    public class AdminInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

    public class SystemStatistics
    {
        public int TotalUsers { get; set; }
        public int ActiveCourses { get; set; }
        public int TotalInstructors { get; set; }
    }

    public class ActivityLog
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
} 