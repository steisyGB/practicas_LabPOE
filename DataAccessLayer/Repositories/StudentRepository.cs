﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository
    {
        private SqleDataAccess _dbConnection;

        public StudentRepository()
        {
            _dbConnection = new SqleDataAccess();
        }

        public DataTable GetStudent()
        {
            DataTable studentTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM student";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                studentTable.Load(reader);
            }
            return studentTable;
        }

        public void AddStudent(Studen student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO career VALUES (@NameStudent, @LastnameStudent, @IdCareerStudent)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@LastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@IdCareerStudent", student.idCareerStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditStudent(Studen student)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @" UPDATE Career
                              SET nameStudent = @NameStudent,
                                    lastnameStudent = @LastnameStudent,
                                    idCareerStudent = @IdCareerStudent
                              WHERE idStudent = @IdStudent";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@LastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@IdCareerStudent", student.idCareerStudent);
                command.Parameters.AddWithValue("@IdStudent", student.idStudent);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM student WHERE idStudent = @IdStudent";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idStudent", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
