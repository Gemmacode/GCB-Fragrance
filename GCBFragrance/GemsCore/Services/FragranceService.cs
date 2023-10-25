using GemsCore.IServices;
using GemsData.DTO;
using GemsData.FragranceDbContext;
using GemsModel.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsCore.Services
{
    public class FragranceService : IFragranceService
    {
        private readonly GDbContext _dbContext;

        public FragranceService(GDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string AddFragrance(FragranceDTO fragrance)
        {
            var validationContext = new ValidationContext(fragrance, null, null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(fragrance, validationContext, validationResults, true))
            {
                var validationErrors = string.Join(", ", validationResults.Select(r => r.ErrorMessage));
                return $"Validation failed: {validationErrors}";
            }

            try
            {
                var frag = new Fragrance
                {
                    Id = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false,
                    Name = fragrance.Name,
                    Brand = fragrance.Brand,
                    Price = fragrance.Price,
                    Preference = fragrance.Preference,
                    Description = fragrance.Description,
                    Type = fragrance.Type,
                    VolumeInMilliliters = fragrance.VolumeInMilliliters,
                    Intensity = fragrance.Intensity,
                };

                _dbContext.Fragrances.Add(frag);
                _dbContext.SaveChanges();

                return $"{frag.Name} added successfully";
            }
            catch (Exception ex)
            {
                return $"Error adding fragrance: {ex.Message}";
            }
        }

        public string DeleteFragrance(string Id)
        {
            var frag = _dbContext.Fragrances.FirstOrDefault(x => x.Id == Id);
            if (frag == null)
            {
                return $"Fragrance with {Id} not found";
            }
            _dbContext.Fragrances.Remove(frag);
            _dbContext.SaveChanges();
            return $"Fragrance with {Id} deleted successfully";

        }

        public List<Fragrance> GetAllFragrances()
        {
            var fragranc = new List<Fragrance>();
            return fragranc;
        }

        public Fragrance GetFragranceById(string Id)
        {
            var fragrances = _dbContext.Fragrances.FirstOrDefault(x => x.Id == Id);
            return fragrances;
        }

        public string UpdateFragrance(string Id, FragranceDTO updatedFragrance)
        {
            try
            {
                var existingFragrance = _dbContext.Fragrances.FirstOrDefault(x => x.Id == Id);

                if (existingFragrance == null)
                {
                    return "Fragrance not found";
                }

                // Update properties of the existing fragrance with values from updatedFragrance DTO
                existingFragrance.Name = updatedFragrance.Name;
                // Update other properties...

                _dbContext.Entry(existingFragrance).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return "Fragrance updated successfully";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return "Error updating fragrance";
            }
        }
    }
    
}
