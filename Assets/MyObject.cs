using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyObject : MonoBehaviour, IPointerDownHandler
{

    public GameObject PlayerPiece;

    private void Start()
    {
        AddPhysics3DRaycaster();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        string TargetQuadrant;
        string TargetQuadrantDirections;

        //Find the game object
        TargetQuadrant = eventData.pointerCurrentRaycast.gameObject.name;
        Debug.Log("Clicked: " + TargetQuadrant);

        //last two characters of quadrant name is directions for where to drop piece
        TargetQuadrantDirections = TargetQuadrant.Substring(TargetQuadrant.Length - 2);
        Debug.Log("everything =" + TargetQuadrantDirections);

        //Tried doing a loop but i got annoyed  @ errors converting from char to int.
        //TODO: Come back and make this dynamic


        //TODO: Honestly just come back and make this its own class. Have it determine who's "turn" it is to drop Xs or Os and bam, you got tictactoe
        GameObject NewPiece = Instantiate(PlayerPiece);
        switch (TargetQuadrantDirections)
        {
            case "00":
                NewPiece.transform.position = new Vector3((float)-2.5, 16, (float)-2.5);
                break;
            case "01":
                NewPiece.transform.position = new Vector3((float)2.5, 16, (float)-2.5);
                break;
            case "02":
                NewPiece.transform.position = new Vector3((float)7.5, 16, (float)-2.5);
                break;
            case "10":
                NewPiece.transform.position = new Vector3((float)-2.5, 16, (float)2.5);
                break;
            case "11":
                NewPiece.transform.position = new Vector3((float)2.5, 16, (float)2.5);
                break;
            case "12":
                NewPiece.transform.position = new Vector3((float)7.5, 16, (float)2.5);
                break;
            case "20":
                NewPiece.transform.position = new Vector3((float)-2.5, 16, (float)7.5);
                break;
            case "21":
                NewPiece.transform.position = new Vector3((float)2.5, 16, (float)7.5);
                break;
            case "22":
                NewPiece.transform.position = new Vector3((float)7.5, 16, (float)7.5);
                break;
        }
        
    }

    private void AddPhysics3DRaycaster()
    {
        PhysicsRaycaster physicsRaycaster = FindObjectOfType<PhysicsRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
        }
    }
}