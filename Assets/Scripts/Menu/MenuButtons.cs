using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private RectTransform buttonAnimation;



    private void Start()
    {
        buttonAnimation.GetComponent<Animator>().Play("HoverOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonAnimation.GetComponent<Animator>().Play("HoverOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonAnimation.GetComponent<Animator>().Play("HoverOff");
    }


}
