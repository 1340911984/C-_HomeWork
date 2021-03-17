class ShapeFactory{//lsp
    public Shape getShape(int Type,params double[]list){ 
        Shape shape = null;
        if(Type == 1){
            shape = new Rect(list[0],list[1]);
        } else{
            shape = new Tria(list[0],list[1],list[2]);
        }
        if(shape.isShape()==false){
            throw (new NotShapeException("Not a Shape"));
        }
        return shape;
    }
}
public class NotShapeException: ApplicationException
{
   public NotShapeException(string message): base(message){}
}
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
              (Length + High -Width)>0&&
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
class Work3_2 {
    static void Main() {
        Random ran=new Random();
        double sum = 0;
        ShapeFactory shapeFactory = new ShapeFactory();
        for(int i = 0 ; i<10 ; i++){
            int Type=ran.Next(0,2);//0是三角，1是正方形
            double Len=ran.Next(-10,100);
            double Width=ran.Next(-5,100);
            double High=ran.Next(0,100);
            try{
                Shape shape = shapeFactory.getShape(Type,Len,Width,High);
                if(Type == 0){
                    Console.Write("type is tria");
                    Console.WriteLine($" + Length={Len} + Width={Width} + High={High}");
                }else{
                    Console.Write("type is rect");
                    Console.WriteLine($" + Length={Len} + Width={Width}");
                }
                sum += shape.getArea();
            }catch(NotShapeException e){
                Console.WriteLine(“******************************************************”);
                Console.WriteLine("Exception caught: {0}", e);
                Console.WriteLine(“******************************************************”);
            }
        }
        Console.WriteLine(sum);          
    }
}




