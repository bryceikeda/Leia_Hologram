using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject cone;
    public GameObject video;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += EndReached; 
    }

    public void Play()
    {
        button.SetActive(false);
        cone.SetActive(true);
        video.SetActive(true);
        videoPlayer.Play();
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        cone.SetActive(false);
        video.SetActive(false);
        button.SetActive(true);
    }
}
