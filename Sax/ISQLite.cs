using System;
using SQLite.Net;

namespace Sax
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
