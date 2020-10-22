using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.MapProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<SubCategoryAndCategoryViewModel, Category>()
                .ForMember(vm => vm.Name, s => s.MapFrom(source => source.SubCategory.Name));
        }
    }
}
