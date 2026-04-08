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

    bool touched;

    // the array of logs
    string[] comments;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // hide the UI
        UI.SetActive(false);
        UIText.SetActive(false);
        comments = new string[5]; 
        comments[0] = "I touched the box!";
        comments[1] = "Box has been touched!";
        comments [2] = "This box is purple!";
        comments[3] = "I like boxes!";
        comments[4] = "Okay ran out of ideas!";
        // so you can't keep spamming interactions
        touched = false;

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

        // wait 3 secs
        yield return new WaitForSeconds(1.5f);

        // hide the UI
        UI.SetActive(false);
        UIText.SetActive(false);
        touched = false;
    }






// to type each friend char by char
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
        if(touched == false)
        { 
            touched = true;
            // choose a random number
            int randoNumbo = UnityEngine.Random.Range(0,5);
            logs = comments[randoNumbo];
            // run the helper function
            Display(logs);
           
        }
        else
        {
            Debug.Log("Wait please!");
        }

        
        
    }

 



}
