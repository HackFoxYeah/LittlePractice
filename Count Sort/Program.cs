public static int[] CountSort(int[] arr)
        {
            int min = arr.Min(),
                max = arr.Max(),
                z = 0; 

            int[] count = new int[max - min + 1];            

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }
            return arr;
        }
    }
