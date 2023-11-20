using MediatR;
using MediatrExample.Models;
using System.Xml.Linq;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel {   Id = Guid.NewGuid(), Name = "Book" };

            return Task.FromResult(viewModel);
        }
    }
}
