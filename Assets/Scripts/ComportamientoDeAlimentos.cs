using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoDeAlimentos : MonoBehaviour
{
    public GameObject[] food;
    private int i;

    void Start()
    {
        food[i].SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Proximacomida();
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            Volvercomida();
    }

    private void Proximacomida()
    {
        food[i].SetActive(false);
        i++;
        if (i >= food.Length)
            i = 0;
        food[i].SetActive(true);
    }

    private void Volvercomida()
    {
        food[i].SetActive(false);
        i--;
        if (i <= 0)
            i = food.Length - 1;
        food[i].SetActive(true);
    }
}

