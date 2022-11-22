using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PurpleSolutionCrafting : MonoBehaviour, IDropHandler
{
    public int id1;
    public int id2;
    public int id3;
    public GameObject PurpleSolution;
    public Transform PurpleSpawn;

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
            }

            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id ==  id3)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                GameObject newPseudo = Instantiate(PurpleSolution, PurpleSpawn.position, transform.rotation) as GameObject;
                newPseudo.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                Destroy(GameObject.FindGameObjectWithTag("I2"));
                Destroy(GameObject.FindGameObjectWithTag("RedPhosphorus"));
                GameObject[] pseudo = GameObject.FindGameObjectsWithTag("Pseudo");
                foreach (GameObject Pseudo in pseudo)
                    GameObject.Destroy(Pseudo);
            }
        }
    }
}
