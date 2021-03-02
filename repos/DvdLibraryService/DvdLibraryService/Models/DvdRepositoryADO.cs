using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DvdLibraryService.Models
{
    public class DvdRepositoryADO : IDvdRepository
    {
        public List<Dvd> _dvds;

        public DvdRepositoryADO()
        {
            _dvds = new List<Dvd>()
            {

            };
        }

        public void Create(Dvd dvd)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Dvds"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "InsertDvd";

                cmd.Parameters.AddWithValue("@Title", dvd.Title);
                cmd.Parameters.AddWithValue("@ReleaseYear", dvd.ReleaseYear);
                cmd.Parameters.AddWithValue("@Director", dvd.Director);
                cmd.Parameters.AddWithValue("@Rating", dvd.Rating);
                cmd.Parameters.AddWithValue("@Notes", dvd.Notes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int dvdId)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Dvds"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "DeleteDvd";

                cmd.Parameters.AddWithValue("@DvdID", dvdId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Dvd Get(int dvdId)
        {
            Dvd currentRow = new Dvd();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Dvds"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SelectDvdByID";

                cmd.Parameters.AddWithValue("@DvdID", dvdId);

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        currentRow.Title = dr["Title"].ToString();

                        if (dr["ReleaseYear"] != DBNull.Value)
                            currentRow.ReleaseYear = (int)dr["ReleaseYear"];

                        if (dr["Director"] != DBNull.Value)
                            currentRow.Director = dr["Director"].ToString();

                        if (dr["Rating"] != DBNull.Value)
                            currentRow.Rating = dr["Rating"].ToString();

                        if (dr["Notes"] != DBNull.Value)
                            currentRow.Notes = dr["Notes"].ToString();

                        currentRow.DvdId = (int)dr["DvdID"];
                    }
                }
            }

            return currentRow;
        }

        public List<Dvd> GetAll()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Dvds"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SelectAllDvds";

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Dvd currentRow = new Dvd();

                        currentRow.Title = dr["Title"].ToString();

                        if (dr["ReleaseYear"] != DBNull.Value)
                            currentRow.ReleaseYear = (int)dr["ReleaseYear"];

                        if (dr["Director"] != DBNull.Value)
                            currentRow.Director = dr["Director"].ToString();

                        if (dr["Rating"] != DBNull.Value)
                            currentRow.Rating = dr["Rating"].ToString();

                        if (dr["Notes"] != DBNull.Value)
                            currentRow.Notes = dr["Notes"].ToString();

                        currentRow.DvdId = (int)dr["DvdID"];

                        _dvds.Add(currentRow);
                    }
                }
            }

            return _dvds;
        }

        public void Update(Dvd dvd)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Dvds"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "UpdateDvd";

                cmd.Parameters.AddWithValue("@DvdID", dvd.DvdId);
                cmd.Parameters.AddWithValue("@Title", dvd.Title);
                cmd.Parameters.AddWithValue("@ReleaseYear", dvd.ReleaseYear);
                cmd.Parameters.AddWithValue("@Director", dvd.Director);
                cmd.Parameters.AddWithValue("@Rating", dvd.Rating);
                cmd.Parameters.AddWithValue("@Notes", dvd.Notes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}