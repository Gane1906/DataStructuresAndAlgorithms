using System;
namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        static void Main(String[] args)
        {
            /*SearchWord searchWord=new SearchWord();
            searchWord.ReadFile(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\File.txt");
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.ReadFile(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\File.txt");
            
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.ReadFile(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\IntegerFile.txt");
            */
            MergeSort mergeSort = new MergeSort();
            mergeSort.ReadFie(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\IntegerFile.txt");
        }
    }
}