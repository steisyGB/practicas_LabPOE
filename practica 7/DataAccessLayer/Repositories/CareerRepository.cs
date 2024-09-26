﻿using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CareerRepository
    {
        private SqlDataAccess _dbConnection;

        public CareerRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetCareers()
        {
            DataTable careersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM career";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                careersTable.Load(reader);
            }

            return careersTable;
        }

        public void AddCareer(Career career)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO career VALUES(@NameCareer, @DescriptionCareer)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameCareer", career.nameCareer);
                command.Parameters.AddWithValue("@DescriptionCareer", career.descriptionCareer);
                connection.Open();

                command.ExecuteNonQuery();

            }
        }
    }
}
