using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class LoadClientInfo
        {
            public void LoadClientInfoByClientID(String ClientID)
            {
                String FIO = "";
                String Birthdate = "";
                String Document = "";
                String Address = "";
                String Telephon = "";
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут должна быть начитка данных:
                - ClientID (идентификатор для связей)
                - FIO (Фамилия имя отчество)
                - Birthdate (Дата рождения)
                - Document (Документ удостоверяющий личность)
                - Address (Адрес без разбивки на сущности)
                - Telephon (Контактный телефон)
                 */
                SaveClientInfo save = new SaveClientInfo();
                save.SaveClientInfoInClientInfoDB(ClientID, FIO, Birthdate, Document, Address, Telephon);
            }
        }
    }
}
