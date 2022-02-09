using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private RectTransform button;
    private void Start()
    {
        button.GetComponent<Animator>().Play("HoverOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.GetComponent<Animator>().Play("HoverOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.GetComponent<Animator>().Play("HoverOff");
    }


}
