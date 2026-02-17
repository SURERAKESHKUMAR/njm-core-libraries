using Njm.Core.Common;

namespace Njm.Core.Data;

public interface IRepository<T>
{
    Task<BaseResponse<IEnumerable<T>>> GetAllAsync();
}
