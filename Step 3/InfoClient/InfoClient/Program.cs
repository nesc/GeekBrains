using System;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        static void Main(string[] args)
        {
            String ClientID = "";
            Console.WriteLine("Введите ClientID     //Для упрощения тестов примем на веру, что параметр приходит из вне, а не пользователь его вводит");
            ClientID = Console.ReadLine(); //Для упрощения тестов примем на веру, что параметр приходит из вне, а не пользователь его вводит

            InfoClientMain infoClientMain = new InfoClientMain();
            infoClientMain.LoadSettings();
            infoClientMain.LoadInfo(ClientID);
        }
    }
}
