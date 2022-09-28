// See https://aka.ms/new-console-template for more information
using System;
using AutoMapper;
using Mappy.Model;
using Mappy.ViewModel;

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<User, UserViewModel>()
        .ForMember(destination => destination.OverallName,
        source => source.MapFrom(src => src.FullName));
});
IMapper mapper = config.CreateMapper();

User myClass = new User()
{
    Id = 1,
    FullName = "Edward Garcia",
    Gender = "Male"
};

UserViewModel usr = mapper.Map<User, UserViewModel>(myClass);

Console.WriteLine($"The name is {usr.OverallName}");

Console.WriteLine("Hello, World!");

void InitializeAutomapper()
{
    
    //Mapper.CreateMap<User, UserViewModel>();
}