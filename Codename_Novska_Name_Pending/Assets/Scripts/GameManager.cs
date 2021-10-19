using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pickedMaterial;
    public GameObject[] material;
    public UiManager uiM;

    private void Start()
    {
        uiM = FindObjectOfType<UiManager>();
        material = GameObject.FindGameObjectsWithTag("Material");
        uiM.UpdateText(pickedMaterial, material.Length);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Material")
        {
            pickedMaterial++;
            uiM.UpdateText(pickedMaterial, material.Length);
            other.gameObject.SetActive(false);
        }
    }
}
