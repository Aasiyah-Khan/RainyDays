using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject dog_Frame1;
    public GameObject dog_Frame2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bark()
    {
        dog_Frame1.SetActive(false);

        dog_Frame2.SetActive(true);
    }

    public void NoBark()
    {
        dog_Frame1.SetActive(true);

        dog_Frame2.SetActive(false);
    }
}
