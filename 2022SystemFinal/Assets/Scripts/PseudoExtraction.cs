using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PseudoExtraction : MonoBehaviour, IDropHandler
{
    public int id;
    public GameObject Pseudo;
    public Transform PseudoSpawn;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                GameObject newPseudo = Instantiate(Pseudo, PseudoSpawn.position, transform.rotation) as GameObject;
                newPseudo.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                Destroy(GameObject.FindGameObjectWithTag("PseudoBase"));
            }
            else
            {
                eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
            }
        }
    }
}
