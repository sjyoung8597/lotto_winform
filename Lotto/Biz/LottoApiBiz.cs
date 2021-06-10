using Lotto.Facade;
using Lotto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Biz
{
    public class LottoApiBiz
    {
        public Win getLottoApi(int round)
        {
            LottoApiFacade lottoApiFacade = new LottoApiFacade();
            return lottoApiFacade.getLottoData(round);
        }
    }
}
