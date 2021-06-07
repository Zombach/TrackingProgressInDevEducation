﻿using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class QGroup : AQuery
    {
        /// <summary>
        /// Создать новую группу
        /// </summary>
        /// <param name="groupQuery">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel SetNewGroup(GroupQuery groupQuery)
        {
            WriteTypes(new GroupPage());
            return GetModelBaseSingle(groupQuery);
        }
    }
}
