using UnityEngine;

public class Spider_Controller : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("No Animator component found on this spider");
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

        if (isWalking)
        {
            animator.Play("Run");
        }
        else
        {
            animator.Play("Idle");
        }
    }
}
