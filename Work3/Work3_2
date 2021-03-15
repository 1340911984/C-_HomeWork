class ShapeFactory{
    protected double Length;
    protected double Width;
    protected double High;
    public void setLength(double len){
        this.Length = len;
    }
    public void setWidth(double width){
        this.Width = width;
    }
    public void setHigh(double high){
        this.High = high;
    }
    public ShapeFactory getShape(int Type,double Len, double Width,double High){    
        if(Type == 1){
            return new Rect(Len,Width);
        } else{
            return new Tria(Len,Width,High);
        }
    }
    virtual public double getArea(){
        return 0;
    }
}
interface ShapeWork{
    bool isShape();
}

class Rect : ShapeFactory,ShapeWork{
    public Rect(double len, double width){
        this.setLength(len);
        this.setWidth(width);
    }
    public bool isShape(){
        return(Length*Width>0);
    }
    override public double getArea(){
        if(this.isShape() == false){
            return 0;
        }
        return Length*Width;
    }
}
class Tria : ShapeFactory,ShapeWork{
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
    override public double getArea(){
        if(this.isShape() == false){
            return 0;
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
            ShapeFactory shape = shapeFactory.getShape(Type,Len,Width,High);
            if(Type == 0){
                Console.Write("type is tria");
                Console.WriteLine($" + Length={Len} + Width={Width} + High={High}");
            }else{
                Console.Write("type is rect");
                Console.WriteLine($" + Length={Len} + Width={Width}");
            }
            if(shape.getArea()==0){
                Console.WriteLine($"Worong data");
                Console.WriteLine();
                continue;
            }else{
                Console.WriteLine($"Area is {shape.getArea()}");
                Console.WriteLine();
                sum += shape.getArea();
            }
        }
        Console.WriteLine(sum);          
    }
}
