using System.Xml;
using System.Xml.Linq;

namespace ConductingChecksWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string numbers = "0123456789";

            Console.Write("Adi daxil edin: ");
            string firstName = Convert.ToString(Console.ReadLine()!);
            firstNameMain(firstName, uppercaseLetters, lowerLetters, numbers);

            Console.Write("Soyadi daxil edin: ");
            string lastName = Convert.ToString(Console.ReadLine()!);
            lastNameMain(lastName, uppercaseLetters, lowerLetters, numbers);

            Console.Write("Ata adini daxil edin: ");
            string fatherName = Convert.ToString(Console.ReadLine()!);
            fatherNameMain(fatherName, uppercaseLetters, lowerLetters, numbers);

            Console.Write("Yasi daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine());
            ageMain(age);

            Console.Write("FIN-i daxil edin: ");
            string finCode = Convert.ToString(Console.ReadLine()!);
            finCodeMain(finCode, uppercaseLetters, numbers);

            Console.Write("Telefon nomresini daxil edin: ");
            string phoneNumber = Convert.ToString(Console.ReadLine()!);
            phoneNumberMain(phoneNumber);

            Console.Write("Pozisiyani daxil edin: ");
            string position = Convert.ToString(Console.ReadLine()!);
            positionMain(position);

            Console.Write("Maasi daxil edin: ");
            double salary = Convert.ToDouble(Console.ReadLine()!);
            salaryMain(salary);

            Console.WriteLine("");
            Console.WriteLine("######################################################################################");
            Console.WriteLine("");
            Console.WriteLine("Ad: " + firstName);
            Console.WriteLine("Soyad: " + lastName);
            Console.WriteLine("Ata adi: " + fatherName);
            Console.WriteLine("Yas: " + age);
            Console.WriteLine("FIN kod: " + finCode);
            Console.WriteLine("Telefon: " + phoneNumber);
            Console.WriteLine("Pozisiya: " + position);
            Console.WriteLine("Maas: " + salary);

        }

        static void firstNameMain(string firstName, char[] uppercaseLetters, char[] lowerLetters, string numbers)
        {
            try
            {
                bool check = true;

                if (firstName.Length < 2 || firstName.Length > 20)
                {
                    check = false;
                }
                else
                {
                    for (int i = 0; i < firstName.Length; i++)
                    {
                        for (int j = 0; j < uppercaseLetters.Length; j++)
                        {
                            if (firstName[0] == uppercaseLetters[i] || firstName[0] == lowerLetters[j])
                            {
                                check = false;
                            }
                            else
                            {
                                for (int idx = 1; idx < firstName.Length; idx++)
                                {
                                    if ((firstName[idx] == lowerLetters[j]) && (firstName[idx] == uppercaseLetters[i]))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (firstName[idx] == uppercaseLetters[i] && firstName[idx] == lowerLetters[j])
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (firstName[idx] == numbers[i])
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(firstName);
                }
                else
                {
                    Console.WriteLine("Nese sehv var");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nese sehv var " + ex.Message);
            }
        }

        static void lastNameMain(string lastName, char[] uppercaseLetters, char[] lowerLetters, string numbers)
        {
            try
            {
                bool check = true;

                if (lastName.Length < 2 || lastName.Length > 35)
                {
                    check = false;
                }
                else
                {
                    for (int i = 0; i < lastName.Length; i++)
                    {
                        for (int j = 0; j < uppercaseLetters.Length; j++)
                        {
                            if (lastName[0] == uppercaseLetters[i] || lastName[0] == lowerLetters[j])
                            {
                                check = false;
                            }
                            else
                            {
                                for (int idx = 1; idx < lastName.Length; idx++)
                                {
                                    if ((lastName[idx] == lowerLetters[j]) && (lastName[idx] == uppercaseLetters[i]))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (lastName[idx] == uppercaseLetters[i] && lastName[idx] == lowerLetters[j])
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (lastName[idx] == numbers[i])
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(lastName);
                }
                else
                {
                    Console.WriteLine("Nese sehv var");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nese sehv var " + ex.Message);
            }


        }


        static void fatherNameMain(string fatherName, char[] uppercaseLetters, char[] lowerLetters, string numbers)
        {
            bool check = true;

            try
            {
                if (fatherName.Length < 2 || fatherName.Length > 20)
                {
                    check = false;
                }
                else
                {
                    for (int i = 0; i < fatherName.Length; i++)
                    {
                        for (int j = 0; j < uppercaseLetters.Length; j++)
                        {
                            if (fatherName[0] == uppercaseLetters[i] || fatherName[0] == lowerLetters[j])
                            {
                                check = false;
                            }
                            else
                            {
                                for (int idx = 1; idx < fatherName.Length; idx++)
                                {
                                    if ((fatherName[idx] == lowerLetters[j]) && (fatherName[idx] == uppercaseLetters[i]))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (fatherName[idx] == uppercaseLetters[i] && fatherName[idx] == lowerLetters[j])
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (fatherName[idx] == numbers[i])
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(fatherName);
                }
                else
                {
                    Console.WriteLine("Nese sehv var");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nese sehv var" + ex.Message);
            }

        }

        static void ageMain(int age)
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    if (age >= 18 && age <= 65)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Dogru daxil edilmeyib. ");
                        Console.Write("Tekrar yazin: ");
                        age = Convert.ToInt32(Console.ReadLine()!);
                    }
                }
                catch (Exception)
                {
                    Console.Write("Tekrar yazin: ");
                    age = Convert.ToInt32(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Yas: " + age);
        }


        static void finCodeMain(string finCode, char[] uppercaseLetters, string numbers)
        {
            try
            {
                bool checkNumbers = true;

                for (int i = 0; i < finCode.Length; i++)
                {
                    bool isUpper = false;
                    bool isNumber = false;

                    for (int j = 0; j < uppercaseLetters.Length; j++)
                    {
                        if (finCode[i] == uppercaseLetters[j])
                        {
                            isUpper = true;
                            break;
                        }
                    }

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (finCode[i] == numbers[j])
                        {
                            isNumber = true;
                            break;
                        }
                    }

                    if (!isUpper && !isNumber)
                    {
                        checkNumbers = false;
                        break;
                    }
                }

                if (checkNumbers)
                {
                    Console.WriteLine(finCode);
                }
                else
                {
                    Console.WriteLine("Nese sehv var");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nese sehv var " + ex.Message);
            }

        }

        static void phoneNumberMain(string phoneNumber)
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    if (phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4' && phoneNumber.Length == 13)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Dogru daxil edilmeyib. ");
                        Console.Write("Tekrar yazin: ");
                        phoneNumber = Convert.ToString(Console.ReadLine()!);
                    }

                }
                catch (Exception)
                {
                    Console.Write("Tekrar yazin: ");
                    phoneNumber = Convert.ToString(Console.ReadLine()!);
                }
            }
            Console.WriteLine("Telefon nomresi: " + phoneNumber);
        }

        static void positionMain(string position)
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    if (position == "HR" || position == "Audit" || position == "Engineer")
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Dogru daxil edilmeyib. ");
                        Console.Write("Tekrar yazin: ");
                        position = Convert.ToString(Console.ReadLine()!);
                    }
                }
                catch (Exception)
                {
                    Console.Write("Tekrar yazin: ");
                    position = Convert.ToString(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Pozisiya: " + position);
        }

        static void salaryMain(double salary)
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    if (salary >= 1500 && salary <= 5000)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Dogru daxil edilmeyib. ");
                        Console.Write("Tekrar yazin: ");
                        salary = Convert.ToDouble(Console.ReadLine()!);
                    }
                }
                catch (Exception)
                {
                    Console.Write("Tekrar yazin: ");
                    salary = Convert.ToDouble(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Maas: " + salary);
        }
    }
}