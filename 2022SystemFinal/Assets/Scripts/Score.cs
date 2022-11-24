using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Score : MonoBehaviour, IDropHandler
{
    public Text scoreText;
    private int score;
    public int id;

    void Start()
    {

        scoreText.text = "";

    }

    void Update()
    {

        scoreText.text = "$" + score;

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                score = score + 100;
            }

        }
    }
}