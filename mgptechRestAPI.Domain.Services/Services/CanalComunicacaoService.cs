using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class CanalComunicacaoService :BaseService<CanalComunicacao>, ICanalComunicacaoService
    {
        private readonly ICanalComunicacaoRepository _canalComunicacaoRepository;

    public CanalComunicacaoService(ICanalComunicacaoRepository canalComunicacaoRepository) 
            : base(canalComunicacaoRepository)
    {
            _canalComunicacaoRepository = canalComunicacaoRepository;
    }
}
}
