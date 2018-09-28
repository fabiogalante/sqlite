using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtigoSQLite.Data;
using ArtigoSQLite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtigoSQLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly EleicoesDbContext _context;

        public ValuesController(EleicoesDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("ObterCandidatos")]

        public async Task<IEnumerable<Candidato>> Obter()
        {
            return await _context.Candidato.ToListAsync();
        }


        [HttpPost]
        [Route("AdicionarCandidato")]
        public async Task<int> AdicinarPost([FromBody] Candidato candidato)
        {
            await _context.Candidato.AddAsync(candidato);
            await _context.SaveChangesAsync();
            return candidato.Id;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
