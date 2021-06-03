﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

//ZLoo (Свойства все, Методы(SetNewCity, GetAllCities, NullifyCities))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы Cities
    /// </summary>
    public class QCity : IQuery
    {
        public Type Type { get; } = typeof(City);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового города
        /// </summary>
        /// <param name="name">Название города</param>
        /// <returns>Подготовленный запрос</returns>
        public QCity SetNewCity(string name)
        {
            Name = nameof(SetNewCity);
            Params = $"{name}";
            return this;
        }

        /// <summary>
        /// Получение всех городов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCity GetAllCities()
        {
            Name = nameof(GetAllCities);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCity NullifyCities()
        {
            Name = nameof(NullifyCities);
            Params = string.Empty;
            return this;
        }

        //public QCity GetCityById(int id)
        //{
        //    Name = nameof(GetCityById);
        //    Params = $"{id}";
        //    return this;
        //}

        //public QCity RemoveCityById(int id)
        //{
        //    Name = nameof(RemoveCityById);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}