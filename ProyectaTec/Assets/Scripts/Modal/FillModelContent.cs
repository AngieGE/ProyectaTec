using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FillModelContent : MonoBehaviour
{
    [SerializeField] private SO_Proyector _proyector;
    [SerializeField] private TextMeshProUGUI titulo;
    [SerializeField] private TextMeshProUGUI modelo;
    [SerializeField] private TextMeshProUGUI descripcion;

    private void OnEnable()
    {
        _proyector.SetProyectorAction += FillContent;
    }

    private void OnDisable()
    {
        _proyector.SetProyectorAction -= FillContent;
    }
    void FillContent()
    {
        titulo.text         = _proyector.proyector.titulo;
        modelo.text         = _proyector.proyector.modelo;
        descripcion.text    = _proyector.proyector.descripcion;
    }

}
