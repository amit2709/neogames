using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Neogames.Models;
using System;

namespace Neogames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {

        private static List<Purchase> PurchasesList = new List<Purchase> {
          new Purchase() { 
            id = 1,
            Amount = 1,
            PurchaseDate = new DateTime(2019,11,26,16,09,31)
          },
          new Purchase() {
            id = 2,
            Amount = 5,
            PurchaseDate = new DateTime(2019,11,26,16,09,31)
          },
          new Purchase() {
            id = 3,
            Amount = 56,
            PurchaseDate = new DateTime(2019,11,26,16,09,32)
          },
          new Purchase() {
            id = 4,
            Amount = 22,
            PurchaseDate = new DateTime(2019,11,26,16,09,32)
          },
          new Purchase() {
            id = 5,
            Amount = 145.5,
            PurchaseDate = new DateTime(2019,11,26,16,09,32)
          },
          new Purchase() {
            id =6,
            Amount = 35.56,
            PurchaseDate = new DateTime(2019,11,26,16,09,32)
          },
        };

        private readonly ILogger<PurchasesController> _logger;

        public PurchasesController(ILogger<PurchasesController> logger)
        {
            _logger = logger;
        }

        // GET: api/Purchases/date/bulkSize
        [HttpGet("{date}/{bulkSize}")]
        public IEnumerable<Purchase> GetPurchase(DateTime date, int size)
        {
            int counter = 0;
            List<Purchase> newPurchasesList = new List<Purchase>();// create new list
            while (size == newPurchasesList.Count) { //loop that run until the size of the list is equel the size we get
                if (date < PurchasesList[counter].PurchaseDate)// check the date we get with the place of the counter inside the list
                {
                    newPurchasesList[counter] = PurchasesList[counter];
                    PurchasesList.RemoveAt(counter);
                }
                counter++;
            }
            return newPurchasesList;
        }

        // GET: api/Purchases/date/bulkSize answer to the 4 question
        [HttpGet("{date}/{bulkSize}")]
        public IEnumerable<Purchase> GetPurchaseFix(DateTime date, int size)
        {
            int counter = 0;
            List<Purchase> newPurchasesList = new List<Purchase>();
            while (size == newPurchasesList.Count)
            {
                if (date.Date < PurchasesList[counter].PurchaseDate.Date)
                {
                    newPurchasesList[counter] = PurchasesList[counter];
                    PurchasesList.RemoveAt(counter);
                }
                counter++;
            }
            return newPurchasesList;
        }
    }
}
