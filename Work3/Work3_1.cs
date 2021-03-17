abstract class Shape{//抽象
    abstract public bool isShape();
    abstract public double getArea();
}
class Rect : Shape{
   double len;
   double width;
   public double Length{
        get{return len;}
        set{ len = value;}
     }
   public double Width{
        get{return width;}
        set{ width = value;}
   }
    public Rect(double len, double width){
        this.Length = len;
        this.Width = width;
    }
    override public bool isShape(){
        return(Length*Width>0);
    }
    override public double getArea(){
        if(this.isShape() == false){
            return -1;
        }
        return Length*Width;
    }
}
class Tria : Shape{
   double len;
   double width;
   double high;
   public double Length{
        get{return len;}
        set{ len = value;}
     }
   public double Width{
        get{return width;}
        set{ width = value;}
   }
   public double High{
        get{return high;}
        set{ high = value;}
   }
    public Tria(double Len, double Width,double High){
        this.Length=(Len);
        this.Width=(Width);
        this.High=(High);
    }
    override public bool isShape(){
        return((Length*Width*High>0)&&
              (Length + Width -High)>0&&
              (Width + Length -High)>0&&
              (High + Width -Length)>0
              );
    }
    override public double getArea(){
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
