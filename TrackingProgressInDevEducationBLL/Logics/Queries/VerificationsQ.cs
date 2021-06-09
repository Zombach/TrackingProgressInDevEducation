﻿using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class VerificationsQ : AQuery
    {
        public AbstractModel UpdateActivationLector(UpdLectorQ updLectorQ)
        {
            WriteTypes(new Verifications().UpdateActivationLector());
            return GetModelBaseSingle(updLectorQ);
        }
    }
}