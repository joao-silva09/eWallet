using AutoMapper;
using eWallet.API.Services.DividaService;
using eWallet.API.Services.ObjetivoService;
using eWallet.API.Services.OperacaoService;
using eWallet.API.Services;
using eWallet.Services.IDividaService;
using eWallet.API.DTOs.Conta;
using eWallet.API.DTOs.Divida;
using eWallet.API.DTOs.Objetivo;
using eWallet.API.DTOs.Operacao;
using eWallet.Domain.Models;

namespace eWallet.API.Configurations
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {

                config.CreateMap<Conta, GetContaDto>();
                config.CreateMap<AddContaDto, Conta>();

                config.CreateMap<Divida, GetDividaDto>();
                config.CreateMap<AddDividaDto, Divida>();

                config.CreateMap<Objetivo, GetObjetivoDto>();
                config.CreateMap<AddObjetivoDto, Objetivo>();

                config.CreateMap<Operacao, GetOperacaoDto>();
                config.CreateMap<AddOperacaoDto, Operacao>();
            });
            return mappingConfig;
        }
    }
}
