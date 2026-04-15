using UnityEngine;

public class Kick_Chair : MonoBehaviour
{
    public GameObject bg1;
    public GameObject bg2;

    public GameObject leg1;
    public GameObject leg2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kick()
    {
        bg1.SetActive(false);
        bg2.SetActive(true);

        leg1.SetActive(false);
        leg2.SetActive(true);
    }

    public void NoKick()
    {
        bg1.SetActive(true);
        bg2.SetActive(false);

        leg1.SetActive(true);
        leg2.SetActive(false);
    }
}
