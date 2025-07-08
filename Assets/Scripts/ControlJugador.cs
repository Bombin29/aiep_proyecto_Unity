using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    private Rigidbody2D playerBody;
    public AudioClip jumpSoundClip;
    public AudioSource audioSource;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var horizontalSpeed = horizontalInput * 5.0f;
        playerBody.velocity = new Vector2(horizontalSpeed, playerBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, 5.0f);
            audioSource.PlayOneShot(jumpSoundClip);
        }
    }
}