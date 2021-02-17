using System;
using System.Collections.Generic;
using System.Text;

namespace week_1
{
    class ResizableIntArray
    {
        int[] mStorage = new int[10];
        int mCurrentIndex = 0;
        public void Add(int pNumber)
        {
            mStorage[mCurrentIndex] = pNumber;
            mCurrentIndex++;
            if (IsFull())
            {
                ExpandStorage(10);
            }
        }
        public void ExpandStorage(int pSizeIncrease)
        {
            int[] increasedStorage = new int[mCurrentIndex + pSizeIncrease];
            for (int i = 0; i < mCurrentIndex; i++)
            {
                increasedStorage[i] = mStorage[i];
            }
            mStorage = increasedStorage;
        }
        public bool IsFull()
        {
            if (mCurrentIndex < mStorage.Length)
            {
                return false;
            }
            return true;
        }
        public void WriteContentsToConsole()
        {
            for (int i = 0; i < mCurrentIndex; i++)
            {
                Console.WriteLine(mStorage[i]);
            }
        }
        public string Average()
        {
            int Av = 0;
            for (int i = 0; i < mCurrentIndex; i++)
            {
                Av += mStorage[i];
            }
            Av = Av / mCurrentIndex;
            return Av.ToString();
        }
        public string Min()
        {
            int min = mStorage[0];
            for (int i = 1; i < mCurrentIndex; i++)
            {
                if (mStorage[i] < min)
                {
                    min = mStorage[i];
                }
            }
            return min.ToString();
        }
        public string Max()
        {
            int max = mStorage[0];
            for (int i = 1; i < mCurrentIndex; i++)
            {
                if (mStorage[i] > max)
                {
                    max = mStorage[i];
                }
            }
            return max.ToString();
        }
        public void Ascending() // insertion sort
        {
            for (int i = 1; i < mCurrentIndex; i++)
            {
                int val = mStorage[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < mStorage[j])
                    {
                        mStorage[j + 1] = mStorage[j];
                        j--;
                        mStorage[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("Ascending numbers:");
            for (int i = 0; i < mCurrentIndex; i++)
            {
                Console.WriteLine(mStorage[i]);
            }
        }
        public void Descending() // insertion sort
        {
            for (int i = 1; i < mCurrentIndex; i++)
            {
                int val = mStorage[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val > mStorage[j])
                    {
                        mStorage[j + 1] = mStorage[j];
                        j--;
                        mStorage[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("Descending numbers:");
            for (int i = 0; i < mCurrentIndex; i++)
            {
                Console.WriteLine(mStorage[i]);
            }
        }
    }
}
