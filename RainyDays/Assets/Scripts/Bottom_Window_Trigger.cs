using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bottom_Window_Trigger : MonoBehaviour
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
            Debug.Log("Bottom Trigger Hit");

            //hasStopped = true;

            //collision.GetComponent<Roll_Window>().Stop();
            windowController.Stop();

            //buttonDown.SetActive(false);
            //Button_Down.enabled = false;

            //buttonUp.SetActive(true);
            //Button_Up.enabled = true;
        }
    }
}
