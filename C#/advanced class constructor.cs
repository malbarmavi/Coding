
// the point() ,point(coords) call point(x,y)

class point
{
  public int X { get; set; }
  public int Y { get; set; }

  public point() : this(0, 0)
  {

  }


  public point(int coords) : this(coords, coords)
  {

  }

  public point(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public override string ToString()
  {
    return $"x : {X} , y: {Y}";
  }
}



