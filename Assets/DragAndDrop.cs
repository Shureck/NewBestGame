using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectPiece;
    public GameObject mainCam;
    public GameObject server;
    public GameObject normServer;
    public int piece = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (piece == 0){
            mainCam.SetActive(true);
            server.SetActive(false);
            normServer.SetActive(true);
            gameObject.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if(hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<Puzzle>().inRightPos)
                {
                    selectPiece = hit.transform.gameObject;
                    selectPiece.GetComponent<Puzzle>().selected = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0)){
            selectPiece.GetComponent<Puzzle>().selected = false;
            if (selectPiece.GetComponent<Puzzle>().inRightPos)
            {
                piece--;
            }
            selectPiece = null;
        }

        if (selectPiece != null){
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectPiece.transform.position = new Vector3(mousePoint.x, mousePoint.y, 0);
        }
    }
}
