public interface IInput 
{
    public float Vertical { get;}
    public float Horizontal { get;}
    public float MouseX { get;}
    public float MouseY { get;}

    public void ReadInput();
}
