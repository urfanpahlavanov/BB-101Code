

namespace Urfancodeacademy
{
    public class BuilderString
    {
        private char[] _arr;

        public int Capacity { get; set; }

        public BuilderString()
        {
            Capacity = 0;

            _arr = new char[Capacity];

        }
        public BuilderString(int capasity)
        {
            Capacity = capasity;
            _arr = new char[Capacity];
        }
        public void Append(char symbol)
        {
            if (Capacity == 0)
            {
                Capacity = 16;
                Array.Resize(ref _arr, Capacity);
            }
            if (_arr[Capacity - 1] != 0)
            {
                Capacity *= 2;
                Array.Resize(ref _arr, Capacity);
                _arr[Capacity / 2] = symbol;
                return;
            }
            for (int i = 0; i < Capacity; i++)
            {
                if (_arr[i] == 0)
                {
                    _arr[i] = symbol;
                    break;

                }
            }
        }
        public BuilderString Replace(char oldValue,char newValue)
        {
            for(int i=0; i<Capacity; i++)
            {
                if(_arr[i] ==0) break;

                if (_arr[i] == oldValue)
                {
                    _arr[i] = newValue;
                }

            }
            return this;    
            
        }
        public BuilderString Remove(char symbol)
        {
            string result1 = string.Empty;
            char[] arr = { };
            for(int i = 0; i < Capacity; i++)
            {
                if (_arr[i] == 0) break;
                if (_arr[i]==symbol)
                {
                    continue;

                    arr[i] += _arr[i];
                  
                  
                }
                else
                {
                    arr[i] += _arr[i];
                }
            }
            return this;
            

        }
       
        
        public override string ToString()
        {
            string result = string.Empty;
            foreach (char item in _arr)
            {
                if (item == 0) break;
                result += item;
            }
            return result;
        }
    }
}
