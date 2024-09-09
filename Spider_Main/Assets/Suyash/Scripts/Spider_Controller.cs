using UnityEngine;

public class Spider_Controller : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f;

    private Animator animator;
    private AudioSource audioSource;

    private bool isPlaying = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); // Reference the existing AudioSource

        if (animator == null)
        {
            Debug.LogError("No Animator component found on this spider");
        }

        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component found on this spider");
        }
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        bool isWalking = movement.magnitude > 0;
        animator.SetBool("isWalking", isWalking);

        // Trigger the sound only when the spider is moving
        if (isWalking && !isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else if (!isWalking && isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}
