using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float depth = 1;

    Player player;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void FixedUpdate()
    {
        float realVelocity = player.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -34)
            pos.x = 92;
            
        transform.position = pos;

    }
}
