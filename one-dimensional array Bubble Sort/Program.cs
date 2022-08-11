public static int[] BubbleSort(int[] array)
        {
            int temp;

            int[] arrCopy = array;

            for (int i = 0; i < arrCopy.Length; i++)
            {
                for (int j = 0; j < arrCopy.Length - (1 + i); j++)
                {
                    if (arrCopy[j] > arrCopy[j + 1])
                    {
                        temp = arrCopy[j];
                        arrCopy[j] = arrCopy[j + 1];
                        arrCopy[j + 1] = temp;
                    }
                }                
            }

            return arrCopy;
        }
