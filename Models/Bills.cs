using spendlock_backend.Models.Base;

namespace spendlock_backend.Models;

public enum Status
{
    Paid = 1,   // Pago
    Pending = 2 ,  // Pendente
    Overdue = 3  //Atrasada
}

public class Bills : BaseEntity
{
    public User UserId {get; set;}
    
    
    public string Description {get; set;} //Period the budget weekly/monthly
    public decimal AmountDue {get; set;}
    public DateTime DueDate {get; set;}
    
}