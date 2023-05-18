using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Common
{
    public interface IRepository<TDto>
    {
        IEnumerable<TDto> GetAll();
        Task<IEnumerable<TDto>> GetAllAsync(CancellationToken? cancellationToken = default);
    }
}
