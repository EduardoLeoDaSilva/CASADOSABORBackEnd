using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeClientes.Interfaces.Servicos;
using ControleDeClientes.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ControleDeClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IServicoCliente _servicoCliente;
        public ClienteController(IServicoCliente servicoCliente)
        {
            _servicoCliente = servicoCliente;
        }
        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Cliente cliente)
        {
            if (cliente != null)
            {
                try
                {
                    _servicoCliente.Cadastrar(cliente);
                    return Ok( JsonConvert.SerializeObject("Cadastrado com sucesso!") );
                }
                catch (Exception ex)
                {

                    return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}") );
                }

            }
            return BadRequest("Cliente informado pe nulo" );
        }

        [HttpPost("atualizar")]

        public IActionResult Atualizar(Cliente cliente)
        {
            if (cliente != null)
            {
                try
                {
                    _servicoCliente.Atualizar(cliente);
                    return Ok(JsonConvert.SerializeObject("Atualizado com sucesso!"));
                }
                catch (Exception ex)
                {

                    return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}" ));
                }

            }
            return BadRequest(JsonConvert.SerializeObject("Cliente informado pe nulo" ));
        }

        [HttpPost("deletar")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _servicoCliente.Deletar(id);
                return Ok(JsonConvert.SerializeObject("Deletado com sucesso!" ));
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}" ));
            }
        }

        [HttpGet("obtertodos")]
        public IActionResult ObterTodos()
        {
            try
            {
                var todosClientes = _servicoCliente.ObterTodos();
                return Ok(todosClientes);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }

        [HttpPost("obterporid")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var cliente = _servicoCliente.ObterPeloId(id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }

        [HttpPost("obterportel")]
        public IActionResult ObterPorTel([FromBody]string tel)
        {
            try
            {
                var clientePeloTel = _servicoCliente.ObterPeloTel(tel);
                return Ok(clientePeloTel);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject(JsonConvert.SerializeObject($"Erro: {ex.Message}")));
            }
        }

        [HttpPost("obterpornome")]
        public IActionResult ObterPorNome([FromBody]string nome)
        {
            try
            {
                var clientePeloNome = _servicoCliente.ObterPeloNome(nome);
                return Ok(clientePeloNome);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }

        [HttpPost("obterPorNomeV2")]
        public IActionResult ObterPeloNomeV2([FromBody]string nome)
        {
            try
            {
                var clienteLista = _servicoCliente.ObterPeloNomeV2(nome);
                return Ok(clienteLista);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));

            }
        }
    }
}