namespace Delivery.Backend.DTO
{
    public class StateResponse<T>
    {
        public int Code { get; set; }
        public string? Massage { get; set; }
        public T Data { get; set; }

    }
}
