﻿using System;
using SQLite.Net;

namespace Sax.DbConnection
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
