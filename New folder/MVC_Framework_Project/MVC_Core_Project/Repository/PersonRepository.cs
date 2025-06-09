﻿using MVC_Core_Project.Database;
using MVC_Core_Project.Models;

namespace MVC_Core_Project.Repository
{
    public class PersonRepository
    {
        private readonly SqlDataAccess _dataAccess;
        private readonly IConfiguration _configuration;
        public PersonRepository(SqlDataAccess db, IConfiguration configuration)
        {
            _dataAccess = db;
            _configuration = configuration;
        }
        public async Task<bool> AddAsync(Person person)
        {
            try
            {
                await _dataAccess.SaveData("sp_add_person", new
                {
                    Name = person.FullName,
                    email = person.Email,
                    address = person.Address
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> UpdateAsync(Person person)
        {
            try
            {
                await _dataAccess.SaveData("sp_update_person", new
                {
                    id = person.Id,
                    Name = person.FullName,
                    email = person.Email,
                    address = person.Address
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await _dataAccess.SaveData("sp_delete_person", new { Id = id });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<Person?> GetByIdAsync(int id)
        {
            IEnumerable<Person> result = await _dataAccess.GetData<Person, dynamic>
                ("sp_get_person", new { Id = id });
            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<Person>> GetAllPersonAsync()
        {
            string query = "sp_get_Allperson";
            return await _dataAccess.GetData<Person, dynamic>(query, new { });
        }
    }
}
