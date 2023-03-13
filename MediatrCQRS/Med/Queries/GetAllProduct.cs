using MediatR;

namespace MediatrCQRS.Med.Queries
{
    public class GetAllProduct : IRequest<List<GetProductByIdViewModel>>
    {


        public class GetAllProductQueryHandler : IRequestHandler<GetAllProduct, List<GetProductByIdViewModel>>
        {
            public Task<List<GetProductByIdViewModel>> Handle(GetAllProduct request, CancellationToken cancellationToken)
            {
                var model = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor"
                };

                var model2 = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "book"
                };

                return Task.FromResult(new List<GetProductByIdViewModel>() { model, model2 });
            }
        }
    }
}
