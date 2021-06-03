﻿using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using TrackingProgressInDevEducationDAL.Repositories.Interfaces;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Getter : ISingle, ISeveral
    {
        public static async Task<T> SingleAsync<T>(IDbConnection connection, string command)
        {
            return await connection.QuerySingleAsync<T>(command);
        }

        public static async Task<IEnumerable<T>> SeveralAsync<T>(IDbConnection connection, string command)
        {
            return await connection.QueryAsync<T>(command);
        }
    }
}