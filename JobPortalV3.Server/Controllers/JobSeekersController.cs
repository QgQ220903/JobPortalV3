﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobPortalV3.Server.Data;
using JobPortalV3.Server.Models;

namespace JobPortalV3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JobSeekersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JobSeekers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobSeeker>>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

        // GET: api/JobSeekers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobSeeker>> GetJobSeeker(int id)
        {
            var jobSeeker = await _context.JobSeekers.FindAsync(id);

            if (jobSeeker == null)
            {
                return NotFound();
            }

            return jobSeeker;
        }

        // PUT: api/JobSeekers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobSeeker(int id, JobSeeker jobSeeker)
        {
            if (id != jobSeeker.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobSeeker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobSeekerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobSeekers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobSeeker>> PostJobSeeker(JobSeeker jobSeeker)
        {
            _context.JobSeekers.Add(jobSeeker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobSeeker", new { id = jobSeeker.Id }, jobSeeker);
        }

        // DELETE: api/JobSeekers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobSeeker(int id)
        {
            var jobSeeker = await _context.JobSeekers.FindAsync(id);
            if (jobSeeker == null)
            {
                return NotFound();
            }

            _context.JobSeekers.Remove(jobSeeker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobSeekerExists(int id)
        {
            return _context.JobSeekers.Any(e => e.Id == id);
        }
    }
}
