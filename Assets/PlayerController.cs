using DefaultNamespace;
using Fusion;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField]
    private float speed = 5f;

    public override void FixedUpdateNetwork()
    {
        if (!GetInput(out NetworkInputData input))
            return;

        Vector3 direction = new Vector3(
            input.Direction.x,
            input.Direction.y,
            0f
        );

        transform.position +=
            direction * speed * Runner.DeltaTime;
    }
}
