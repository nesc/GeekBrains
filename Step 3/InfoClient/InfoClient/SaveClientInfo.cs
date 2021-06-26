using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class SaveClientInfo
        {
            public Boolean SaveClientInfoComplete = false;
            public void SaveClientInfoInClientInfoDB(String ClientID, String FIO, String Birthdate, String Document, String Address, String Telephon)
            {
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут происходит сохранение в базу данных модуля полученной информации*/
                SaveClientInfoComplete = true;
                LoadActualInfoFromClientInfoDB loadActualInfoFromClientInfoDB = new LoadActualInfoFromClientInfoDB();
                loadActualInfoFromClientInfoDB.LoadInfoByClientIDInClientInfoDB(ClientID);
            }
        }
    }
}
