using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoLeague.Models;
 
namespace DojoLeague.Factory
{
    public class DojoNinjasFactory
    {
        private string connectionString;
        public DojoNinjasFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=DojoLeague_db;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }

        public void AddNinja(Ninja ninja){
            using (IDbConnection dbConnection=Connection)
            {
 
                var query="INSERT INTO ninjas (name,level,description,dojo_id,created_at,updated_at) VALUES(@name,@level,@description,@dojo_id,NOW(),NOW())";
                dbConnection.Open();
                dbConnection.Execute(query,ninja);

                
                
            }
        }
        public void AddDojo(Dojo dojo){
            using (IDbConnection dbConnection=Connection)
            {
 
                var query="INSERT INTO dojos (name,location,description,created_at,updated_at) VALUES(@name,@location,@description,NOW(),NOW())";
                dbConnection.Open();
                dbConnection.Execute(query,dojo);
            }
        }
        public List<Dojo> FindAllDojos()
        {
            using(IDbConnection dbConnection=Connection)
            {
                var query="SELECT * FROM dojos";

                return dbConnection.Query<Dojo>(query).ToList();
            }

        }

        public List<Ninja> FindAllNinjas()
        {
            using(IDbConnection dbConnection=Connection)
            {
                var query="SELECT * FROM ninjas LEFT JOIN dojos ON ninjas.dojo_id=dojos.dojo_id ";
                dbConnection.Open();

                List<Ninja> myNinjas=dbConnection.Query<Ninja,Dojo, Ninja>(query,(ninja,dojo)=>{ninja.dojo=dojo; return ninja;},splitOn: "dojo_id").ToList();
                
                return myNinjas;
            }
        }
        public Ninja FindNinjaById(long ninja_id){

            using(IDbConnection dbConnection=Connection)
            {
                var query=" SELECT * FROM ninjas LEFT JOIN dojos ON ninjas.dojo_id=dojos.dojo_id WHERE ninjas.ninja_id=@ID";
                var data=new {ID=ninja_id};
                dbConnection.Open();
                Ninja myNinja=dbConnection.Query<Ninja,Dojo,Ninja>(query,(ninja,dojo)=>{ninja.dojo=dojo;return ninja;},data,splitOn:"dojo_id").FirstOrDefault();
                return myNinja;
            }
        }

        public Dojo FindDojoById(long dojo_id){

            using(IDbConnection dbConnection=Connection)
            {
                dbConnection.Open();
                var query=
                @"
                    SELECT * FROM dojos WHERE dojo_id=@ID;
                    SELECT * FROM ninjas WHERE dojo_id=@ID;
                ";
                using (var multi = dbConnection.QueryMultiple(query, new {Id = dojo_id}))
                {
                    Dojo dojo = multi.Read<Dojo>().Single();
                    dojo.ninjas = multi.Read<Ninja>().ToList();

                    return dojo;
                }
            }
        }

        public List<Ninja> FindAllRogueNinjas()
        {
            using(IDbConnection dbConnection=Connection)
            {
                var query="SELECT * FROM ninjas WHERE ninjas.dojo_id IS NULL";

                dbConnection.Open();
                return dbConnection.Query<Ninja>(query).ToList();
                
            }
        }

        public void BanishNinja(int ninja_id)
        {
            using(IDbConnection dbConnection=Connection)
            {
                dbConnection.Open();
                var query="UPDATE ninjas SET dojo_id=NULL WHERE ninja_id=@ID";
                var data=new {ID=ninja_id};
                dbConnection.Execute(query,data);
            }
        }
        public void RecruitNinja(int ninja_id,int dojo_id)
        {
            using(IDbConnection dbConnection=Connection)
            {
                dbConnection.Open();
                var query="UPDATE ninjas SET dojo_id=@DojoId WHERE ninja_id=@ID";
                var data=new {DojoId=dojo_id,ID=ninja_id};
                dbConnection.Execute(query,data);
            }
        }
    }
}