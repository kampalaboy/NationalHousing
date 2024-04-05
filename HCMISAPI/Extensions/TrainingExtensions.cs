using HCMISAPI.Interfaces;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Repository;
using HCMISAPI.Repository.Training;

namespace HCMISAPI.Extensions
{
    public static class TrainingExtensions
    {
        public static void ConfigureTrainingRepository(this
        IServiceCollection services)
        {
            services.AddScoped<ICPD, CPDRepository>();

            services.AddScoped<IGeneralInternal, GeneralInternalRepository>();

            services.AddScoped<ISubscription, SubscriptionsRepository>();

            services.AddScoped<IProfessionalAssociation, ProfessionalAsociationRepository>();

            services.AddScoped<ITargetTeam, TargetTeamRepositiory>();

            services.AddScoped<ITrainingMethod, TrainingMethodRepository>();

            services.AddScoped<IAppraisalReason, AppraisialReasonRepository>();

            services.AddScoped<IBehavioralCompentencies, BehavioralCompetenciesRepository>();

            services.AddScoped<IBscKpi, BscKpiRepository>();    

            services.AddScoped<IBscPerformanceMeasurement, BscPerformanceMeasurementRepository>();

            services.AddScoped<IBscPerspectives, BscPerspectivesRepository>();

            services.AddScoped<IEmployeeEvidence, EmployeeEvidenceRepository>();

            services.AddScoped<IPerformanceDescriptor, PerformanceDescriptorRepository>();

        }
    }
}
