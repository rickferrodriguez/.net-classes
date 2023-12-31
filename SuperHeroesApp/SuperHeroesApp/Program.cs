﻿using SuperHeroesApp.Models;

var flyPower = new SuperPower();
flyPower.Name = "Fly Power";
flyPower.Description = "The hability to levitate in the air";
flyPower.Level = LevelOfPower.Level1;

var superStrong = new SuperPower();
superStrong.Name = "Super Strong";
superStrong.Description = "When a person has x10 strength than a Human";
superStrong.Level = LevelOfPower.Level2;

var bulletResistance = new SuperPower();
bulletResistance.Name = "Bullet Resistance";
bulletResistance.Description = "The skin is strong enough to don't get damage by a bullet";
bulletResistance.Level = LevelOfPower.Level3;

var superman = new SuperHero();
var hulk = new SuperHero();
// antiheroes
var joker = new AntiHero();

var jokerPowers = new List<SuperPower>();
jokerPowers.Add(superStrong);

joker.Id = 1;
joker.Name = "Joker";
joker.RealName = "Jack Napier";
joker.CanFly = false;
joker.City = "Gotham";
joker.Powers = jokerPowers;

// we create a variable to have a list of powers only for superman
List<SuperPower> superManSuperPowers = new List<SuperPower>();
superManSuperPowers.Add(flyPower);
superManSuperPowers.Add(superStrong);
superManSuperPowers.Add(bulletResistance);

superman.Id = 1;
superman.Name = "SuperMan    ";
superman.RealName = "Clark Kent";
superman.City = "Small Ville";
superman.Powers = superManSuperPowers;
superman.CanFly = true;
// we creat a variable to have a list of powers only for hulk
List<SuperPower> hulkSuperPowers = new List<SuperPower>();
hulkSuperPowers.Add(superStrong);
hulkSuperPowers.Add(bulletResistance);

hulk.Id = 2;
hulk.Name = "hulk";
hulk.RealName = "Bruce Banner";
hulk.City = "New York";
hulk.CanFly = false;
hulk.Powers = hulkSuperPowers;

Console.WriteLine(superman.UseSuperPowers());
Console.WriteLine(joker.StringNemesis("Batman"));

