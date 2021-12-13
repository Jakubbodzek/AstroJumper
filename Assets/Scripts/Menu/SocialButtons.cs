using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SocialButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private RectTransform logoAnimation;



    private void Start()
    {
        logoAnimation.GetComponent<Animator>().Play("LogoOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        logoAnimation.GetComponent<Animator>().Play("LogoOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        logoAnimation.GetComponent<Animator>().Play("LogoOff");
    }
}
