using System;
using System.Collections.Generic;
using System.Text.Json;


namespace InfoClient
{
    partial class Program
    {
        class LoadActualInfoFromClientInfoDB
        {
            public JsonSerializer outputJson;
            
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

                    //С помощью ORM будем получать из базы данных модуля результат по запросу через ClientID и раскладывать их в листе ниже
                    var infoClientList = new List<KeyValuePair<string, string>>() { //Значения приведены для примера
                    new KeyValuePair<string, string>("ClientID", "1000010827"),
                    new KeyValuePair<string, string>("FIO", "Иванов Иван Иванович"),
                    new KeyValuePair<string, string>("BirthDate", "15.03.1985"),
                    new KeyValuePair<string, string>("Document", "4100 254313"),
                    new KeyValuePair<string, string>("Address", "Российская Федерация, Москва г., Энтузиастов ш., 37, 101"),
                    new KeyValuePair<string, string>("Telephon", "89291234567"),
                    new KeyValuePair<string, string>("AccountID", "1000777827"),
                    new KeyValuePair<string, string>("AccountNumber", "40817810500000012345"),
                    new KeyValuePair<string, string>("Rest", "15000"),
                    new KeyValuePair<string, string>("DateRest", "04.07.2021"),
                    new KeyValuePair<string, string>("CreditID", "1000778887"),
                    new KeyValuePair<string, string>("CreditNumber", "21/102/223344"),
                    new KeyValuePair<string, string>("CreditAmount", "235000"),
                    new KeyValuePair<string, string>("CreditDate", "01.03.2021"),
                    new KeyValuePair<string, string>("DepositID", "1000701887"),
                    new KeyValuePair<string, string>("DepositNumber", "20/602345"),
                    new KeyValuePair<string, string>("DepositAmount", "80000"),
                    new KeyValuePair<string, string>("DepositDate", "14.05.2020")
                };

                    outputJson.Serialize(infoClientList);
                }
            }
        }
    }
}
