using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private RectTransform startButton;



    private void Start()
    {
        startButton.GetComponent<Animator>().Play("HoverOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        startButton.GetComponent<Animator>().Play("HoverOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        startButton.GetComponent<Animator>().Play("HoverOff");
    }


}
