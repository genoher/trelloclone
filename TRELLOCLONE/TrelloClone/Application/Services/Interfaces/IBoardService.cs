﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloClone.Models;

namespace Application.Services.Interfaces
{
	public interface IBoardService : IService<Board>
	{
		Task<IEnumerable<Board>> GetAllBoardsForUserAsync(long id);
		Task EditBoardVisibilityAsync (Board board);
	}
}
