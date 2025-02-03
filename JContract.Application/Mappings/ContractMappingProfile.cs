
using AutoMapper;
using JContract.Application.Contract;
using JContract.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JContract.Application.Mappings
{
    public class ContractMappingProfile : Profile
    {
        public ContractMappingProfile() 
        {
            CreateMap<ContractDto, Domain.Entities.Contract>()
                    .ForMember(e => e.ContactDetails, opt => opt.MapFrom(src => new ContactDetails()
                    {
                        City = src.City,
                        PhoneNumber = src.PhoneNumber,
                        PostalCode = src.PostalCode,
                        Street = src.Street,

                    }));

            CreateMap<Domain.Entities.Contract, ContractDto>()
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.ContactDetails.Street))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.ContactDetails.City))
                .ForMember(dto => dto.PostalCode, opt => opt.MapFrom(src => src.ContactDetails.PostalCode))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.ContactDetails.PhoneNumber));


        }
    }
}
