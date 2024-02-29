using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindersLibrary
{
    public class SqlConnection
    {
        public static List<ReminderModel> LoadReminders()
        {
            // make sure to use a using statement
            // prevents open connections on crash or finish or whatever
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // expected type is IEnumerable
                // these strings are SQL queries

                // also be sure to save the sql db
                var output = cnn.Query<ReminderModel>("select * from RemindersTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveReminder(ReminderModel reminder)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // these strings are SQL queries
                cnn.Execute("insert into RemindersTable (Reminder, 1) values (@Reminder, @Enabled)", reminder);
            }
        }

        // This refers to App.config's connectionstring
        // According to the video at https://www.youtube.com/watch?v=ayp3tHEkRc0
        // I needed to add in the configuration manager, but it seems as if
        // this was already done for me by default on dotnet 8?
        private static string LoadConnectionString(string id = "Default")
        {
            // gets connection string at name="Default" - basically selects the "tag"
            // then gets the actual string portion in the "tag"
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
