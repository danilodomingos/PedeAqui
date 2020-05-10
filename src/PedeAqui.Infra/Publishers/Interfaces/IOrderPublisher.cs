using PedeAqui.Infra.Publishers.Request;

namespace PedeAqui.Infra.Publishers.Interfaces
{
    public interface IOrderPublisher
    {
         void OrderCreated(PostOrderRequest request);
    }
}