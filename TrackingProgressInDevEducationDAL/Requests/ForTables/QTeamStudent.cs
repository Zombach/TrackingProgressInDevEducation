﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QTeamStudent : IQuery
    {
        public Type Type { get; } = typeof(TeamStudent);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QTeamStudent NullifyTeamStudent()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyTeamStudent);
            Params = string.Empty;
            return this;
        }
    }
}