using CubisMobilePortfolio.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubisMobilePortfolio.Services
{
    class ApiMockData
    {
        public List<Meni> GetMenu()
        {
            List<Meni> menuList = new List<Meni>()
            {
                new Meni(){ Id=1, Image="https://i.ibb.co/qB8qvSB/list06.png", Opis="Skadencar", Detalj="Lista polica s istekom važenja ugovora o osiguranju", Poziv="", Rbr=1 },
                new Meni(){ Id=2, Image="https://i.ibb.co/nmLQr0T/list01.png", Opis="Lista polica po suradniku", Detalj="Lista polica koje je suradnik izdao u određenom razdoblju", Poziv="", Rbr=2 },
                new Meni(){ Id=3, Image="https://i.ibb.co/jDpjM6H/list05.png", Opis="Lista polica po partneru", Detalj="Lista polica poslovnog subjekta u određenom razdoblju", Poziv="", Rbr=3 },
                new Meni(){ Id=4, Image="https://i.ibb.co/M8B8BCS/list02.png", Opis="Fakture po dospijeću", Detalj="Dospijeće faktura poslovnog subjekta", Poziv="", Rbr=4 }
            };
            return menuList;
        }
    }
}
