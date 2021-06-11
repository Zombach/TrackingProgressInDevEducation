﻿using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TestComplete : AbstractModel
    {
        public int TestId  { get; set; }
        public int StudentId  { get; set; }
        public bool Status  { get; set; }
        public string ApproveDate  { get; set; }
        public int? Score  { get; set; }

        public TestComplete()
        {
        }

        public TestComplete(TestComplete complete) : base(complete)
        {
            TestId = complete.TestId;
            StudentId = complete.StudentId;
            Status = complete.Status;
            ApproveDate = complete.ApproveDate;
            Score = complete.Score;
        }
        public TestComplete(object obj) : base(obj)
        {
            var complete = (TestComplete) obj;
            TestId = complete.TestId;
            StudentId = complete.StudentId;
            Status = complete.Status;
            ApproveDate = complete.ApproveDate;
            Score = complete.Score;
        }

        public override bool Equals(object obj)
        {
            return Equals((TestComplete)obj);
        }

        private bool Equals(TestComplete other)
        {
            return Id == other.Id 
                   && TestId == other.TestId
                   && StudentId == other.StudentId
                   && Status == other.Status
                   && ApproveDate == other.ApproveDate
                   && Score == other.Score;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(TestId);
            hashCode.Add(StudentId);
            hashCode.Add(Status);
            hashCode.Add(ApproveDate);
            hashCode.Add(Score);
            return hashCode.ToHashCode();
        }
    }
}
