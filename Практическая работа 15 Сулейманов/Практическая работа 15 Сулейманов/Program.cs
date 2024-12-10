using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_15_Сулейманов
{
    internal class Program
    {
        public static void ExeptionWrite(string extext) // вывод сообщения ошибок
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(extext);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        static bool YesOrNo(string text) // опрос с ответом да(Y) или нет(N) но можно свой вопрос задать
        {
            string ReadedSymbol = string.Empty;
            while (true)
            {
                try
                {
                    Console.Write(text + " да(Y) или нет(N)");
                    ReadedSymbol = Console.ReadLine();
                    if (ReadedSymbol == string.Empty)
                    {
                        ExeptionWrite("Вы не ввели символ");
                        continue;
                    }
                    else
                    {
                        if (ReadedSymbol == "y") { return true; }
                        else
                        {
                            if (ReadedSymbol == "n") { return false; }
                            else
                            {
                                if (ReadedSymbol == "Y") { return true; }
                                else
                                {
                                    if (ReadedSymbol == "N") { return false; }
                                    else
                                    {
                                        ExeptionWrite("Вы ввели не тот символ");
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (FormatException fx)
                {
                    ExeptionWrite(fx.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    ExeptionWrite(ex.Message);
                    continue;
                }
            }
        }
        static string WriteAndRead(string text) // вывод тектса запроса и ввод ответа
        {
            string ReadedText = string.Empty;
            while (true)
            {
                bool isnoex = false;
                try
                {
                    Console.Write(text);
                    ReadedText = Console.ReadLine();
                    if (ReadedText == string.Empty)
                    {
                        ExeptionWrite("Вы не ввели текст");
                        continue;
                    }
                    isnoex = true;
                }
                catch (FormatException fx)
                {
                    isnoex = false;
                    ExeptionWrite(fx.Message);
                }
                catch (Exception ex)
                {
                    isnoex = false;
                    ExeptionWrite(ex.Message);
                }
                if (isnoex)
                {
                    break;
                }
            }
            return ReadedText;
        }
        class Animal
        {
            string species;
            string name;
            string age;
            bool gender;
            public Animal(string species_, string name_, string age_, bool gender_)
            {
                species = species_;
                name = name_;
                age = age_;
                gender = gender_;
            }
            public string GetSpecies() { return species; }
            public string GetName() { return name; }
            public string GetAge() { return age; }
            public bool GetGender() { return gender; }
            public void SetSpecies(string species_) {  species = species_; }
            public void SetName(string name_) {  name = name_; }
            public void SetAge(string age_) {  age = age_; }
            public void SetGender(bool gender_) {  gender = gender_; }
        }
        static void Main(string[] args)
        {

        }
    }
}
