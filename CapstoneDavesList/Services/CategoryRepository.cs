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
            throw new NotImplementedException();
        }
    }
}