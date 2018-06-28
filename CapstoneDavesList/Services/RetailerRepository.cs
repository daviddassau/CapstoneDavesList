using CapstoneDavesList.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace CapstoneDavesList.Services
{
    public class RetailerRepository
    {
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DavesList"].ConnectionString);
        }

        public IEnumerable<RetailerDto> GetAllRetailers()
        {
            using (var db = CreateConnection())
            {
                db.Open();

                var allRetailers = db.Query<RetailerDto>(@"SELECT r.Id, r.Name, r.Location, r.Website, r.Details, rc.RetailerId, rc.CategoryId, c.CategoryName
                                                           FROM Retailer r
                                                           JOIN RetailerCategory rc on rc.RetailerId = r.Id
                                                           JOIN Category c on c.Id = rc.CategoryId");

                return allRetailers;
            }
        }
    }
}