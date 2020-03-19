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
    public class PedidoController : ControllerBase
    {
        private readonly IServicoPedido _servicoPedido;
        public PedidoController(IServicoPedido servicoPedido)
        {
            _servicoPedido = servicoPedido;
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]Pedido pedido)
        {
            if(pedido != null)
            {
                try
                {
                    _servicoPedido.Cadastrar(pedido);
                    return Ok(JsonConvert.SerializeObject("Pedido adicionado!"));
                }
                catch (Exception ex)
                {

                    return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}" ));
                }
                
            }
            return BadRequest(JsonConvert.SerializeObject($"Pedido informado é nulo" ));
        
        }

        [HttpPost("atualizar")]
        public IActionResult Atualizar(Pedido pedido)
        {
            if (pedido != null)
            {
                try
                {
                    _servicoPedido.Atualizar(pedido);
                    return Ok(JsonConvert.SerializeObject("Atualizado com sucesso!" ));
                }
                catch (Exception ex)
                {

                    return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}" ));
                }

            }
            return BadRequest(JsonConvert.SerializeObject("Pedido informado é nulo" ));
        }

        [HttpPost("deletar")]
        public IActionResult Deletar(int id)
        {

                try
                {
                    _servicoPedido.Deletar(id);
                    return Ok(JsonConvert.SerializeObject("Deletado com sucesso!" ));
                }
                catch (Exception ex)
                {

                    return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}" ));
                }

           
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos()
        {
            try
            {
                var todosPedidos = _servicoPedido.ObterTodos();
                return Ok(todosPedidos);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }
        
        [HttpPost("obterPorId")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var pedido = _servicoPedido.ObterPeloId(id);
                return Ok(pedido);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }

        [HttpPost("obterRelatorioPorDia")]
        public IActionResult ObterRelatorioPedidoDia([FromBody]DateTime data)
        {
            try
            {
                var todosPedidoDia = _servicoPedido.ObterOrdensDePedidoDeUmadata(data);
                return Ok(todosPedidoDia);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));
            }
        }

        [HttpPost("ObterQuantPedidoMes")]
        public IActionResult ObterQuantPedidoMes([FromBody]DateTime data)
        {
            try
            {
                var quantPedidoMes = _servicoPedido.ObterQuantidadeDePedidoPelaData(data);
                return Ok(quantPedidoMes);
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));

            }
        }

        [HttpPost("setarPedidoStatus")]
        public IActionResult AlterarStatusPedido([FromBody]Pedido pedido)
        {
            try
            {
                _servicoPedido.SetarStatusPedido(pedido);
                return Ok(JsonConvert.SerializeObject("Status Alterado!"));
            }
            catch (Exception ex)
            {

                return BadRequest(JsonConvert.SerializeObject($"Erro: {ex.Message}"));

            }
        }
    }
}