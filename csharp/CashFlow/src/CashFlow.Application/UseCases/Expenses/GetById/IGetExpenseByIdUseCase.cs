using System;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public interface IGetExpenseByIdUseCase
{
    public Task<ResponseExpenseJson> Execute(long id);
}
