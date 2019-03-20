using Microsoft.AspNetCore.Mvc;
using MTGToolbox.Abstract;

namespace MTGToolbox.Web.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;

        public CardController(ICardRepository card)
        {
            _cardRepository = card;
        }

        public IActionResult GridList()
        {
            var cards = _cardRepository.GetCards();

            return View(cards);
        }
    }
}