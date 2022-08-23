


string[] names = { "Daniel", "David", "Ariel","Daniel","Ares"};
string[] names2 = { "John", "Jack" };
int[] numbers = { 1, 3, 5, 7, 9 };
int[] numbers2 = { 2, 4, 5, 7, 9 };

#region 1st Task
//1) bir dizi içerisinde bir eleman birden fazla olup olmadığını kontrol eden bir kod bloğu
Console.WriteLine("1st Task:");
string[] duplicates = names.Distinct().ToArray();
if (duplicates.Length != names.Length)
{
    Console.WriteLine("There are duplicates elements in array");
}
else
{
    Console.WriteLine("There are NOT duplicates elements");
}

//another way:
string[] duplicates2 = Array.FindAll(names, x => x == "Daniel");
//or:
//string[] duplicates = employees.Where(x => x == "Daniel").ToArray();
if (duplicates2.Length > 1)
{
    Console.WriteLine("There are more than one Daniel in array");
}
else
{
    Console.WriteLine("There is only one Daniel in array");
}
#endregion

#region 2nd Task
//2) dizi içerisinde bir elemanın var olup olmadığını kontrol ediniz, bu değer bool tipinde olacak
Console.WriteLine($"\n2nd Task:");
bool result = Array.Exists(names, x => x == "David");
Console.WriteLine($"Is there this element in array-->{result}");
//another way with int result:
//int index = Array.BinarySearch(names,"David");
//if (index < 0) Console.WriteLine("There is no David in array");
#endregion

#region 3rd Task
//3) içerisinde birden fazla eleman tanımladığınız dizi içerisindeki elemanları, for, foreach, while, do-while döngüsü kullanmadan ekrana yazdırınız
Console.WriteLine($"\n3rd Task:");
Array.ForEach(names, Console.WriteLine);
//another way:
string str = names.Aggregate((x, y) => x + "," + y);
Console.WriteLine(str);
#endregion

#region 4th Task
//4) metinsel bir dizi içerisindeki değerlerde, verdiğiniz değer ile başlayan tüm elemanları ekrana yazdırınız.
Console.WriteLine($"\n4th Task:");
string[] spesific = Array.FindAll(names, x => x.Contains("Ar"));
if (spesific.Length > 0) Array.ForEach(spesific, Console.WriteLine);
#endregion

#region 5th Task
//5) var olan 2 dizinin elemanlarını ekrana yazdırınız.
Console.WriteLine($"\n5th Task:");
string twoArrayStr = names.Aggregate((x, y) => x + "," + y)+","+ names2.Aggregate((x, y) => x + "," + y);
Console.WriteLine(twoArrayStr);
//another way NOT OPTIMAL:
//int[] combined = new int[numbers.Length + numbers2.Length];
//Array.Copy(numbers, combined, numbers.Length);
//Array.Copy(numbers2, 0, combined, numbers.Length, numbers2.Length);
//Array.ForEach(combined,Console.WriteLine); 
#endregion

#region 6th Task
//6) sayısal 2 dizi içerisinde yer alan farklı elemanları yeni bir diziye, aynı olanları yeni bir diziye ekleyiniz.
Console.WriteLine($"\n6th Task:");
int[] differences = numbers.Except(numbers2).ToArray().Concat(numbers2.Except(numbers)).ToArray();
int[] commons = numbers.Intersect(numbers2).ToArray();
Console.WriteLine("Different Elements:");
Array.ForEach(differences, Console.WriteLine);
Console.WriteLine("Same Elements:");
Array.ForEach(commons, Console.WriteLine); 
#endregion
