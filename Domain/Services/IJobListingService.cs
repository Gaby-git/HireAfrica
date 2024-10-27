namespace Domain.Services;

using Domain.Models;

public interface IJobListingService
{
    public JobListingModel AddSkill(JobListingModel jobListingModel);

    public IEnumerable<JobListingModel> GetSkills();

    public JobListingModel GetSkill(int JobId);

    public JobListingModel UpdateJob( JobListingModel jobListingModel);

    public JobListingModel DeleteSkill(JobListingModel jobListingModel);
}
