using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pickedMaterial = 0;
    public GameObject[] material;
    public Item item;
    public Text scoreText;
    public Text sakupljaj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Material")
        {
            if (pickedMaterial < 3)
            {
                pickedMaterial++;
            }
        }

        if (other.gameObject.tag == "Wall")
        {
            if (pickedMaterial == 3)
            {
                pickedMaterial = 0;
            }
        }
    }

    private void Start()
    {
        material = GameObject.FindGameObjectsWithTag("Material");
        UpdateText(pickedMaterial, 3);
    }

    private void Update()
    {
        UpdateText(pickedMaterial, 3);

    }

    public void UpdateText(int kolkoImamo, int kolkoJeMax)
    {
        scoreText.text = kolkoImamo + "/" + kolkoJeMax;
    }
}
