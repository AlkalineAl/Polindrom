
bool CheckList(ref LinkedListNode<int>? first, ref LinkedListNode<int>? last)
{

    if (first != last || first?.Next != last?.Previous)
    {
        if (first?.Value == last?.Value)
        {
            var temp1 = first?.Next;
            var temp2 = last?.Previous;
            return CheckList(ref temp1, ref temp2);
        }
        return false;

    }
    else if (first?.Next == last?.Previous)
    {
        if (first?.Value == last?.Value)
        {
            return true;
        }
        return false;

    }
    else
    {
        return true;
    }
}

var ints = new LinkedList<int>(new[] { 1, 2, 3, 4, 5, 6, 4, 3, 2, 1 });
var temp1 = ints.First;
var temp2 = ints.Last;
Console.WriteLine(CheckList(ref temp1, ref temp2));