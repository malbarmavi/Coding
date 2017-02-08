
//http://stackoverflow.com/questions/4588787/how-to-create-array-with-sequence-of-integers-in-c


var seq = Enumerable.Range(0, 10);

IEnumerable<int> Sequence(int n1, int n2)
{
  while (n1 <= n2)
  {
    yield return n1++;
  }
}