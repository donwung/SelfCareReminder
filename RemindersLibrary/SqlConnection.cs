using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public static void CreateReminder(ReminderModel reminder)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // these strings are SQL queries
                cnn.Execute("insert into RemindersTable (Reminder, 1) values (@Reminder, @Enabled)", reminder);
            }
        }

        public static void GetAllReminders()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        public static ReminderModel GetOneReminder(int ID)
        {
            string sql = $"""SELECT * FROM RemindersTable WHERE ID = {ID}""";

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                ReminderModel output = cnn.QueryFirstOrDefault<ReminderModel>(sql);
                Debug.WriteLine(output.Reminder);
                return output;
            }
        }

        public static void UpdateReminderText(int ID, ReminderModel reminder)
        {
            string sql = $"""UPDATE RemindersTable SET Reminder = "{reminder.Reminder}" WHERE ID = {ID.ToString()}""";
            Debug.WriteLine(sql);

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(sql);
            }
        }

        public static void UpdateReminderEnable(int ID, bool enabled)
        {
            string sql = $"""UPDATE RemindersTable SET Enabled = {enabled} WHERE ID = {ID.ToString()}""";
            Debug.Write(sql);

            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(sql);
            }
        }

        public static void DeleteReminder(int ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

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

        public static void test()
        {
            Debug.WriteLine("In SqlConnection");
        }
    }
}
