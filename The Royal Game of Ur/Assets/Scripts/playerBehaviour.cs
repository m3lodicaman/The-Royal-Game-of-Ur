using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    private GameObject selectedChip;

    [SerializeField] private int player;

    private bool click;

    void Start()
    {
        selectedChip = null;
        if(player == 0)
        {
            gameState.redPlayer = this;
        }
        else
        {
            gameState.bluePlayer = this;
        }
    }

    void Update()
    {
        click = Input.GetMouseButtonDown(0);
    }

    private void FixedUpdate()
    {
        if (selectedChip != null && click && gameState.playerTurn == player)
        {
            selectedChip.transform.position = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - new Vector3(0,0,-10f);
            selectedChip.transform.position = new Vector3(0.5f + selectedChip.transform.position.x - selectedChip.transform.position.x % 1, selectedChip.transform.position.y - selectedChip.transform.position.y % 1, 0);
            selectedChip = null;
        }
    }

    public GameObject GetSelectedChip()
    {
        return selectedChip;
    }
    public void SetSelectedChip(GameObject g)
    {
        selectedChip = g;
    }
}
