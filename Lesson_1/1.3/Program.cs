int number = int.Parse(Console.ReadLine()!); //a = -6
int count = -number; //count = 6
    Console.Write(count + " ");
while (count!=number){
    if (number>0)
    count++;//count=count+1
    else
    count--;//count=count-1
    Console.Write(count + " ");
}