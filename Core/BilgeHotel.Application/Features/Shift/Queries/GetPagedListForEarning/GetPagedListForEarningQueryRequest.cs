using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedListForEarning
{
    public class GetPagedListForEarningQueryRequest : DtParameters , IRequest<GetPagedListForEarningQueryResponse>
    {
        //string ıd kısmına eleman ıd sini yollayarak o elemana özel o aylık hak edişi bulabilirsiniz
        //veya searchvalue ya issim girerek arama yapabilirsiniz
    }
}
