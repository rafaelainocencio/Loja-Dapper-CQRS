using Dapper;
using Loja.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Repositories.CategoriaContext
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _connectionString;

        public  CategoriaRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("LojaServer");
        }

        public async Task Insert(Categoria categoria)
        {
            using var connection = new SqlConnection(_connectionString);

            string nome = categoria.Nome;

            var query = "INSERT INTO categoria(nome) values (@nome)"; //

            var result = connection.Execute(query, new {Nome = nome }); //mudar para NOME ou deixar Categoria = categoria

        }

        public IEnumerable<Categoria> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);

            var categoriaData = connection.Query<Categoria>("select * from categoria");

            return categoriaData;
        }
    }
}
