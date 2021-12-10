using System.IO;

namespace E_JOGOS.Models
{
    public class EjogosBase
    {
       //criar uma funcao para criar a pasta e o arquivo.


        //string path é o parametro da funcao,que tera o caminho
          //para analise.
        public void CreateFolderAndFile(string path)
        {
            // pasta / arquivo.csv;

            string folder = path.Split('/')[0]; //recebe nome da pasta.
            string file = path.Split('/')[1]; //receber o nome do arquivo.

            //se nao existir cria a pasta.
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //se nao existir arquivo na pasta cria.
            if (!File.Exists(file))
            {
                File.Create(path);
            } 

        }

    }
}
