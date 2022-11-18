using DevTools.ADO.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DevTools.ADO.Repositories.Comments
{
    internal class CommentRepository : ICommentRepository
    {
        private readonly string connectionString;
        public CommentRepository()
        {
            connectionString = "Data Source=localhost;port=3308;Initial Catalog=contact_manag_DB;User Id=root pwd=12345678";
        }
        public void Add(Comment entity)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = $"INSERT INTO comment(content, creation, contact_id) VALUES(" +
                    $"@content, @cdate , @contactId)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@content", entity.Content);
                cmd.Parameters.AddWithValue("@contactId", entity.ContactId);
                cmd.Parameters.AddWithValue("@cdate", entity.ContactId);
                con.Open();
                var status = cmd.ExecuteNonQuery();
                con.Close();
            }
                
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Comment Get(int id)
        {
            using(var con= new MySqlConnection(connectionString))
            {
                string query = " SELECT * FROM comment WHERE id=@id";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                var status = cmd.ExecuteNonQuery();
                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {

                //    }
                //}
                con.Close();
            }
        }

        public ICollection<Comment> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Comment> GetAllByContact(int contactid)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
