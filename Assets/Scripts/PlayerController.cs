using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer;

    private Rigidbody player;
    private InputHandler inputHundler;
    private Vector2 touchDeltaPosition;
    private Vector3 directionPlayer;


    private void Start()
    {
        player = GetComponent<Rigidbody>();
        inputHundler = GetComponent<InputHandler>();
    }

    private void FixedUpdate()
    {
        MovedPlayer();
    }

    private void MovedPlayer()
    {
        if (inputHundler.IsThereTouchOnScreen())
        {
            touchDeltaPosition = inputHundler.GetTouchDeltaPosition();
            directionPlayer = new Vector3(-touchDeltaPosition.x, 0, -touchDeltaPosition.y);

            player.AddForce(directionPlayer * speedPlayer);
        }
    }
}
