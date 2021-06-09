﻿using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы SignIns(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class GetLectorA : ADTOAnswer
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Проверка на активность аккаунта
        /// </summary>
        public bool IsActivated { get; set; }
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GetLectorA()
        {
        }

        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="id">Идентификатор объекта</param>
        /// <param name="isActivated">Параметр проверки на активацию аккаунта</param>
        /// <param name="email">"Электронная почта</param>
        /// <param name="fullName">Передаваемое  имя</param>
        public GetLectorA(int id, string email, string fullName, bool isActivated)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            IsActivated = isActivated;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetLectorA)obj);
        }

        private bool Equals(GetLectorA other)
        {
            return Id == other.Id
                && IsActivated == other.IsActivated;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IsActivated);
        }

    }
}