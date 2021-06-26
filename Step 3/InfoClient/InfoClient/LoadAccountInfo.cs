using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class LoadAccountInfo
        {
            public void LoadAccountInfoByClientID(String ClientID)
            {
                String AccountID = "";
                String AccountNumber = "";
                String Rest = "";
                String DateRest = "";
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут должна быть начитка данных:
                - AccountID (идентификатор для связей)
                - ClientID (идентификатор для связей)
                - AccountNumber (Номер счета)
                - Rest (Остаток)
                - DateRest (Дата остатка)
                 */
                SaveAccountInfo save = new SaveAccountInfo();
                save.SaveAccountInClientInfoDB(AccountID, ClientID, AccountNumber, Rest, DateRest);
            }
        }
    }
}
