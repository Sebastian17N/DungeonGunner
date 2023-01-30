using System;
using UnityEngine;

[DisallowMultipleComponent]
public class MovementToPositionEvent : MonoBehaviour
{
    public event Action<MovementToPositionEvent, MovementToPositionArgs> OnMovementToPosition;

    public void CallMovementToPositionEvent(Vector3 movePosition, Vector3 currentPositon,
        float moveSpeed, Vector3 moveDirection, bool isRolling)
    {
        OnMovementToPosition?.Invoke(this, new MovementToPositionArgs()
        {
            movePosition = movePosition,
            currentPositon = currentPositon,
            moveSpeed = moveSpeed,
            moveDirection = moveDirection,
            isRolling = isRolling
        });
    }

}

public class MovementToPositionArgs: EventArgs
{
    public Vector3 movePosition;
    public Vector3 currentPositon;
    public float moveSpeed;
    public Vector3 moveDirection;
    public bool isRolling;
}