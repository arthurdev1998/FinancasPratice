using Financeiro.Data.Data;

namespace Financeiro.Services.Services.CategoriaServices;

public class GetByIdCategoryHandler
{
    private readonly AppDbContext _context;

    public GetByIdCategoryHandler(AppDbContext context)
    {
        _context = context;
    }
}