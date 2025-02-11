﻿using Restromanager.Backend.Domain.Entities;
using Restromanager.Backend.DTOs;
using Restromanager.Backend.Responses;

namespace Restromanager.Backend.UnitsOfWork.interfaces
{
    public interface IStockRawMaterialUnitOfWork
    {
        Task<ActionResponse<StockRawMaterial>> GetAsync(int id);
        Task<ActionResponse<IEnumerable<StockRawMaterial>>> GetAsync();
        Task<ActionResponse<IEnumerable<StockRawMaterial>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
