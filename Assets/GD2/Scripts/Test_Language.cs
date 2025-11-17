using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_Language : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        const int MaxHealthPoints = 100;
        
        int HealthPoints = 11;

        int PotionHealPoints = 3;

        HealthPoints += PotionHealPoints;

        HealthPoints++;

        float postitionX = .8f;

        bool JugementDernier = true;

        string playerName = "François";

        if (JugementDernier);

            HealthPoints = int.Parse("255");

        int modulo = 3 % 2;

        string DeboggageString = $"Player's health points : { HealthPoints }";

        (HealthPoints, PotionHealPoints) = (PotionHealPoints, HealthPoints);

        float HealthPointsFloat = 10;

        var MamdaniPoints = 10f;
        MamdaniPoints = .81f;

        HealthPoints = Increment(ref MamdaniPoints);

        postitionX = Increment(ref postitionX);
    }

    int Increment(ref int value)
    {
        return value++;
    }

    int Decrement(int value)
    {
        return value-1;
    }

    void Method(float floatValue = 10, params int[] values)
    {
        return;
    }
}

