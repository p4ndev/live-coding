using BackEnd.Interface.Specialized;
using BackEnd.Interface.Base;

namespace BackEnd.Interface.Domain;

public interface IQuarentine : IAuth, IEvaluable, ICommitable{
    void SetEmailNotifications(IEnumerable<string> emails);
}
