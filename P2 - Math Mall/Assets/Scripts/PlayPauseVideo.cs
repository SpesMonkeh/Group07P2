using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPauseVideo : MonoBehaviour
{
    private VideoPlayer _videoPlayer;


    private void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
    }


    public void PlayVideoClip()
    {
        _videoPlayer.Play();
    }
    
    public void PauseVideoClip()
    {
        _videoPlayer.Pause();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
