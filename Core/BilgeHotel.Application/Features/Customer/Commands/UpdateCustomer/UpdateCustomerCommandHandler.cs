using BilgeHotel.Application.Repositories.CustomerRepositories;
using Mapster;
using MediatR;

namespace BilgeHotel.Application.Features.Customer.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public UpdateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }
        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new UpdateCustomerCommandResponse();

            
            var entityToUpdate = request.Customer.Adapt<BilgeHotel.Domain.Entities.Customer>();

            
            bool updatedSuccessfully = await _customerWriteRepository.Update(entityToUpdate);
            var save = await _customerWriteRepository.SaveAsync();
            if (save == 0)
            {
                response.Message = "Kaydeterken hata";
                return response;
            }

            if (updatedSuccessfully)
            {
                response.Message = "Başarılı";
            }
            else
            {
                response.Message = "Güncelleme esnasında hata oluştu";
            }

            return response;
        }
    }
}
