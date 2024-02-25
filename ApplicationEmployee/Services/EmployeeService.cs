using System;
using System.Net.Http.Json;
using ApplicationEmployee.Contracts;
using ApplicationEmployee.Dtos;
using DomainEmployee.Entities;

namespace ApplicationEmployee.Services
{
	public class EmployeeService:IEmployeeService
	{
        private readonly HttpClient _httpClient;

		public EmployeeService(HttpClient httpClient)
		{
            _httpClient = httpClient;
		}

        public async Task<EmployeeResponse> AddAsync(Employee employee)
        {
            var data = await _httpClient.PostAsJsonAsync("api/employee", employee);
            var response = await data.Content.ReadFromJsonAsync<EmployeeResponse>();
            return response!;
        }

        public async Task<EmployeeResponse> deleteAsync(int id)
        {

            var data = await _httpClient.DeleteAsync($"api/employee/{id}");
            var response = await data.Content.ReadFromJsonAsync<EmployeeResponse>();
            return response!;
        }

        public async Task<List<Employee>> GetAllAsync() => await _httpClient.GetFromJsonAsync<List<Employee>>("api/employee");
        

        public async Task<Employee> GetByIdAsync(int id)=> await _httpClient.GetFromJsonAsync<Employee>($"api/employee/{id}");

        

        public async Task<EmployeeResponse> UpdateAsync(Employee employee)
        {
            var data = await _httpClient.PutAsJsonAsync("api/employee", employee);
            var response = await data.Content.ReadFromJsonAsync<EmployeeResponse>();

            return response!;
        }
    }
}

