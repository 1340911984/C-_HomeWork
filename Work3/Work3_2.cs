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
        //Factory的长宽高一开始就应该固定
        double Len=ran.Next(50,100);
        double Width=ran.Next(50,100);
        double High=ran.Next(0,100);
         int Type=ran.Next(0,2);//0是三角，1是正方形
        for(int i = 0 ; i<10 ; i++){
           
            try{
                Shape shape = shapeFactory.getShape(Type,Len,Width,High);
                if(Type == 0){
                    Console.Write("type is triangle ");
                    Console.WriteLine($" + Length={Len} + Width={Width} + High={High}");
                }else{
                    Console.Write("type is rectangle");
                    Console.WriteLine($" + Length={Len} + Width={Width}");
                }
                sum += shape.getArea();
                //只有在正确执行的时候才让Type随机
                Type=ran.Next(0,2);//0是三角，1是正方形
            }catch(NotShapeException e){
                Console.WriteLine("Exception caught: {0}", e);
                //由于我们只有可能三角形出错，所以在MAIN里面相当于我是一个工人发现了三角形每次都制造失败，我就重新定义高度！
                Console.WriteLine($" The wrong triangle is + Length={Len} + Width={Width} + High={High}");
                High=ran.Next(0,100);
                //保证一定有十个图形
                i--;
            }
        }
        Console.WriteLine(sum);          
    }
}
