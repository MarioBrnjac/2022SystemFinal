using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlueStuffCrafting : MonoBehaviour, IDropHandler
{
    public int id1;
    public int id2;
    public GameObject BlueStuff;
    public Transform BlueSpawn;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id1)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            }

            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id2)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                GameObject blueStuff = Instantiate(BlueStuff, BlueSpawn.position, transform.rotation) as GameObject;
                blueStuff.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                Destroy(GameObject.FindGameObjectWithTag("P2P"));
                GameObject[] purpleSolution = GameObject.FindGameObjectsWithTag("PurpleSolution");
                foreach (GameObject PurpleSolution in purpleSolution)
                    GameObject.Destroy(PurpleSolution);
            }
        }
    }
}
