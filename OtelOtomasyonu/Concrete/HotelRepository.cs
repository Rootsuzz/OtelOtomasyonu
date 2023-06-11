using OtelOtomasyonu.Abstract;
using OtelOtomasyonu.Models;
using OtelOtomasyonu.Data;

namespace OtelOtomasyonu.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        private readonly MyContext _context;
        public Odalar CreateOdalar(Odalar odalar)
        {
            _context.Odalars.Add(odalar);
            _context.SaveChanges();
            return odalar;
        }

        public void DeleteHotel(int OdaId)
        {
            var deleteOda= GetOdalarById(OdaId);
            _context.Odalars.Remove(deleteOda);
            _context.SaveChanges();
        }

        public List<Odalar> GetAlOdalars()
        {
             return _context.Odalars.ToList();
            
        }

        public Odalar GetOdalarById(int OdaId)
        {
            return _context.Odalars.Find(OdaId);
        }

        public Odalar UpdateOdalar(Odalar odalar)
        {
            _context.Odalars.Update(odalar);
            return odalar;

        }
    }
}
