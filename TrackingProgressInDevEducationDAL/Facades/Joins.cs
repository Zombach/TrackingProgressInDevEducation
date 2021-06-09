﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Joins : AFacade 
    {
        private readonly QJoins _query  = new();
        public IEnumerable<Joins> GetAllCoursesByLectorJ()
        {
            return (IEnumerable<Joins>) Manager.Getter.Several(_query.GetAllCoursesByLectorJ());
        }

        public IEnumerable<Joins> GetAllStudentsByTeamJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetAllStudentsByTeamJ());
        }

        public IEnumerable<Joins> GetAllTeamsByLectorJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetAllTeamsByLectorJ());
        }

        public IEnumerable<Joins> GetAllTestsByStudentIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetAllTestsByStudentIdJ());
        }

        public IEnumerable<Joins> GetGroupByIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetGroupByIdJ());
        }
        public IEnumerable<GetGroupByLectorJ> GetGroupByLectorJ(GetGroupByLectorJ lector)
        {
            return (IEnumerable<GetGroupByLectorJ>)Manager.Getter.Several(_query.GetGroupByLectorJ(lector));
        }

        public IEnumerable<Joins> GetHWComplitingByStudentJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetHWComplitingByStudentJ());
        }

        public IEnumerable<Joins> GetNotActualTeamByStudentIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetNotActualTeamByStudentIdJ());
        }

        public IEnumerable<Joins> GetStudentByIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetStudentByIdJ());
        }

        public IEnumerable<Joins> GetVisitsByStudentJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetVisitsByStudentJ());
        }
    }
}