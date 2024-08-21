using System;
using System.Collections.Generic;
using System.Web.Http;
using CC_webAPI.Models;

namespace CC_webAPI.Controllers
{
    public class CountryController : ApiController
    {
        private List<Country> countries = new List<Country>();

        public CountryController()
        {
            // Initialize some sample data
            countries.Add(new Country { ID = 1, CountryName = "USA", Capital = "Washington D.C." });
            countries.Add(new Country { ID = 2, CountryName = "Canada", Capital = "Ottawa" });
            countries.Add(new Country { ID = 3, CountryName = "Mexico", Capital = "Mexico City" });
        }

        // GET api/country
        public IHttpActionResult GetAllCountries()
        {
            return Ok(countries);
        }

        // GET api/country/5
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.Find(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST api/country
        public IHttpActionResult PostCountry(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            country.ID = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT api/country/5
        public IHttpActionResult PutCountry(int id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCountry = countries.Find(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;
            return Ok(existingCountry);
        }

        // DELETE api/country/5
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.Find(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);
            return Ok();
        }
    }
}