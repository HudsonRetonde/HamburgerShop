using HamburguerShop.Models;

namespace HamburguerShop.Repositories.Interface
{
	public interface ICategoriaRepository
	{
		IEnumerable<Categoria> Categorias { get; }
	}
}
