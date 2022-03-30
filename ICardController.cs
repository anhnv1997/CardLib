using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary
{
    public interface ICardController
    {
        string GetCardHexNumber(string cardNumber);
        int CardLen();
    }
}
