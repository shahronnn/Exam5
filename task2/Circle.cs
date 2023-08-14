namespace task2;

public class Circle: Point
{
    protected const double pi=3.14;
    Point center;
    double radius=1.0;
    
    public Circle()
    {

    }
    public Circle( int xCenter, int  yCenter, double radius)
    {
        base.SetX(xCenter);
        base.SetY(yCenter);
        this.radius = radius;
    }
    public Circle(Point center, double radius)
    {
        this.center = center;
        this.radius = radius;
    }
    public double GetRadius()=> this.radius;
    public void SetRadius(double radius)=> this.radius = radius;
    public Point GetCenter()=> this.center;
    public void SetCenter(Point center)=> this.center = center;
    public int GetCenterX()=> base.getX();
    public void SetCenterX(int x)=> base.SetX(x);
    public int GetCenterY()=> base.getY();
    public void SetCenterY(int y)=> this.center.SetY(y);
    
    public override string ToString()=> $"Circle[center={base.getX}, {base.getY}]";
    public double GetArea()=> pi*Math.Pow(this.radius, 2);
    public double GetCircumFerence()=> 2*pi*this.radius;

}
