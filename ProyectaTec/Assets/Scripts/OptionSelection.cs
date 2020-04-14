using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSelection : MonoBehaviour
{
    private Button OptionBtn;
    [SerializeField] private CanvasGroup cgOption = null;
    private CanvasGroup theParentCanvas;

    void Awake(){
        OptionBtn = this.GetComponent<Button>();
    }

    void Start()
    {
        OptionBtn.onClick.AddListener(OpenProjectorTutorial);
        //Get the camvas group this element belongs to
        GameObject theParent = this.transform.parent.gameObject;
        theParentCanvas = theParent.GetComponent<CanvasGroup>();
        int a = 0;
        while (theParentCanvas == null){
            theParent       = theParent.transform.parent.gameObject;
            theParentCanvas = theParent.GetComponent<CanvasGroup>(); 
            if (a++ >5) break;
        }
    }

    void OpenProjectorTutorial()
    {
        if (cgOption != null){
            Debug.Log($"Selected ${cgOption.name}");  
            cgOption.GetComponent<CanvasGroupSettings>().SetInteractable(true);
        }
        theParentCanvas.GetComponent<CanvasGroupSettings>().SetInteractable(false);

    }
}
