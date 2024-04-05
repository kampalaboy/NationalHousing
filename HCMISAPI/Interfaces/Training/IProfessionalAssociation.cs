using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface IProfessionalAssociation
    {
        Task<IEnumerable<TrainingAProfessionalAssociation>> get(int? id);

        Task<TrainingAProfessionalAssociation> add(TrainingAProfessionalAssociation entity);

        Task<TrainingAProfessionalAssociation> update(TrainingAProfessionalAssociation entity);
    }
}
