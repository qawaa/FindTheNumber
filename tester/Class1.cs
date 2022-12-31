using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Class1
    {
        int userNumber;
        int _pcNumber;
        string result;
        bool correctly;

        public Class1(int pcNumber)
        {
            _pcNumber = pcNumber;
        }

        public Class1 NumberSearch(int userNumber)
        {
            this.userNumber = userNumber;
            correctly = false;

            CreateCompareTwoResult();

            return this;
        }
        public string ReturnResult()
        {
            return result;
        }
        public bool GetSuccess()
        {
            return correctly;
        }
        private void CreateCompareTwoResult()
        {
            if (_pcNumber == userNumber)
            {
                result = "Числа равны!";
                correctly = true;
            }
            else
            {
                if (userNumber > _pcNumber)
                {
                    if (userNumber / _pcNumber >= 10)
                    {
                        result = "Много больше!";

                    }
                    if (userNumber / _pcNumber >= 2 && userNumber / _pcNumber < 10)
                    {
                        result = "Больше!";
                    }
                    if (userNumber / _pcNumber < 2)
                    {
                        result = "Немного больше!";
                    }
                }
                else
                {
                    if (_pcNumber / userNumber >= 10)
                    {
                        result = "Много меньше!";

                    }
                    if (_pcNumber / userNumber >= 2 && _pcNumber / userNumber < 10)
                    {
                        result = "Меньше!";
                    }
                    if (_pcNumber / userNumber < 2)
                    {
                        result = "Немного меньше!";
                    }
                }
            }
        }

    }
}

