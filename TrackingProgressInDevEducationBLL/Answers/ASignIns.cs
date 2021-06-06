﻿using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы SignIn
    /// </summary>
    public class ASignIns : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос получение лектора по логину и паролю
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public LectorAnswer GetLoginAndPassword(Lector model)
        {
            WriteTypes(new SignInLector());
            return (LectorAnswer)GetModelBaseSingle(model);
        }
    }
}