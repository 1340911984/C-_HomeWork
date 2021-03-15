class Shape{
    protected double Length;
    protected double Width;
    protected double High;
    public Shape(){}
    public void setLength(double len){
        this.Length = len;
    }
    public void setWidth(double width){
        this.Width = width;
    }
    public void setHigh(double high){
        this.High = high;
    }
}
interface ShapeWork{
    bool isShape();
    double getArea();
}
class Rect : Shape,ShapeWork{
    public Rect(double len, double width){
        this.setLength(len);
        this.setWidth(width);
    }
    public bool isShape(){
        return(Length*Width>0);
    }
    public double getArea(){
        if(this.isShape() == false){
            return -1;
        }
        return Length*Width;
    }
}
class Tria : Shape,ShapeWork{
    public Tria(double Len, double Width,double High){
        this.setLength(Len);
        this.setWidth(Width);
        this.setHigh(High);
    }
    public bool isShape(){
        return((Length*Width*High>0)&&
              (Length - Width -High)*
              (Width - Length -High)*
              (High - Width -Length)<0
              );
    }
    public double getArea(){
        if(this.isShape() == false){
            return -1;
        }
        double temp;
        temp = (Length + Width + High) / 2;
        return Math.Sqrt(temp*
                         (temp - Length)*
                         (temp - Width)*
                         (temp - High));
    }
}
class Work3_1 {
    static void Main() {
        Rect a = new Rect(2.2,3.3);
        Tria b = new Tria(1,1,1.414);
        if(a.getArea()>0){
            Console.WriteLine(a.getArea());
        }
        else{
            Console.WriteLine("Wrong Rect");
        }
        if(b.getArea()>0){
            Console.WriteLine(b.getArea());
        }
        else{
            Console.WriteLine("Wrong Tria");
        }
    }
}
