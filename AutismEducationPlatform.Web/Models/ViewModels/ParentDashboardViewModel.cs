using System;
using System.Collections.Generic;
using AutismEducationPlatform.Web.Models;

namespace AutismEducationPlatform.Web.Models.ViewModels
{
    public class ParentDashboardViewModel
    {
        public ChildInfo ChildInfo { get; set; } = new();
        public List<CourseViewModel> Courses { get; set; } = new();
        public ProgressReport ProgressReport { get; set; } = new();
        public List<FeedbackReport> FeedbackReports { get; set; } = new();
        public List<Models.Information> InformationItems { get; set; } = new();
    }

    public class ChildInfo
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
    }

    public class ProgressReport
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
} 