using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barracks : MonoBehaviour
{
    private void Start()
    {
        Unit Marine = SimpleFactory.CreateUnit(UnitType.Marine);
        Unit Firebat = SimpleFactory.CreateUnit(UnitType.Firebat);
        Unit Medic = SimpleFactory.CreateUnit(UnitType.Medic);

        Marine.Train();
        Firebat.Train();
        Medic.Train();
    }
}
