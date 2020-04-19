using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoClipSetter : MonoBehaviour
{
    [SerializeField] private SO_Proyector _proyector;
    private VideoPlayer videoPlayer;
    
    private void OnEnable()
    {
        _proyector.SetProyectorAction += LoadVideo;
    }

    private void OnDisable()
    {
        _proyector.SetProyectorAction -= LoadVideo;
    }

    void Start()
    {
        videoPlayer = this.GetComponent<VideoPlayer>();
    }

    void LoadVideo()
    {
        Debug.Log($"Load video {_proyector.proyector.tutorial_Link}" );
        videoPlayer.clip = Resources.Load(_proyector.proyector.tutorial_Link) as VideoClip;
    }
}
