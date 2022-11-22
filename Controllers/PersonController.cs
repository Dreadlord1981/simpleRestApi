using Microsoft.AspNetCore.Mvc;
using simpleRestApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace simpleRestApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		// GET: api/<PersonController>
		[HttpGet]
		public IEnumerable<Person> Get()
		{
			List<Person> list = new List<Person>()
			{
				new Person()
				{
					Name = "Peter",
					Age = 40,
					Sex = "Male"
				}
			};

			return list;
		}

		// GET api/<PersonController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<PersonController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<PersonController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PersonController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
