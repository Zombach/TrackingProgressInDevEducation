﻿using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Courses : ATransfer
    {
        public Courses GetAllCourses()
        {
            Query = typeof(SetCoursesQ);
            Base = typeof(Course);
            Answer = typeof(SetCoursesA);
            return this;
        }
    }
}