using HamburguerShop.Context;
using HamburguerShop.Models;
using HamburguerShop.Repositories.Interface;

namespace HamburguerShop.Repositories
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext _context;

		public CategoriaRepository(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Categoria> Categorias => _context.Categorias;
	}
}
