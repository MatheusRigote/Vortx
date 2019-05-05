using AutoMapper;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Application.AutoMapper.Mapping
{
    public class ViewToDomain : Profile
    {
        public ViewToDomain()
        {
            CreateMap<CustomerViewModel, Customer>()
                .ForPath(m => m.Name, v => v.MapFrom(vm => vm.Name))
                .ForPath(m => m.FullName, v => v.MapFrom(vm => vm.FullName))
                .ForPath(m => m.Document.Cpf, v => v.MapFrom(vm => vm.Cpf))
                .ForPath(m => m.Document.RG,  v => v.MapFrom(vm => vm.RG))
                .ForPath(m => m.Phone.Number, v => v.MapFrom(vm => vm.Number))
                .ForPath(m => m.Phone.EPhoneType, v => v.MapFrom(vm => vm.Type))
                .ForPath(m => m.BirthDate, v => v.MapFrom(vm => vm.BirthDate))
                .ForPath(m => m.Phone.DirectDistanceDialing, v => v.MapFrom(vm => vm.DDD))
                .ReverseMap();

            CreateMap<PhoneViewModel, TelephoneLine>()
                .ForPath(m => m.Id, v => v.MapFrom(vm => vm.Id))
                .ForPath(m => m.CustomerId, v => v.MapFrom(vm => vm.CustomerId))
                .ForPath(m => m.DirectDistanceDialing, v => v.MapFrom(vm => vm.DDD))
                .ForPath(m => m.EPhoneType, v => v.MapFrom(vm => vm.Type))
                .ForPath(m => m.Number, v => v.MapFrom(vm => vm.Number))
                .ReverseMap();

            CreateMap<PlanViewModel, Plan>()
                .ForPath(m => m.EPlanCode, v => v.MapFrom(vm => vm.PlanCode))     
                .ForPath(m => m.EDestiny, v => v.MapFrom(vm => vm.Destiny))
                .ForPath(m => m.EOrigin, v => v.MapFrom(vm => vm.Origin))
                .ForPath(m => m.StartTime, v => v.MapFrom(vm => vm.StartTime))
                .ForPath(m => m.EndTime, v => v.MapFrom(vm => vm.EndTime))                
                .ReverseMap();
        }
    }
}
