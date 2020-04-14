using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

     public enum ProyectorType : int
 {
     proyectorConPantalla = 0,
     proyectorSinPantalla,
     proyectorDobleSinPantalla

 };

public class ProyectorSetter : MonoBehaviour
{

    [SerializeField] ProyectorType proyectorType = ProyectorType.proyectorSinPantalla;
    [SerializeField] private SO_Proyector _proyector;
    Button menuButton;
    
    void Awake()
    {
        menuButton = GetComponent<Button>();
    }

    void Start()
    {
        menuButton.onClick.AddListener(SetScriptableObject);
    }

    void SetScriptableObject()
    {
        switch(proyectorType){
            case ProyectorType.proyectorConPantalla:
                _proyector.SetProyector(LoadData.ContentData.p1);
            break;
            case ProyectorType.proyectorSinPantalla:
                _proyector.SetProyector(LoadData.ContentData.p2);
            break;
            case ProyectorType.proyectorDobleSinPantalla:
                _proyector.SetProyector(LoadData.ContentData.p3);
            break;
        }
    }
}
