using Lotto.Biz.StatisticsBiz;
using Lotto.Facade;
using Lotto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Biz
{
    public class MyNumBiz
    {
        public List<MyNum> getMyNumList()
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            return myNumFacade.getMyNumList();
        }

        /// <summary>
        /// 내 번호 convert Win
        /// </summary>
        /// <returns></returns>
        public List<Win> getConvertMyNumList()
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            return myNumFacade.getMyNumList().Select(x => new Win() {
                drwtNo1 = x.drwtNo1,
                drwtNo2 = x.drwtNo2,
                drwtNo3 = x.drwtNo3,
                drwtNo4 = x.drwtNo4,
                drwtNo5 = x.drwtNo5,
                drwtNo6 = x.drwtNo6
            }).ToList();
        }

        public void setMyNum(MyNum input)
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            List<MyNum> myNumList = getMyNumList();
            myNumList.Add(input);
            myNumFacade.setMyNumList(myNumList);
        }

        public void delMyNum(int idx)
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            List<MyNum> myNumList = getMyNumList().Select(x => x).Where(x => x.idx != idx).ToList();
            
            List<MyNum> result = new List<MyNum>();
            int resetIdx = 1;

            foreach(MyNum myNum in myNumList)
            {
                myNum.idx = resetIdx++;
                result.Add(myNum);
            }
            myNumFacade.setMyNumList(result);
        }

        public List<BindingMyNum> getBindingMyNumList()
        {
            List<BindingMyNum> result = new List<BindingMyNum>();
            List<MyNum> myNumList = getMyNumList();
            myNumList.Reverse();

            foreach (MyNum win in myNumList)
            {
                result.Add(bindingMyNum(win));
            }
            return result;
        }

        public BindingMyNum bindingMyNum(MyNum myNum)
        {
            List<int> myNumList = getMyNums(myNum.drwtNo1, myNum.drwtNo2, myNum.drwtNo3, myNum.drwtNo4, myNum.drwtNo5, myNum.drwtNo6);
            int grade = getWinGrade(myNum.round, myNumList);
            BindingMyNum result = new BindingMyNum();
            result.idx = myNum.idx;
            result.round = myNum.round;
            result.drwtNo = StringHelperBiz.getWinNums(myNum);
            result.winSuccess = StringHelperBiz.getWinGrade(grade, grade != -1 ? getWinNums(myNum.round, myNumList) : new List<int>());
            result.drwNoDate = myNum.drwNoDate;
            return result;
        }

        /// <summary>
        /// 내번호 중 맞는 번호들 리턴
        /// </summary>
        /// <param name="round"></param>
        /// <param name="myNumList"></param>
        /// <returns></returns>
        public List<int> getWinNums(int round, List<int> myNumList)
        {
            List<int> result = new List<int>();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            Win win = lottoWinBiz.getLottoWin(round);
            if (win != null)
            {
                int bnusNo = win.bnusNo;
                List<int> winNums = lottoWinBiz.getLottoWinNums(round);

                foreach (int winNum in winNums)
                {
                    foreach (int myNum in myNumList)
                    {
                        if (winNum == myNum)
                        {
                            result.Add(myNum);
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 라운드 별 등수 계산
        /// </summary>
        /// <param name="round"></param>
        /// <param name="myNumList"></param>
        /// <returns></returns> -1 = 발표전 , 0 = 미당첨 , 1,2,3,4,5 = 등수
        public int getWinGrade(int round, List<int> myNumList)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            Win win = lottoWinBiz.getLottoWin(round);
            return getWinGrade(win, myNumList);
        }

        public int getWinGrade(Win win, List<int> myNumList)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            if (win != null)
            {
                int bnusNo = win.bnusNo;
                List<int> winNums = lottoWinBiz.getLottoWinNums(win);
                int gradeCount = 0;
                bool isBnusNo = false;

                foreach (int winNum in winNums)
                {
                    foreach (int myNum in myNumList)
                    {
                        if (bnusNo == myNum)
                        {
                            isBnusNo = true;
                        }
                        if (winNum == myNum)
                        {
                            gradeCount++;
                        }
                    }
                }
                if (gradeCount == 6)
                {
                    return 1;
                }
                else if (gradeCount == 5)
                {
                    if (isBnusNo)
                    {
                        return 2;
                    }
                    return 3;
                }
                else if (gradeCount == 4)
                {
                    return 4;
                }
                else if (gradeCount == 3)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }

        public void loginInfoCheck(string id, int selected)
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            List<LoginInfo> lgoinInfoList = myNumFacade.getLoginInfoList();
            LoginInfo alreadyId = lgoinInfoList.Find(x => x.id == id);
            if(alreadyId != null)
            {
                updateLoginInfo(id);
            }
            else
            {
                insertLoginInfo(id);
            }

        }

        public List<LoginInfo> getLoginInfoList()
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            return myNumFacade.getLoginInfoList();
        }

        public string getLoginId()
        {
            return getLoginInfoList().Find(x => x.selected == 1).id;
        }
        public List<string> getBindingIdList()
        {
            return getLoginInfoList().Select(x => x.id).ToList();
        }
        public void setLoginInfo(List<LoginInfo> input)
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            myNumFacade.setLoginInfoList(input);
        }

        public void updateLogout()
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            List<LoginInfo> loginInfoList = myNumFacade.getLoginInfoList();
            List<LoginInfo> input = new List<LoginInfo>();
            foreach (LoginInfo loginInfo in loginInfoList)
            {
                loginInfo.selected = 0;
                input.Add(loginInfo);
            }
            setLoginInfo(input);
        }

        public void insertLoginInfo(string id)
        {
            updateLogout();
            MyNumFacade myNumFacade = new MyNumFacade();
            List<LoginInfo> loginInfoList = myNumFacade.getLoginInfoList();
            loginInfoList.Add(new LoginInfo(id, 1));
            setLoginInfo(loginInfoList);
        }

        public void updateLoginInfo(string id)
        {
            MyNumFacade myNumFacade = new MyNumFacade();
            List<LoginInfo> loginInfoList = myNumFacade.getLoginInfoList();
            List<LoginInfo> input = new List<LoginInfo>();
            foreach (LoginInfo loginInfo in loginInfoList)
            {
                if(loginInfo.id == id)
                {
                    loginInfo.selected = 1;
                }
                else
                {
                    loginInfo.selected = 0;
                }
                input.Add(loginInfo);
            }
            setLoginInfo(input);
        }

        public string insertAndMessageMyNum(int round, int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6)
        {
            StatisticsBaseBiz staticsBiz = new StatisticsBaseBiz();
            List<int> myNumList = getMyNums(drwtNo1, drwtNo2, drwtNo3, drwtNo4, drwtNo5, drwtNo6);
            if (staticsBiz.checkDuplicationWinNo(myNumList))
            {
                myNumList.Sort();
                MyNumFacade myNumFacade = new MyNumFacade();
                MyNum lastMyNum = myNumFacade.getMyNumLast();
                int lastIdx = 1;
                if (lastMyNum != null)
                {
                    lastIdx = lastMyNum.idx + 1;
                }
                MyNum input = new MyNum(lastIdx, round, myNumList);
                setMyNum(input);

                return StringHelperBiz.myNumInsertComplete(true);
            }
            else
            {
                return StringHelperBiz.myNumInsertComplete(false);
            }
        }
        public List<int> getMyNums(int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6)
        {
            List<int> result = new List<int>();
            result.Add(drwtNo1);
            result.Add(drwtNo2);
            result.Add(drwtNo3);
            result.Add(drwtNo4);
            result.Add(drwtNo5);
            result.Add(drwtNo6);
            result.Sort();
            return result;
        }
    }
}
