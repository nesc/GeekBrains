using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class SaveCreditInfo
        {
            public Boolean SaveCreditInfoComplete = false;
            public void SaveCreiditInClientInfoDB(String CreditID, String ClientID, String CreditNumber, String CreditAmount, String CreditDate)
            {
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут происходит сохранение в базу данных модуля полученной информации*/
                SaveCreditInfoComplete = true;
                LoadActualInfoFromClientInfoDB loadActualInfoFromClientInfoDB = new LoadActualInfoFromClientInfoDB();
                loadActualInfoFromClientInfoDB.LoadInfoByClientIDInClientInfoDB(ClientID);
            }
        }
    }
}
