using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonReaction : MonoBehaviour
{
    [SerializeField]
    private PotionType type;

    [SerializeField]
    private FortuneResults reaction;

    public void ButtonClicked()
    {
        reaction.PotionSelected(type);
    }
}
