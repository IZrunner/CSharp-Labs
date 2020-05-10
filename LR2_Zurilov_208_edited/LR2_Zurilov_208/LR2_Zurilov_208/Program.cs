using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Zurilov_208
{
    class Program
    {
        
        public class Sandbox
        {
            public void ShoutOut()
            {
                Console.WriteLine("CAPS LOCK POWER!!!");
            }
            public void ShowProtected()
            {
                Console.WriteLine($"Let him protect you from evil : ");
                ProtectMe();
            }
            public void ShowPrivate()
            {
                Console.WriteLine($"We've found some private message : ");
                HiddenMessage();
            }


            protected void ProtectMe()
            {
                Console.WriteLine("A Noble Knight In Shiny Arms");
            }

            protected internal string Name = "SandboxMaster";

         
            private void HiddenMessage()
            {
                Console.WriteLine("Don't tell anybody, pleeease");
            }

            //private protected string hiddenTreasure = "Maximum Privacy";

            ~Sandbox() { } //Object.Finalize
        }

        public class Padawan : Sandbox
        {

            public void LetItBe()
            {
                Console.WriteLine("I'll just leave it here");
            }
            /*
            private void WorkWithPrivateProtected()
            {
                Padawan unit = new Padawan();
                unit.hiddenTreasure = "Luke";
            }
            */
            private void WorkWithProtectedInternal()
            {
                Padawan unitOne = new Padawan();
                unitOne.Name = "SandpaperMaster";
            }

            ~Padawan() { }
        }
        

        internal class LocalParty // internal types  or members are accesible only within this assembly
        {
            public void ShowInvite()
            {
                Invite();
            }           

            private void Invite ()            
            {
                Console.WriteLine("If you are reading this, you are invited to the secret party");
            }
            ~LocalParty() { }
        }
       

        static int Main()
        {
            /*
            Завдання:
                Створіть застосунок для демонстрації в коді наступних можливостей:
                1.	Роботу з масивами(одновимірним (+), двовимірним прямокутним (+) та двовимірним невирівняним () ). Студенти з парними номерами y варіанті 
                підраховують суму елементів масивів, з непарними- добуток. Розмір масиву підраховується програмно. ()
                2.	За допомогою оператора foreach знайдіть в масиві елемент із заданим значенням(значення вводиться з клавіатури). (+)
                3.	Продемонструйте роботу основних методів класу Object ()
                4.	Продемонструйте використання модифікаторів доступу в межах однієї збірки. (+)
                5.	*Додаткове завдання: використання модифікатору private protected (+)
            */
            int prodOneDim = 1, prodMatrixRectangle = 1, prodMatrixJagged = 1; // jagged array is an array whose elements are arrays

            Console.WriteLine("Type of products in all arrays is {0}", prodOneDim.GetType()); // Object.GetType()
            object oneO = null;
            object twoO = null;
            object threeO = new LocalParty();

            Console.WriteLine(LocalParty.ReferenceEquals(oneO, twoO));
            twoO = threeO;
            Console.WriteLine(LocalParty.ReferenceEquals(twoO, threeO));
            Console.WriteLine(LocalParty.ReferenceEquals(oneO, threeO));

            LocalParty objSMPL = new LocalParty();
            Console.WriteLine(objSMPL.ToString());


            //////////////////////////////////////////////////////////////////////

            /*
            Console.Write("Enter the size of the 1-D array : ");
            string sizeOneDTMP =  Console.ReadLine();
            int sizeOneD = int.Parse(sizeOneDTMP);
           
            Console.Write("Enter the value you want to find in the 1-D array : ");
            string valueSearchTMP = Console.ReadLine();
            int valueSearch = int.Parse(valueSearchTMP);
            

            Console.WriteLine("");
            int[] arrOneDim = new int[sizeOneD]; // 1-D array
            Random someRandOneD = new Random();
            for(int i = 0; i < sizeOneD; i++)
            {
                arrOneDim[i] = someRandOneD.Next(-20, 21);             
                Console.Write($"{arrOneDim[i]} ");                
                if(i % 4 == 0)
                {
                    Console.WriteLine("");
                }
                prodOneDim = arrOneDim[i] * prodOneDim;
            }
            Console.WriteLine("");
            Console.WriteLine($"\nProduct of all elements in the array is {prodOneDim}");


            foreach(int element in arrOneDim) // foreach for 1-D array
            {
                if(element == valueSearch)
                {
                    Console.WriteLine($"\nCoinsidence!!! Your value {valueSearch} matches the value {element} in this array");
                    break;
                }
                else
                {
                    Console.WriteLine("\nWell, maybe next time");
                    break;
                }
            }
            */

            //////////////////////////////////////////////////////////////////////

            /*
            Console.Write("\nEnter the lines of the 2-D (rechtangle) matrix : "); // 2-D matrix (rechtangle)
            string sizeMatrixTMPOne = Console.ReadLine();

            Console.Write("Enter the columns of the 2-D (rechtangle) matrix : ");
            string sizeMatrixTMPTwo = Console.ReadLine();

            int sizeMatrixLine = int.Parse(sizeMatrixTMPOne);
            int sizeMatrixColumn = int.Parse(sizeMatrixTMPTwo);
            int[,] arrMatrixRechtangle = new int[sizeMatrixLine, sizeMatrixColumn];
            Random someRandMatrixOne = new Random();


            for (int i = 0; i < sizeMatrixLine; i++)
            {
                for(int j = 0; j < sizeMatrixColumn; j++)
                {
                    arrMatrixRechtangle[i,j] = someRandMatrixOne.Next(-20, 21);                    
                    Console.Write(String.Format("{0,3}", arrMatrixRechtangle[i, j]));
                    prodMatrixRectangle = arrMatrixRechtangle[i, j] * prodMatrixRectangle;
                }                
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine($"\nProduct of all elements in the (rechtangle) matrix is {prodMatrixRectangle}");
            */

            //////////////////////////////////////////////////////////////////////

            /*
            Console.Write("\nEnter the amount of arrays in the jagged array : "); // jagged array MUST_FINISH_LATER
            string sizeJaggedTMP = Console.ReadLine();

            Console.Write("Enter the camount of elements in each array : ");
            string sizeArrInJaggedTMP = Console.ReadLine();

            int sizeJagged = int.Parse(sizeJaggedTMP);
            int sizeArrInJagged = int.Parse(sizeArrInJaggedTMP);
            int[][] arrJagged = new int[sizeJagged][];
            Random someRandMatrixTwo = new Random();
            */

            /*
            for(int i = 0; i < arrJagged.Length; i++)
            {
                for(int j = 0; j < arrJagged[i].Length; j++)
                {
                    arrJagged[i][j] = someRandMatrixTwo.Next(-20, 21);
                    //Console.Write("{0}{1}", arrJagged[i][j], j == (arrJagged[i].Length - 1) ? "" : " ");
                }
            }
            */

            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[5] {1,2,3,4,5};
            jaggedArr[1] = new int[4] {3,5,7,9};
            jaggedArr[2] = new int[3] {11,13,15};
            int minLength = jaggedArr[0].Length;
            

            for(int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element ({0}): ", i);
                for(int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedArr[i][j], j == (jaggedArr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                if (jaggedArr[i].Length < minLength)
                {
                    minLength = jaggedArr[i].Length;
                }
            }
            Console.WriteLine($"Minimal length is {minLength}");
            Console.WriteLine();

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element ({0}): ", i);
                for (int j = 0; j < minLength; j++)
                {
                    Console.Write("{0}{1}", jaggedArr[i][j], j == (jaggedArr[i].Length - 1) ? "" : " "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // add min and max value methods
            /*
            int i = 0, j = 0;
            int minValue = jaggedArr[i][j];
            int maxValaue = jaggedArr[i][j];


            for (i = 0; i < jaggedArr.Length; i++)
            {
                
                Console.Write("Element({0}): ", i);
                for (j = 0; j < minLength; j++)
                {
                    if(jaggedArr[i][j] < minValue)
                    {
                        minValue = jaggedArr[i][j];
                    }
                    Console.Write("Min value = {0}", minValue);
                    
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();
            */


            //////////////////////////////////////////////////////////////////////

            Console.ReadKey();
            return 0;
        }
    }
}