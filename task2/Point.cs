namespace task2;

public class Point
{
    int x=0;
    int y=0;


    public Point(){}
    public Point(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public int getX()=> this.x;
    public int getY()=> this.y;
    public void SetX(int x)=> this.x=x;
    public void SetY(int y)=> this.y=y;
    public override string ToString()=> $"{this.x}, {this.y}";
    public void SetXY(int x, int y)
    {
        this.SetXY(x, y);
    }
    public double Distance(int x, int y)=> Math.Sqrt(Math.Pow(2,(this.x-x)+Math.Pow(2,(this.y-y))));
}
