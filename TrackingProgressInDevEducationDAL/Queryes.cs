﻿using TrackingProgressInDevEducationDAL.Requests;

namespace TrackingProgressInDevEducationDAL
{
    public class Queryes
    {
        public AddNewStudent AddNewStudent { get; set; }
        public GetByIdStudent GetByIdStudent { get; set; }
        public GetStudents GetStudents { get; set; }
        public RemoveStudents RemoveStudents { get; set; }
    }
}