using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_evm
{
    internal class From10toAny
    {

        List<int> mod = new List<int>();//Список остатков от деления 
        List<int> div = new List<int>();//Список целочисленного деления


        //Функция расчёта числа в новом основании
        private void BaseDigitConvert(string Number, string Base)
        {
            int _num = Convert.ToInt16(Number);
            int _base = Convert.ToInt16(Base);
            //Начало заполнения списков
            div.Add(_num); //В список целочисленного деления запишем наше число
            mod.Add(_num % _base); //В список остатков от деления сразу запишем остаток от деления нашего числа на новое основание

            //Цикл основного пересчёта
            do
            {
                div.Add(div.Last() / _base); //В список целочисленного деления запишем целую часть от деления
                                             //последнего элемента из списка целочисленного деления на новое основание

                mod.Add(div.Last() % _base); //В список остатков от деления запишем остаток от деления
                                             //последнего элемента из списка целочисленного деления на новое основание
            }
            while (div.Last() / _base >= _base - 1); //Цикл работает, пока целая часть от деления последнего элемента из списка целочисленного деления
                                                     //на новое основание не меньше максимальной цифры в новом основании

            //Проверка на первый символ
            if (div.Last() / _base != 0)
            {
                mod.Add(div.Last() / _base); //В список остатков от деления запишем целую часть от деления
                                             //последнего элемента из списка целочисленного деления на новое основание
            }

            //Разворот списка остатков от деления
            mod.Reverse();

            //Проверка на наличие нуля в начале
            if (mod.First() == 0)
            {
                mod.RemoveAt(0);//Убираем ноль в начале
            }
        }

        //Функция вывода числа в новом основании
        public string OutPut(string Number, string Base)
        {
            string output = "";
            BaseDigitConvert(Number, Base);
            //Цикл перебора чисел в списке остатков от деления и их правильный вывод 
            foreach (int key in mod)
            {
                switch (key)
                {
                    case 10:
                        output += "A";
                        break;
                    case 11:
                        output += "B";
                        break;
                    case 12:
                        output += "C";
                        break;
                    case 13:
                        output += "D";
                        break;
                    case 14:
                        output += "E";
                        break;
                    case 15:
                        output += "F";
                        break;
                    default:
                        output += key;
                        break;
                }
            }
            return output;
        }
    }

}
