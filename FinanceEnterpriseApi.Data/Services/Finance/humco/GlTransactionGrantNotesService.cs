using AutoMapper;
using FinanceEnterpriseApi.Data.Dtos.Finance.humco;
using FinanceEnterpriseApi.Data.Interfaces.Finance.humco;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterpriseApi.Data.Services.Finance.humco
{
    public class GlTransactionGrantNotesService : IGlTransactionGrantNotesService
    {
        private readonly IDbContextFactory<FinanceContext> _financeGLContextFactory;
        private readonly IMapper _mapper;

        public GlTransactionGrantNotesService(IDbContextFactory<FinanceContext> financeGLContextFactory, IMapper mapper)
        {
            _financeGLContextFactory = financeGLContextFactory;
            _mapper = mapper;
        }

        public async Task<GlTransactionGrantNote> GetByIdAsync(int id)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            return await context.GlTransactionGrantNotes
                .AsNoTracking()
                .FirstOrDefaultAsync(n => n.GlTrnsId == id);
        }

        public async Task AddAsync(PutGlTransactionGrantNotesParamsDto noteDto)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            var note = _mapper.Map<GlTransactionGrantNote>(noteDto);

            context.Add(note);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PutGlTransactionGrantNotesParamsDto noteDto)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            var note = _mapper.Map<GlTransactionGrantNote>(noteDto);

            context.Update(note);
            await context.SaveChangesAsync();
        }
    }
}
