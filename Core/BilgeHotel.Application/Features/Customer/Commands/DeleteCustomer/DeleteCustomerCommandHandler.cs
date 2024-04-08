using BilgeHotel.Application.Repositories.CustomerRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Customer.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public DeleteCustomerCommandHandler(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new DeleteCustomerCommandResponse();
            var result = await _customerWriteRepository.Remove(request.Id);
            var save = await _customerWriteRepository.SaveAsync();
            if (save == 0)
            {
                response.Message = "Kaydeterken hata";
                return response;
            }
            if (result != true)
            {
                response.Message = "silinirken hata";
                return response;
            }
            response.Message = "işlem başarılı";
            return response;
            #region old
            //var response = new DeleteCustomerCommandResponse();
            //var entity = await _customerReadRepository.GetByIdAsync(request.Id);
            //if (entity == null)
            //{
            //    response.Message = "Müşteri bulunamadı";
            //    return response;
            //}
            //entity.IsDeleted = true;
            //var result = await _customerWriteRepository.Update(entity);
            //if (result== false)
            //{
            //    response.Message = "silinirken hata";
            //    return response;
            //}
            //response.Message = "silme başarılı";
            //return response; 
            #endregion
        }
    }
}
