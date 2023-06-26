using UnityEngine;

public interface IInput
{
    public Vector2 Direction { get; }
    public void ReadInput();
}
