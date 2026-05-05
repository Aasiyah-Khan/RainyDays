using UnityEngine;
using UnityEngine.Video;

public class Video_Caller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();

        vp.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Road_Bg_Video.mp4");
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
