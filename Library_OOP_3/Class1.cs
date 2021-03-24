using System;

namespace Library_OOP_3
{
    public class Class1
    {
        private char[] _array;
        private int _size;
        private int _amountOfVowels; //кількість голосних букв
        public Class1(char[] array) //конструктор для початкового запису введеного масиву у закрите поле _array
        {
            _size = array.Length;
            _array = new char[_size];
            for (int i = 0; i < _size; i++)
            {
                _array[i] = array[i];
            }
        }
        public int AmountOfVowels // властивість, яка містить кількість голосних букв у масиві
        {
            get
            {
                int counter = 0;
                for (int i = 0; i < _size; i++)
                {
                    char.ToLower(_array[i]);
                    if ("aeouyi".Contains(_array[i]))
                    {
                        counter++;
                    }
                }
                _amountOfVowels = counter;
                return _amountOfVowels;
            }
        }
        public char this[int index] //індексатор, який у випадку зчитання невалідного індексу пропонує ще раз ввести індекс 
        {
            get 
            {
                try
                {
                    return char.ToUpper(_array[index]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("please, enter a valid index");
                    return '\0';
                }
            }
            set 
            {
                _array[index] = value;
            }
        }
    }
}
