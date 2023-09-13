using SparkDotnet8.Application.Jobs;
using Coravel;

namespace SparkDotnet8.Application.Startup;

public static class Scheduler
{
    public static IServiceProvider RegisterScheduledJobs(this IServiceProvider services)
    {
        services.UseScheduler(scheduler =>
        {
            // example scheduled job
            //scheduler
            //    .Schedule<ExampleJob>()
            //    .EveryFiveMinutes();
        });
        return services;
    }
}
