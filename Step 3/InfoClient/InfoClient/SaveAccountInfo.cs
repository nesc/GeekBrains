using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class SaveAccountInfo
        {
            public Boolean SaveAccountInfoComplete = false;
            public void SaveAccountInClientInfoDB(String AccountID, String ClientID, String AccountNumber, String Rest, String DateRest)
            {
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут происходит сохранение в базу данных модуля полученной информации*/
                SaveAccountInfoComplete = true;
                LoadActualInfoFromClientInfoDB loadActualInfoFromClientInfoDB = new LoadActualInfoFromClientInfoDB();
                loadActualInfoFromClientInfoDB.LoadInfoByClientIDInClientInfoDB(ClientID);
            }
        }
    }
}
