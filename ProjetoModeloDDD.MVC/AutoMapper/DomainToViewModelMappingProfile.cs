using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoModeloDDD.MVC.ViewModels;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName 
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel,Usuario> ();
            Mapper.CreateMap<DispositivoViewModel,Dispositivo>();
            Mapper.CreateMap<LocalizacaoUsuarioViewModel,LocalizacaoUsuario>();

            
        }
    }
}