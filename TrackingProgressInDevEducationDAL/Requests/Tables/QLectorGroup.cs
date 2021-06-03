﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorGroup : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(LectorGroup);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorGroup SetNewLectorGroup(int lectorId, int groupId)
        {
            Type = typeof(Setter);
            Name = nameof(SetNewLectorGroup);
            Params = $"{lectorId}{Sep}{groupId}";
            return this;
        }

        public QLectorGroup NullifyLectorGroup()
        {
            Type = typeof(Remove);
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}