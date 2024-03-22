using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtualAgenda.Server.Data;
using VirtualAgenda.Server.Models.Entities;
using VirtualAgenda.Server.Models;

namespace Agenda.Controllers
{
	public class AgendaController : Controller
	{
		private readonly ApplicationDbContext dbContext;

		public AgendaController(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddAgendaViewModel viewModel)
		{
			var agenda = new AgendaCrud
			{
				Name = viewModel.Name,
				Email = viewModel.Email,
				PhoneNumber = viewModel.PhoneNumber,
			};

			await dbContext.Agenda.AddAsync(agenda);
			await dbContext.SaveChangesAsync();

			return RedirectToAction("List");
		}

		[HttpGet]
		public async Task<IActionResult> List()
		{
			var info = await dbContext.Agenda.ToListAsync();
			return View(info);

		}

		[HttpGet]
		public async Task<IActionResult> Edit(Guid id)
		{
			var foundInfo = await dbContext.Agenda.FindAsync(id);

			return View(foundInfo);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(AgendaCrud viewModel)
		{
			var foundInfo = await dbContext.Agenda.FindAsync(viewModel.Id);

			if (foundInfo is not null)
			{
				foundInfo.Name = viewModel.Name;
				foundInfo.Email = viewModel.Email;
				foundInfo.PhoneNumber = viewModel.PhoneNumber;

				await dbContext.SaveChangesAsync();
			}

			return RedirectToAction("List", "Agenda");
		}

		[HttpPost]
		public async Task<IActionResult> Delete(AgendaCrud viewModel)
		{
			var foundInfo = await dbContext.Agenda
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == viewModel.Id);

			if (foundInfo is not null)
			{
				dbContext.Agenda.Remove(viewModel);

				await dbContext.SaveChangesAsync();
			}

			return RedirectToAction("List", "Agenda");
		}
	}
}
