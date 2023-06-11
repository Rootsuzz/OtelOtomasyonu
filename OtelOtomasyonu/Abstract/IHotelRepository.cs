using OtelOtomasyonu.Models;

namespace OtelOtomasyonu.Abstract
{
    public interface IHotelRepository
    {
        List<Odalar> GetAlOdalars();

        Odalar GetOdalarById(int id);

        Odalar CreateOdalar(Odalar odalar);

        Odalar UpdateOdalar(Odalar odalar);

        void DeleteHotel(int id);


    }
}
