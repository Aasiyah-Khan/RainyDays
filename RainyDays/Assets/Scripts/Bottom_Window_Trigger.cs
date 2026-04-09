using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bottom_Window_Trigger : MonoBehaviour
{
    public Rigidbody2D window;

    public GameObject buttonDown;
    public GameObject buttonUp;

    public Button Button_Down;
    public Button Button_Up;

    public bool stop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Window")
        {
            Debug.Log("Bottom Trigger Hit");

            //window.linearVelocityY = 0;
            stop = true;

            buttonDown.SetActive(false);
            Button_Down.enabled = false;

            buttonUp.SetActive(true);
            Button_Up.enabled = true;
        }
    }
}
