using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFFeature2Dal : GenericRepository<Feature>, IFeature2Dal
	{
		public void Delete(Feature2 t)
		{
			throw new NotImplementedException();
		}

		public void Insert(Feature2 t)
		{
			throw new NotImplementedException();
		}

		public void Update(Feature2 t)
		{
			throw new NotImplementedException();
		}

		List<Feature2> IGenericDal<Feature2>.GetList()
		{
			throw new NotImplementedException();
		}
	}
}
