using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class LoadCreditInfo
        {
            public void LoadCreditInfoByClientID(String ClientID)
            {
                String CreditID = "";
                String CreditNumber = "";
                String CreditAmount = "";
                String CreditDate = "";
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут должна быть начитка данных:
                - CreditID (идентификатор для связей)
                - ClientID (идентификатор для связей)
                - CreditNumber (Номер кредитного договора)
                - CreditAmount (Сумма кредита)
                - CreditDate (Дата выдачи кредита)
                 */
                SaveCreditInfo save = new SaveCreditInfo();
                save.SaveCreiditInClientInfoDB(CreditID, ClientID, CreditNumber, CreditAmount, CreditDate);
            }
        }
    }
}
