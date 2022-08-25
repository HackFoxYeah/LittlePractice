//Нужно проверить, является ли число двойкой в степени.

private static bool PowerOfTwo(int value)
        {
            if (value <= 0)
            {
                return false;
            }

            return ((value & (value - 1)) == 0);
        }
