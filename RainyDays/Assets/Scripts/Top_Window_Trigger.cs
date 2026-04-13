using UnityEngine;
using UnityEngine.UI;

public class Top_Window_Trigger : MonoBehaviour
{
    public Roll_Window windowController;

    public GameObject buttonDown;
    public GameObject buttonUp;

    public Button Button_Down;
    public Button Button_Up;

    bool hasStopped = false;

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
        //if (hasStopped) return;

        if (collision.gameObject.name == "Window")
        {
            Debug.Log("Top Trigger Hit");

            //hasStopped = true;

            windowController.Stop();

            buttonDown.SetActive(true);
            //Button_Down.enabled = true;

            buttonUp.SetActive(false);
            //Button_Up.enabled = false;
        }
    }
}
