namespace Lab3;

public class PointDException:Exception
{
    public PointDException(){}
    public PointDException(string message):base(message){}
    public PointDException(string message, Exception e): base(message,e){}
}