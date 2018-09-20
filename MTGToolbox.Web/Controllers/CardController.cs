using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTGToolbox.Repository;

namespace MTGToolbox.Web.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;

        public CardController(ICardRepository card)
        {
            _cardRepository = card;
        }

        public IActionResult Index()
        {
            var cards = _cardRepository.GetAllCards().OrderBy(c => c.Name);

            return View(cards);
        }
    }
}