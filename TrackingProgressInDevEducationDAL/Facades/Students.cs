﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Students : AFacade
    {
        private readonly QStudent _query  = new();

        /// <summary>
        /// Добавить студента
        /// </summary>
        /// <param name="student">объект данных</param>
        /// <returns>Студент</returns>
        public Student SetNewStudent(Student student)
        {
            return (Student)Manager.Setter.Single(_query.SetNewStudent(student));
        }

        /// <summary>
        /// Получить всех студентов
        /// </summary>
        /// <returns>Студенты</returns>
        public IEnumerable<GetAllStudentsJ> GetAllStudents()
        {
            return (IEnumerable<GetAllStudentsJ>)Manager.Getter.Several(_query.GetAllStudents());
        }

        public IEnumerable<GetAllStudentsJ> UpdStudentToGroup()
        {
            return (IEnumerable<GetAllStudentsJ>)Manager.Update.Upd(_query.UpdStudentToGroup());
        }

        /// <summary>
        /// Обнулить таблицу студентов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GetAllStudentsJ> NullifyStudents()
        {
            return (IEnumerable<GetAllStudentsJ>)Manager.Remove.Rem(_query.NullifyStudents());
        }

    }
}