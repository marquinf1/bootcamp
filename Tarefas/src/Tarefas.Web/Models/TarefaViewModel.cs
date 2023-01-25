using System.ComponentModel;

namespace Tarefas.Web.Models;
public class TarefaViewModel {

    public int Id {get;set;}

    [DisplayName("Titulo")]

    public string Titulo {get;set;}

    [DisplayName("Descrição")]

    public string Descricao {get;set;}
}