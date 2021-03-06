﻿using AutoMapper;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Application.AutoMapper.Mapping
{
    public class DomainToView : Profile
    {
        public DomainToView()
        {
            CreateMap<Customer, CustomerViewModel>()
                .ForPath(v => v.Name, m => m.MapFrom(dm => dm.Name))
                .ForPath(v => v.FullName, m => m.MapFrom(dm => dm.FullName))
                .ForPath(v => v.Id, m => m.MapFrom(dm => dm.GuiId))
                .ForPath(v => v.Type, m => m.MapFrom(dm => dm.Phone.EPhoneType))
                .ForPath(v => v.Cpf, m => m.MapFrom(dm => dm.Document.Cpf))
                .ForPath(v => v.RG, m => m.MapFrom(dm => dm.Document.RG))
                .ForPath(v => v.BirthDate, m => m.MapFrom(dm => dm.BirthDate))
                .ForPath(v => v.DDD, m => m.MapFrom(dm => dm.Phone.DirectDistanceDialing))
                .ForPath(v => v.Number, m => m.MapFrom(dm => dm.Phone.Number))
                .ReverseMap();

            CreateMap<TelephoneLine, PhoneViewModel>()
                .ForPath(v => v.DDD, m => m.MapFrom(dm => dm.DirectDistanceDialing))
                .ForPath(v => v.Number, m => m.MapFrom(dm => dm.Number))
                .ForPath(v => v.Type, m => m.MapFrom(dm => dm.EPhoneType))
                .ForPath(v => v.CustomerId, m => m.MapFrom(dm => dm.CustomerId))
                .ForPath(v => v.Id, m => m.MapFrom(dm => dm.Id))
                .ReverseMap();

            CreateMap<Plan, PlanViewModel>()                
                .ForPath(v => v.Origin, m => m.MapFrom(dm => dm.EOrigin))
                .ForPath(v => v.Destiny, m => m.MapFrom(dm => dm.EDestiny))
                .ForPath(v => v.PlanCode, m => m.MapFrom(dm => dm.EPlanCode))                
                .ForPath(v => v.StartTime, m => m.MapFrom(dm => dm.StartTime))
                .ForPath(v => v.EndTime, m => m.MapFrom(dm => dm.EndTime))
                .ReverseMap();
        }
    }
}
