using Lotto.Model;
using Lotto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Facade
{
    public class LottoApiFacade
    {
        public Win getLottoData(int round)
        {
            Win result = getLottoApi(round);
            if (result == null)
            {
                result = getLottoApi2(round);
                //result = getLottoParsing(round);
            }
            return result;
        }
        public Win getLottoApi(int round)
        {
            WebServiceRepository webServiceRepository = new WebServiceRepository();
            return webServiceRepository.getLottoWinApi(round);
        }

        public Win getLottoParsing(int round)
        {
            WebServiceRepository webServiceRepository = new WebServiceRepository();
            return webServiceRepository.getLottoParsing(round);
        }

        public Win getLottoApi2(int round)
        {
            WebServiceRepository webServiceRepository = new WebServiceRepository();
            return webServiceRepository.getLottoWinApi2(round);
        }
    }
}
