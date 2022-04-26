using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Contexts;
using QuestionnairePortal.Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfQuestionnaireReplieDal : EfEntityRepositoryBase<QuestionnaireReplie, QuestionnaireDb>, IQuestionnaireReplieDal
    {

    }
}
