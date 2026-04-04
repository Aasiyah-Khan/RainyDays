using UnityEngine;
using System.Collections;
using TMPro;


public class Monologue : MonoBehaviour
{
     // need access to the UI
    public GameObject UI;
    // and the ui text
    public GameObject UIText;
    // and to put the text
    string logs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // hide the UI
        UI.SetActive(false);
        UIText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UIDisplay(string message)
    {
        // I wanna show the UI
        UI.SetActive(true);
        UIText.SetActive(true);


        // use the typing coroutine i made
        yield return StartCoroutine(TypeSentence(message));






        // wait 2 secs
        yield return new WaitForSeconds(2f);




        // hide the UI
        UI.SetActive(false);
        UIText.SetActive(false);
    }






// to type each friend char bh char
    IEnumerator TypeSentence(string sentence)
    {


        logs = "";
        foreach (char letter in sentence.ToCharArray())
        {
            logs += letter;
             UIText.GetComponent<TextMeshProUGUI>().text = logs;
            yield return new WaitForSeconds(0.02f);
        }
    }




// just to make this whol process a bit faster (showing dialogue)
    public void Display(string message)
    {
        StartCoroutine(UIDisplay(message));
    }

    public void Interaction()
    {
        logs = "This is a test message.";
        Display(logs);
    }



}
