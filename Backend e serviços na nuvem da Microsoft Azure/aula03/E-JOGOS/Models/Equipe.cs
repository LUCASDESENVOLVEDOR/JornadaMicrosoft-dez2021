using E_JOGOS.Interface;
using System.Collections.Generic;

namespace E_JOGOS.Models
{

    // : HERANÇA -> EjogosBase
    public class Equipe : EjogosBase,IEquipe
    {
        //CONSTRUTOR  CTOR.

        //FUNCAO QUE VAI EXECUTAR/INICIAR ASSIM QUE A CLASSE FOI INSTANCIADO.

        private const string path = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }


        //funcao que vai preparar/converter de string para o
         //tipo equipe.

       // private string 



        public void Create(Equipe nova_equipe)
        {
            //receber um objeto de equipe.
            //e gravar no CSV.
            //




        }

        public void Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
