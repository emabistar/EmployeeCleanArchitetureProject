using System;
using ApplicationEmployee.Dtos;
using DomainEmployee.Entities;

namespace ApplicationEmployee.Contracts
{
	public interface IEmployee
	{
        Task<EmployeeResponse> AddAsync(Employee employee);
        Task<EmployeeResponse> UpdateAsync(Employee employee);
        Task<EmployeeResponse> DeleteAsync(int id);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}

