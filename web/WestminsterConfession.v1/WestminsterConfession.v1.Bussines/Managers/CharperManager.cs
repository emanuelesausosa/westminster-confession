using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.Bussines.DTOs;
using WestminsterConfession.v1.DB;
using WestminsterConfession.v1.DB.Entities;

namespace WestminsterConfession.v1.Bussines.Managers
{
    public class CharperManager
        :Manager
    {
        public CharperManager(IDBFactory dBFactory)
            :base(dBFactory)
        {

        }

        /// <summary>
        ///  Get all Charpers on Db
        /// </summary>
        /// <returns></returns>
        public async Task<Charper[]> GetAllCharpers()
        {
            using (var db = NewCoreDbContext())
            {
               return await db.Charpers.ToArrayAsync();
            }
        }

        /// <summary>
        /// Add new charper on db
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> AddNewCharper(DTOCharper model) {
            if(model == null)
                return false;

            var entity = new Charper() {
                NumberPosition = model.NumberPosition,
                Resume = model.Resume,
                RomanNumber = model.RomanNumber,
                Title = model.Title
            };

            try
            {
                using (var db = NewCoreDbContext())
                {
                    db.Charpers.Add(entity);
                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
