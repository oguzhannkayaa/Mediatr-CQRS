using MediatR;

namespace MediatrCQRS.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductById, GetProductByIdViewModel>
    {
        public Task<GetProductByIdViewModel> Handle(GetProductById request, CancellationToken cancellationToken)
        {

            var res = new GetProductByIdViewModel()
            {
                Id = request.Id,
                Name = "Book"
            };
                
            return Task.FromResult(res);

            //Get Product From Repository request.Id

        }
    }
}
