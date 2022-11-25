using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_Copa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/jogo")]
    public class JogoController : ControllerBase
    {
        private readonly Context _context;
        public JogoController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            return Created("", jogo);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Jogo> jogos = _context.Jogos.Include(s => s.SelecaoA).Include(s => s.SelecaoB).ToList();
            return jogos.Count != 0 ? Ok(jogos) : NotFound();
        }

        [HttpPost]
        [Route("palpitar")]
        public IActionResult Palpitar([FromBody] Jogo jogo)
        {
            _context.Jogos.Update(jogo);
            _context.SaveChanges();
            return Ok(jogo);
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            var jogo_encontrado = _context.Jogos.Find(id);
            return Ok(jogo_encontrado);

        }
    }
}