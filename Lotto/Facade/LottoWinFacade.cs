using Lotto.Model;
using Lotto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Facade
{
    public class LottoWinFacade
    {
        private LottoJsonRepository lottoJsonRepository = new LottoJsonRepository();

        public List<Win> getLottoWinList()
        {
            return lottoJsonRepository.selectLottoJson();
        }

        public Win getLottoWin(int round)
        {
            return lottoJsonRepository.selectLottoJson()
                .Find(x => x.round == round);
        }

        public Win getLottoWinLast()
        {
            return lottoJsonRepository.selectLottoJson().LastOrDefault();
        }

        public void setLottoWinList(List<Win> input)
        {
            lottoJsonRepository.createLottoJson(input);
        }
    }
}
