﻿using GCBCORE.IServices;
using GCBData;
using GCBData.DTO;
using GCBModel.FragranceModel;
using System.ComponentModel.DataAnnotations;

namespace GCBCORE.Services
{
    public class FragranceService : IFrangranceService
    {
        private readonly FDbContext _dbContext;

        public FragranceService(FDbContext dbContext)
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

        public void DeleteFragrance(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Fragrance> GetAllFragrances()
        {
            throw new NotImplementedException();
        }

        public Fragrance GetFragranceById(string Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFragrance(string Id, FragranceDTO updatedFragrance)
        {
            throw new NotImplementedException();
        }
    }
}
