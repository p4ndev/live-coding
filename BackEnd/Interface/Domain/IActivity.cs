using BackEnd.Interface.Specialized;
using BackEnd.Interface.Base;
using BackEnd.Entity;

namespace BackEnd.Interface.Domain;

public interface IActivity : IAuth, IEvaluable, ICommitable, IRetrievable<EmployeeActivityDTO>{
    void SetEntrance();
    void SetExit();
}
