using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class InfoClientMain
        {
            public String AbsDBHostname = "";
            public String AbsDBName = "";
            public String AbsDBUser = "";
            public String AbsDBPassword = "";
            public String ClientInfoDBHostname = "";
            public String ClientInfoDBName = "";
            public String ClientInfoDBUser = "";
            public String ClientInfoDBPassword = "";
            public void LoadSettings()
            {
                AbsDB absDB = new AbsDB();
                absDB.GetAbsDBSettings();
                ClientInfoDB clientInfoDB = new ClientInfoDB();
                clientInfoDB.GetClientInfoDBSettings();
                AbsDBHostname = absDB.AbsDBHostname;
                AbsDBName = absDB.AbsDBName;
                AbsDBUser = absDB.AbsDBUser;
                AbsDBPassword = absDB.AbsDBPassword;
                ClientInfoDBHostname = clientInfoDB.ClientInfoDBHostname;
                ClientInfoDBName = clientInfoDB.ClientInfoDBName;
                ClientInfoDBUser = clientInfoDB.ClientInfoDBUser;
                ClientInfoDBPassword = clientInfoDB.ClientInfoDBPassword;
            }
            public void LoadInfo(String ClientID)
            {
                LoadClientInfo loadClientInfo = new LoadClientInfo();
                loadClientInfo.LoadClientInfoByClientID(ClientID);
                LoadAccountInfo loadAccountInfo = new LoadAccountInfo();
                loadAccountInfo.LoadAccountInfoByClientID(ClientID);
                LoadCreditInfo loadCreditInfo = new LoadCreditInfo();
                loadCreditInfo.LoadCreditInfoByClientID(ClientID);
                LoadDepositInfo loadDepositInfo = new LoadDepositInfo();
                loadDepositInfo.LoadDepositInfoByClientID(ClientID);
            }
        }
    }
}
