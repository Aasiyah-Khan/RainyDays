using UnityEngine;

public class Roll_Window : MonoBehaviour
{
    public Rigidbody2D rb;
    //public Transform posY;

    public Transform window;

    public GameObject Button_Down;
    public GameObject Button_Up;

    bool isMoving;

    public float moveSpeed = -5f;
    //public float maxPos = -6.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving == true)
        {
            rb.linearVelocityY = moveSpeed * Time.deltaTime;
        }
        
        if (isMoving == false)
        {
            rb.linearVelocityY = 0;
        }

        if (window.position.y <= -6.5f)
        {
            rb.linearVelocityY = 0;
            ButtonDownOff();
        }

        if (window.position.y >= 1.05f)
        {
            rb.linearVelocityY = 0;
            ButtonDownOn();
        }
    }

    public void Move()
    {
        isMoving = true;
    }

    public void Stop()
    {
        isMoving = false;
    }

    public void ButtonDownOff()
    {
        Button_Down.SetActive(false);

        Button_Up.SetActive(true);
    }

    public void ButtonDownOn()
    {
        Button_Down.SetActive(true);

        Button_Up.SetActive(false);
    }
}
