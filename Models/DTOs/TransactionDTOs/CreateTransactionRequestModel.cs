namespace CLASSEM_MVC_PRO.Models.DTOs.TransactionDTOs
{
    public class CreateTransactionRequestModel
    {
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
        public double AmountPaid { get; set; }
        public double SellingPrice { get; set; }
    }
}