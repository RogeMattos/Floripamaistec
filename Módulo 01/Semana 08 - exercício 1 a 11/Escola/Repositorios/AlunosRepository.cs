
using Escola.Dtos;
using Escola.Models;
namespace Escola.Repositorios;

public class  AlunosRepository 
{
     private static List<AlunoModel> lista = new List<AlunoModel>()
     {
       new AlunoModel { id = 1, Nome = "João",  },
       new AlunoModel { id = 2, Nome  = "Pedro", },
       new AlunoModel { id = 3, Nome  = "Lucas" , },
       new AlunoModel { id = 4, Nome  = "José", }
    };

     public List<AlunoModel> ListarAluno(string filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            
            return lista;

        else return lista;
      
    }

     public AlunoModel ObterAluno(int id)
    {
        return lista.FirstOrDefault(x => x.id == id);
    }
    
    public AlunoModel CriarAluno(AlunoDto dto)
    {

        var aluno = new AlunoModel();
        aluno.id = dto.id;
        aluno.Nome = dto.Nome;
        aluno.DataDeNascimento = DateTime.Now;

        lista.Add(aluno);

        return aluno;
    }

     public void ExcluirAluno(int id)
    {
        var AlunoModel = lista.FirstOrDefault(a => a.id == id);

        if (AlunoModel != null)
            lista.Remove(AlunoModel);
    }

}   