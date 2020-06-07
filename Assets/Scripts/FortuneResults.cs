using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PotionType {Red, White, Blue, Yellow, Pink, Orange, Black };

public class FortuneResults : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI fortune;

    private string[,] fortuneResult;

    private PotionType firstPotion;
    private bool secondPotion;


    private void Start()
    {
        #region Fortune Results
        fortuneResult = new string[7, 7];


        fortuneResult[0, 0] = "If at first you don't succeed, then skydiving definitely isn't for you - Steven Wright";
        fortuneResult[0, 1] = "A flock of crows is known as a murder";
        fortuneResult[0, 2] = "On a scale from 1-10, you're an 11";
        fortuneResult[0, 3] = "You're like a ray of sunshine on a gloomy day";
        fortuneResult[0, 4] = "All pandas in zoos around the world are on loan from china";
        fortuneResult[0, 5] = "The British royal family is not allowed to play monopoly";
        fortuneResult[0, 6] = "The Pokémon Hitmonlee and Hitmonchan are based off of Bruce Lee and Jackie Chan";

        fortuneResult[1, 0] = "You light up the entire room";
        fortuneResult[1, 1] = "Love is trash, bitches need cash - Ghandi";
        fortuneResult[1, 2] = "You deserve every good hug";
        fortuneResult[1, 3] = "You should be proud of yourself";
        fortuneResult[1, 4] = "The entire world's population could fit inside LA";
        fortuneResult[1, 5] = "I am so grateful to have you in my life";
        fortuneResult[1, 6] = "You are the most prefect just as you are";

        fortuneResult[2, 0] = "Horizontal refreshment was the 19th century slang for sex";
        fortuneResult[2, 1] = "Bananas are curved because they grow towards the sun";
        fortuneResult[2, 2] = "Happiness is just sadness that hasn't happened yet - Unknown";
        fortuneResult[2, 3] = "You were cool before hipsters were cool";
        fortuneResult[2, 4] = "Some cats are allergic to people";
        fortuneResult[2, 5] = "For a short time, the planet Uranus was named George";
        fortuneResult[2, 6] = "The Twitter bird has a name - His name is Larry";

        fortuneResult[3, 0] = "Cornflakes were invented to prevent masturbation";
        fortuneResult[3, 1] = "A baby octopus is about the size of a flea when it is born";
        fortuneResult[3, 2] = "Norway introduced salmon sushi to Japan";
        fortuneResult[3, 3] = "The light at the end of the tunnel has been turned off due to budget cuts - unknown";
        fortuneResult[3, 4] = "The unicorn is the national animal of Scotland";
        fortuneResult[3, 5] = "A *Buttload* is a real measurement of weight";
        fortuneResult[3, 6] = "Dying is illegal in the Houses of Pairlaments";

        fortuneResult[4, 0] = "You are a gift to those around you";
        fortuneResult[4, 1] = "You look gorgeous today";
        fortuneResult[4, 2] = "I like your style";
        fortuneResult[4, 3] = "You have the best laugh";
        fortuneResult[4, 4] = "Life is like a penis, it gets really hard for no reason, and you don't know what to do with it";
        fortuneResult[4, 5] = "The beauty of your soul inspires me";
        fortuneResult[4, 6] = "You will be blessed with luck";

        fortuneResult[5, 0] = "Everyone would be lucky to have a friend like you";
        fortuneResult[5, 1] = "Fear of the number 13 i called triskaidekaphobia";
        fortuneResult[5, 2] = "Your aura shines like a radiant light";
        fortuneResult[5, 3] = "You're a smart cookie";
        fortuneResult[5, 4] = "The people who are alive now represent 7% of the total number of people who have ever lived";
        fortuneResult[5, 5] = "Friendship is like peeing on yourself: Everyone can see it, but only you get the warm feeling it brings - Robert Bloch";
        fortuneResult[5, 6] = "Honeybees can recognize human faces";

        fortuneResult[6, 0] = "Your outfit is wonderful";
        fortuneResult[6, 1] = "The speed of the computer mouse is measured in Mickeys";
        fortuneResult[6, 2] = "You have a gorgeous personality";
        fortuneResult[6, 3] = "I aspire to be like you";
        fortuneResult[6, 4] = "The Canary Islands are named after dogs, not birds";
        fortuneResult[6, 5] = "You are more helpful than you might realize";
        fortuneResult[6, 6] = "Never put off until tomorrow, what you can do the day after tomorrow - Mark Twain";

        #endregion
    }

    public void PotionSelected(PotionType type)
    {
        if (secondPotion == false)
        {
            firstPotion = type;
            secondPotion = true;
        }
        else
        {
            fortune.text = fortuneResult[(int)firstPotion, (int)type];
            secondPotion = false;
        }
    }
}