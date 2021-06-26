using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class SaveDepositInfo
        {
            public Boolean SaveDepositInfoComplete = false;
            public void SaveDepositInClientInfoDB(String DepositID, String ClientID, String DepositNumber, String DepositAmount, String DepositDate)
            {
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут происходит сохранение в базу данных модуля полученной информации*/
                SaveDepositInfoComplete = true;
                LoadActualInfoFromClientInfoDB loadActualInfoFromClientInfoDB = new LoadActualInfoFromClientInfoDB();
                loadActualInfoFromClientInfoDB.LoadInfoByClientIDInClientInfoDB(ClientID);
            }
        }
    }
}
