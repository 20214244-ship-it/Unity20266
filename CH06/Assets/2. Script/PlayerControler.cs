using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    float jumpForce = 680.0f;
    float walkforce = 30f;
    float maxwalkSpeed = 2.0f;

    public Sprite[] walkSprites;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;


    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKeyDown(KeyCode.RightArrow)) key = 1;

        float speedx = Mathf.Abs(rb.linearVelocity.x);

        if (speedx < maxwalkSpeed)
        {
            rb.AddForce(transform.right * key * walkforce);
        }
        time += Time.deltaTime;
        if (time > animationPeriod)
        {
            time = 0;
            sr.sprite = walkSprites[idx];

        }
    }
}