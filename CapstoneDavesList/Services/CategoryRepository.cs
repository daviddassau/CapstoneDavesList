using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using CapstoneDavesList.Models;

namespace CapstoneDavesList.Services
{
    public class CategoryRepository
    {
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DavesList"].ConnectionString);
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            using (var db = CreateConnection())
            {
                db.Open();

                var allCategories = db.Query<CategoryDto>(@"SELECT c.Id, c.CategoryName, rc.CategoryId, rc.RetailerId, r.Name
                                                            FROM Category c
                                                            JOIN RetailerCategory rc on rc.CategoryId = c.Id
                                                            JOIN Retailer r on r.Id = rc.RetailerId");

                return allCategories;
            }
        }
    }
}