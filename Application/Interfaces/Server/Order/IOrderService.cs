using Common.ServiceResponse;
using Domain.Entities.Order;

namespace Application.Interfaces.Server.Order
{
    public interface IOrderService
    {
        Task<ResultDto<bool>> PlaceOrder();
        Task<ResultDto<List<OrderOverviewResponse>>> GetOrders();
        Task<ResultDto<OrderDetailsResponse>> GetOrderDetails(int orderId);
    }
}
