﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OrleansWebAPI7AppDemo.Models;

namespace OrleansWebAPI7AppDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SimpleValueController : ControllerBase
    {

        public SimpleValueController()
        {
        }

        [HttpGet()]
        public String TestValue()
        {
            return "あいうえお";
        }


        [HttpGet()]
        public IEnumerable<string> TestArray()
        {
            string[] items = new string[] { "あいうえお", "かきくけこ", "さしすせそ" };
            return items;
        }

        [HttpGet()]
        public Animal TestObject()
        {
            Animal animal_1 = new Animal();
            animal_1.Name = "トランスフォーマー";
            return animal_1;
        }

        [HttpGet()]
        public IActionResult StatusCode()
        {
            return StatusCode(200);
        }

        [HttpPost()]
        public Animal TestPostObject(Animal animal)
        {
            animal.Age = 20;
            return animal;
        }
    }
}
