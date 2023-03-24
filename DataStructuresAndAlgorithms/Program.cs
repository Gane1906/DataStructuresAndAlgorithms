using System;
namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        static void Main(String[] args)
        {
            /*SearchWord searchWord=new SearchWord();
            searchWord.ReadFile(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\File.txt");*/
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.ReadFile(@"E:\Users\Ganesh\Documents\BL Excercise\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\File.txt");
        }
    }
}