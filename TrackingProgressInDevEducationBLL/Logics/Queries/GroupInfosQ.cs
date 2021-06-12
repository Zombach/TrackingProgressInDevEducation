﻿using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class GroupInfosQ : AQuery
    {
        public AbstractModel GetAllStudentsByGroup(GetAllStudentsByGroupQ model)
        {
            WriteTypes(new GroupInfos().GetAllStudentsByGroup());
            return (AbstractModel)GetModelBaseSingle(model);
        }
    }
}