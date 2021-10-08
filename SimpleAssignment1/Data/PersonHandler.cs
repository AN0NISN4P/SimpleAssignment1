using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace SimpleAssignment1.Data
{
	public class PersonHandler : IPersonHandler
	{
		private static FileContext _fileContext;

		public PersonHandler()
		{
			_fileContext = new();
		}

		public void NewAdult(Adult newAdult)
		{
			int id = _fileContext.Adults.Max(adult => adult.Id);
			newAdult.Id = ++id;
			_fileContext.Adults.Add(newAdult);
			_fileContext.SaveChanges();
		}

		public void RemoveAdult(int id)
		{
			Adult adultToRemove = _fileContext.Adults.First(adult => adult.Id == id);
			int idx = _fileContext.Adults.IndexOf(adultToRemove);
			_fileContext.Adults.RemoveAt(idx);
			_fileContext.SaveChanges();
		}

		public Adult GetAdult(int id)
		{
			return _fileContext.Adults.First(adult => adult.Id == id);
		}

		public IList<Adult> LoadAdults()
		{
			return _fileContext.Adults;
		}
	}
}