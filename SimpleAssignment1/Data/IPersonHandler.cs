﻿using System.Collections;
using System.Collections.Generic;
using Models;

namespace SimpleAssignment1.Data
{
	public interface IPersonHandler
	{
		void NewAdult(Adult newAdult);
		void RemoveAdult(int id);
		Adult GetAdult(int id);
		IList<Adult> LoadAdults();
	}
}