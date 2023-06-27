﻿using CityInfo.API.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc; 

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDTO>> GetCities() 
        {
            return Ok(CitiesDataStore.Current.Cities);
                


        }
        [HttpGet("{id}")]
        public ActionResult<CityDTO> GetCity(int id)
        {
            
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(u => u.Id == id);
            if(cityToReturn == null)             {
                return NotFound();
            }
            else { return Ok(cityToReturn); }
            
            
        }
    }
}
