using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBoard : MonoBehaviour
{
    public GameObject BoardQuadrant;
    public int Dimensions;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Dimensions; i++)
        {
            for (int j = 0; j < Dimensions; j++){
                GameObject temp = Instantiate(BoardQuadrant);
                temp.transform.position = new Vector3(5 * j, 0, 5 * i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
