using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class LoadDepositInfo
        {
            public void LoadDepositInfoByClientID(String ClientID)
            {
                String DepositID = "";
                String DepositNumber = "";
                String DepositAmount = "";
                String DepositDate = "";
                InfoClientMain loader = new InfoClientMain();
                loader.LoadSettings();
                /*Тут должна быть начитка данных:
                - DepositID (идентификатор для связей)
                - ClientID (идентификатор для связей)
                - DepositNumber (Номер депозитного договора)
                - DepositAmount (Сумма депозита)
                - DepositDate (Дата выдачи депозита)
                 */
                SaveDepositInfo save = new SaveDepositInfo();
                save.SaveDepositInClientInfoDB(DepositID, ClientID, DepositNumber, DepositAmount, DepositDate);
            }
        }
    }
}
