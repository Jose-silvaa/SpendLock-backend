using spendlock_backend.Models;
using spendlock_backend.Models.Base;

namespace spendlock_backend.models;

public enum PaymentMethod
{
    Cash = 1,       // Dinheiro
    Card = 2,       // Cartão (crédito/débito)
    BankTransfer = 3, // Transferência bancária (PIX, TED, etc)
    Other = 4       // Outro tipo de pagamento
}

public enum TransactionType
{
    Income = 1,   // Receita
    Expense = 2   // Despesa
}

public enum TransactionStatus
{
    Pending = 1,   // Em processamento / aguardando confirmação
    Completed = 2, // Finalizada
    Failed = 3     // Falhou
}

public class Transactions : BaseEntity
{
    public User UserId { get; set; }
    public Bills? BillId { get; set; }
    public Category CategoryId { get; set; }
    
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    
    public TransactionType Type { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public TransactionStatus Status { get; set; }

}