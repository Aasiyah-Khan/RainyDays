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
    string[] dogComments;
    string[] monsterComments;
    string[] guitarComments;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // hide the UI
        UI.SetActive(false);
        UIText.SetActive(false);
        // set up for the monologue
        comments = new string[5]; 
        comments[0] = "I touched the box!";
        comments[1] = "Box has been touched!";
        comments [2] = "This box is purple!";
        comments[3] = "I like boxes!";
        comments[4] = "Okay ran out of ideas!";

        // Im a fricken idiot and will never copy and paste again i wasted a fricken hour trying to figure out what was wrong and my slow brain finally got it
        dogComments = new string[4]; 
        dogComments[0] = "I'm gonna miss you, bud!";
        dogComments[1] = "Stop looking at me like that; I have no food.";
        dogComments [2] = "You're the only one that gets me.";
        dogComments[3] = "I wish I was as carefree as you.";

        monsterComments = new string[3]; 
        monsterComments[0] = "I'm gonna make this can last the whole ride.";
        monsterComments[1] = "I should've brought two cans.";
        monsterComments [2] = "I wish I had another monster.";
      
        guitarComments = new string[4]; 
        guitarComments[0] = "The last gig we had was lit.";
        guitarComments[1] = "I remember getting that sticker from Comic Con.";
        guitarComments [2] = "Maybe I'll make a friend who also plays.";
        guitarComments [3] = "I wonder if the band will ever play together again...";
      



        

        




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

    // another helper method cuz I aint repeating myself
    public void Touched(string[] comments, int commentsLength)
    {
                // choose a random number
                int randoNumbo = UnityEngine.Random.Range(0, commentsLength);
                logs = comments[randoNumbo];
                // run the helper function
                Display(logs);
                
    }

    public void Interaction()
    {
        if(touched == false)
        { 
            touched = true;
            if(this.gameObject.name == "Dog Button")
            {
                Debug.Log("Dog clicked");
               
                Touched(dogComments, dogComments.Length);
            }
            else if(this.gameObject.name == "Monster")
            {
                Debug.Log("Monster clicked");
                
                Touched(monsterComments, monsterComments.Length);
            }
            else if(this.gameObject.name == "getar")
            {
                 Debug.Log("Guitar clicked");
                 
                Touched(guitarComments, guitarComments.Length);
            }
            else
            {
               
                Touched(comments, comments.Length);
            }
            
           
        }
        else
        {
            Debug.Log("Wait please!");
        }

        
        
    }

 



}
