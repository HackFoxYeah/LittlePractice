public static int BinarySearch(int[] array, int target)
        {
            int left = 0,
                pivot,
                right = array.Length - 1;

            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (array[pivot] == target) return pivot;
                if (target < array[pivot]) right = pivot - 1;
                else left = pivot + 1;
            }

            return -1;
        }
