using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Runner/Player Data")]
public class PlayerData : ScriptableObject
{
    public float gravity;
    public float maxXVelocity = 100;
    public float maxAcceleration = 10;
    public float jumpVelocity = 20;
    public float maxHoldJumpTime = 0.4f;
    public float maxMaxHoldJumpTime = 0.4f;
    public float jumpGroundThreshold = 1f;
    public float groundHeight = 10;
}