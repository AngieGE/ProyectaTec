using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
 public enum ButtonType : int
 {
     play = 0,
     pause,

 };
public class PlayPause : MonoBehaviour
{
    [SerializeField] ButtonType buttonType = ButtonType.play;
    [SerializeField] VideoPlayer videoPlayer = null;

    void Update()
    {
        if (buttonType == ButtonType.pause)
        {
            if (videoPlayer.isPlaying == true)
            {
                this.GetComponent<CanvasGroupSettings>().SetInteractable(true);
            }else{
                this.GetComponent<CanvasGroupSettings>().SetInteractable(false);
            }
        }else if(buttonType == ButtonType.play){
            if (videoPlayer.isPlaying == true)
            {
                this.GetComponent<CanvasGroupSettings>().SetInteractable(false);   
            }else{
                this.GetComponent<CanvasGroupSettings>().SetInteractable(true);
            }
        }
    }
}
