using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eZdravaIshrana_API.Util
{
    public class ExceptionHandler
    {
        public static string HandleException(EntityException ex)
        {
            SqlException error = ex.InnerException as SqlException;
            switch (error.Number)
            {
                case 2627: return getConstraintExceptionMessage(error);

            }
            return error.Message + "(" + error.Number + ")";
        }

        private static string getConstraintExceptionMessage(SqlException error)
           {
            string msg = error.Message;
            int pocetak = msg.IndexOf("'");
            int kraj = msg.IndexOf("'", pocetak + 1);

            if (pocetak > 0 && kraj > 0)
            {
                string nazivOgranicenja = msg.Substring(pocetak + 1, kraj - pocetak-1);
                if (nazivOgranicenja == "CS_Email")
                    msg = "email_con";
                else if (nazivOgranicenja == "CS_KorisnickoIme")
                    msg = "username_con";
                 if (nazivOgranicenja == "Email_Kupac")
                    msg = "Email_Kupac";
                else if (nazivOgranicenja == "KorisnickoIme_Kupac")
                    msg = "KorisnickoIme_Kupac";
                else if (nazivOgranicenja == "CS_EmailD")
                    msg = "email_con_D";
                else if (nazivOgranicenja == "CS_KorisnickoImeD")
                    msg = "username_con_D";
            }
            return msg;
        }
    }
}