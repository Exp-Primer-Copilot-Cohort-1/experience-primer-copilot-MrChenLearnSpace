
public class QuickSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return;
        
        QuickSortHelper(arr, 0, arr.Length - 1);
    }

    private static void QuickSortHelper(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int pivot = arr[left];
        int i = left + 1;
        int j = right;

        while (i <= j)
        {
            if (arr[i] > pivot && arr[j] < pivot)
            {
                Swap(arr, i, j);
                i++;
                j--;
            }
            else
            {
                if (arr[i] <= pivot)
                    i++;
                if (arr[j] >= pivot)
                    j--;
            }
        }

        Swap(arr, left, j);

        QuickSortHelper(arr, left, j - 1);
        QuickSortHelper(arr, j + 1, right);
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
