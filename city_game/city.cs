﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace city_game
{
    class city
    {
        private string name = "Robeaton";
        private double money=100;
        private double total_hapiness;
        private population people;        
        private double available_food;        
        private int num_famrers;
        private double farm_yield=4;
        private food city_food;
        private copper city_copper;       

        public city()
        {
            people = new population(0, 2, 0);
            city_food = new food(0);
            city_copper = new copper(0);
        }

        public void Update(int num_farms)
        {            

            num_famrers = people.get_num_adults(); //for now, every adult will be a farmer

            if (num_famrers > num_farms) available_food = num_farms * farm_yield;
            else available_food = num_famrers*farm_yield;



            city_food.increment(available_food);


            people.Update(available_food);
        }

        public population get_population()
        {
            return people;
        }
        public double get_money()
        {
            return money;
        }
        public string get_name()
        {
            return name;
        }
    }
}