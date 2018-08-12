﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    private Player player;
    private List<Hero> availableHeroes;

	void Start () {
        player = new Player("test", 0, 1000);
        availableHeroes = new List<Hero>();

        spawnHeroes(5);
        foreach (Hero hero in availableHeroes)
            hero.Log();
	}
	
	void Update () {
		
	}

    public void spawnHeroes(int count) {
        for(int i = 0; i < count; i++)
            availableHeroes.Add(HeroGenerator.GenerateHero());
    }
}