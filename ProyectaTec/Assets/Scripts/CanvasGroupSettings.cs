using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasGroupSettings : MonoBehaviour
{
    [Header("Initial settings")]
    [SerializeField] [Range(0,1)] float alpha_float = 0;
    [SerializeField] bool interactable_bool = false;
    [SerializeField] bool blockRaycast_bool = false;
    
    private CanvasGroup cg;

    protected void Awake() {
        if (cg == null) {
            if (GetComponent<CanvasGroup> () == null) {
                cg = this.gameObject.AddComponent (typeof(CanvasGroup)) as CanvasGroup; 
            } else {
                cg = this.GetComponent<CanvasGroup> (); 
            }
        } 
    }

    void Start()
    {
        cg.alpha = alpha_float;
        cg.interactable = interactable_bool;
        cg.blocksRaycasts = blockRaycast_bool;
    }

    public void SetInteractable(bool interactable)
    {
        if (interactable) {
            cg.alpha = 1;    
        }else{
            cg.alpha = 0;  
        }
        cg.interactable = interactable;
        cg.blocksRaycasts = interactable;
    }


}
