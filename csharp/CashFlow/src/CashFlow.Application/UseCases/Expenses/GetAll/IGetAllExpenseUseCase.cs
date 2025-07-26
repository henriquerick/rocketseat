using System;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.GetAll;

public interface IGetAllExpenseUseCase
{
    public Task<ResponseExpensesJson> Execute();
}
