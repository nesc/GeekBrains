using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class LoadActualInfoFromClientInfoDB
        {
            public void LoadInfoByClientIDInClientInfoDB(String ClientID)
            {
                SaveClientInfo saveClientInfo = new SaveClientInfo();
                SaveAccountInfo saveAccountInfo = new SaveAccountInfo();
                SaveCreditInfo saveCreditInfo = new SaveCreditInfo();
                SaveDepositInfo saveDepositInfo = new SaveDepositInfo();
                if (saveClientInfo.SaveClientInfoComplete == true
                  & saveAccountInfo.SaveAccountInfoComplete == true
                  & saveCreditInfo.SaveCreditInfoComplete == true
                  & saveDepositInfo.SaveDepositInfoComplete == true)
                {
                    InfoClientMain loader = new InfoClientMain();
                    loader.LoadSettings();
                    /*Тут происходит начитка данных по CLientID из базы данных модуля*/
                    /*А тут будет возврат ответа пользователю с набором собранных данных по клиенту*/

                }
            }
        }
    }
}
