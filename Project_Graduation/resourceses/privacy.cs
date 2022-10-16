using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Graduation.resourceses
{
    public class privacy
    {
        private static string conn = "Server=tcp:201984001server.database.windows.net,1433;Initial Catalog=201984001db;Persist Security Info=False;" +
                    "User ID=admin_sa;Password=alencia12A!;" +
                    "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static string connstring
        {
            get
            {
                return conn;
            }
        }

        public static string ID{ get; set; }

        public static string PW { get; set; }

    }
}
