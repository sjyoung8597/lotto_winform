using Lotto.Model;
using Lotto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Facade
{
    public class MyNumFacade
    {
        private MyJsonRepository myJsonRepository = new MyJsonRepository();

        public List<MyNum> getMyNumList()
        {
            return myJsonRepository.selectJson();
        }

        public MyNum getMyNum(int idx)
        {
            return myJsonRepository.selectJson()
                .Find(x => x.idx == idx);
        }

        public void setMyNumList(List<MyNum> input)
        {
            myJsonRepository.createJson(input);
        }

        public MyNum getMyNumLast()
        {
            return myJsonRepository.selectJson().LastOrDefault();
        }

        public List<LoginInfo> getLoginInfoList()
        {
            return myJsonRepository.selectIdJson();
        }

        public void setLoginInfoList(List<LoginInfo> input)
        {
            myJsonRepository.createIdJson(input);
        }

        public LoginInfo getLoginInfoLast()
        {
            return myJsonRepository.selectIdJson().LastOrDefault();
        }
    }
}
