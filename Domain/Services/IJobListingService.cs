namespace Domain.Services;

using Domain.Models;

public interface IJobListingService
{
    public JobListingModel AddJob(JobListingModel jobListinigModel);

    public IEnumerable<JobListingModel> GetJobList();

    public JobListingModel GetJob(int JobId);

    public JobListingModel UpdateJob(int jobId, JobListingModel jobListingModel);

    public JobListingModel DeleteJob(int JobId);
}
