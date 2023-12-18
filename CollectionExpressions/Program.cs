int[] oldWayArray = new int[] { 1, 2, 3, 4 };
int[] oldWayEmpty = Array.Empty<int>();
List<int> oldWayList = new List<int>() { 1,3,4};

//Fun begins

int[] funWayArray = [5, 6, 7];
int[] funWayEmpty = [];
List<int> funWayList = [7,8,9];


// Lets become Python developers in c#
int[] numbers1 = [1, 2, 3];
int[] numbers2 = [4, 5, 6];
int[] numbersTogetherOldWay = numbers1.Concat(numbers2).Concat(new int[] {11,12}).ToArray();
//int[] numbersTogetherOldWay = numbers1.Concat(numbers2).Concat([12,13]).ToArray();
// :(



//foreach (int number in numbersTogetherOldWay)
//{
//    Console.WriteLine(number);
//}

int[] numbersTogetherFunWay = [..numbers1, ..numbers2, 44, 55, 66];

foreach (int number in numbersTogetherFunWay)
{
    Console.WriteLine(number);
}

//List<int> someListNumber = numbers1.Concat(numbers2).Concat(new int[] { 11, 12 }).ToArray();
List<int> arrayToList = [..numbers1, 23,..numbers2];

foreach (int number in arrayToList)
{
    Console.WriteLine(number);
}



