namespace WebApi.Controllers;

using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class JobListingController :ControllerBase
{
    private readonly IJobListingService _jobListingService;
    public JobListingController(IJobListingService jobListingService)
        => _jobListingService = jobListingService;

    [HttpPost]
    public IActionResult AddJob(JobListingModel jobListingModel)
    {
        var addJob = 
                 _jobListingService.AddJob(jobListingModel);

            return CreatedAtAction(
                  nameof(GetJobById), new { jobId = addJob.JobId }, addJob);
    }

    [HttpGet]
    public IActionResult GetJobList()
    {
        var jobList = 
                   _jobListingService.GetJobList();
            return Ok(
                  jobList);

    }

    [HttpGet("{jobId:int}")]
    public IActionResult GetJobById(int jobId)
    {
        var job = 
                _jobListingService.GetJob(jobId);

            return Ok(
                  job);
    }

    [HttpPut("{jobId:int}")]
    public IActionResult UpdateJob(int jobId, JobListingModel jobListingModel)
    {

        var updatedJob = 
                  _jobListingService.UpdateJob(jobId, jobListingModel);

            return Ok(
                  updatedJob);

    }

    [HttpDelete("{jobId:int}")]
    public IActionResult DeleteJob(int jobId)
    {
        _jobListingService.DeleteJob(jobId);

        return NoContent();
    }
}
