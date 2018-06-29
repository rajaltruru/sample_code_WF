using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GridSample.Repositories
{
    public static class ContactRepository
    {
        public static DataTable GetContactsDetails()
        {
            SqlConnection Conn = new SqlConnection("Data Source=server;integrated " + "Security=sspi;initial catalog=pubs;");
            SqlCommand sqlcmd = new SqlCommand("dbo.GetContactsDetails", Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
            DataSet Contacts = new DataSet();
            adapter.Fill(Contacts, "Contacts");
            return Contacts.Tables[0];

        }
    }
}