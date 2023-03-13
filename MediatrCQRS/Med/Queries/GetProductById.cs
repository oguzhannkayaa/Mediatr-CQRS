using MediatR;

namespace MediatrCQRS.Med.Queries
{
    public class GetProductById : IRequest<GetProductByIdViewModel>
    {
        public Guid Id { get; set; }
    }
}
