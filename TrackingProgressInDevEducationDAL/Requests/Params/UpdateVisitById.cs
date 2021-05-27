﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
   public class UpdateVisitById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        {
            Type = typeof(Visits);
            Name = "UpdateVisitById";
            Params = $"{id}, {visitStatus}, {studentId}, {lectionId}";
        }
    }
}