using UnityEngine;

public class Window_Button_Switcher : MonoBehaviour
{
    public GameObject Button_Down;
    public GameObject Button_Up;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y <= -6.5f)
        {
            ButtonDownOff();
        }

        if (transform.position.y >= 1.05f)
        {
            ButtonDownOn();
        }
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
