using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploCRUD.Models
{
    public class Repositorio
    {
        private static Repositorio _repositorio;

        private List<Funcionario> funcionarios;
        private Repositorio()
        {
            funcionarios = new List<Funcionario>();
        }

        public static Repositorio Instance()
        {
            if(_repositorio == null)
            {
                _repositorio = new Repositorio();
            }

            return _repositorio;
        }
        public void IncluirFuncionario(Funcionario func)
        {
            funcionarios.Add(func);
        }
        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return funcionarios;
        }
        public Funcionario ListarFuncionario(int codigo)
        {
            return funcionarios.Where(f => f.Codigo == codigo).First();
        }

        public void ExcluirFuncionario(int codigo)
        {
            funcionarios.Remove(ListarFuncionario(codigo));
        }

        public void AlterarFuncionario(Funcionario func)
        {
            funcionarios.Where(f => f.Codigo == func.Codigo)
                        .ToList()
                        .ForEach(s =>
                        {
                            s.Nome = func.Nome;
                            s.Endereco = func.Endereco;
                            s.Genero = func.Genero;
                        });
        }
    }
}