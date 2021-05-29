﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableLectors
{
    public class UpdateLectorById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateLectorById(int id, string fullName)
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = $"{id}, {fullName}";
        }
    }
}
