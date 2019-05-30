﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/List", order = 1)]
public class ScriptableMusicClassArkanoid : ScriptableObject
{
    public AudioClip[] audioClips;
}
