using System;
using ApplicationEmployee.Dtos;
using DomainEmployee.Entities;

namespace ApplicationEmployee.Services
{
	public interface IEmployeeService
	{
        Task<EmployeeResponse> AddAsync(Employee employee);
        Task<EmployeeResponse> UpdateAsync(Employee employee);
        Task<EmployeeResponse> deleteAsync(int id);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}

