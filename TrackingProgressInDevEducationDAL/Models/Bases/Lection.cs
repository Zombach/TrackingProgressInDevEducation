﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lection : AbstractModel
    {
        public int CourseId { get; set; }
        public int LectorId { get; set; }
        public string StartedOn { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Lection)obj);
        }

        private bool Equals(Lection other)
        {
            return CourseId == other.CourseId
                   && LectorId == other.LectorId
                   && StartedOn == other.StartedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CourseId, LectorId, StartedOn);
        }
    }
}
